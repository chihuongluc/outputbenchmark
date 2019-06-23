using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBM.Service;
using AutoMapper;
using OBM.App.ViewModels;
using OfficeOpenXml;
using System.IO;
using OBM.Data.Models;
using OBM.App.Mappings;

namespace OBM.App.Views
{
    public partial class ucSchedules : UserControl
    {
        public string FinalTestName { get; set; }
        public ucSchedules()
        {
            InitializeComponent();
            //LoadForm();
        }

        private void LoadForm()
        {
            LoadSubject(cbSubject);
            LoadDataGridView();
            labTitle.Text = FinalTestName;
        }

        private void LoadDataGridView()
        {
            var listRegister = RegisterService.Ins.GetMulti(null, new string[] { "Student", "Subject" });
            var listRegisterVM = Mapper.Map<List<RegisterVM>>(listRegister)
                .Select(p => new
                {
                    SBD = "",
                    ID = p.StudentID,
                    Fullname = p.Student.LastName + " " + p.Student.FirstName,
                    Course = p.Student.Course,
                    Subject = p.Subject.Name
                })
                .ToList();

            labTotal.Text = string.Format("Tổng: {0}", listRegisterVM.Count());
            dtgv.DataSource = listRegisterVM.OrderBy(p => p.Subject).ToList();

            // Xoá auto size cho tất cả các column
            for (int i = 0; i < dtgv.Columns.Count - 1; i++)
                dtgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            string[] colHeader = { "SBD", "MSSV", "Họ Tên", "Lớp", "Môn thi" };
            int[] colWidth = { 150, 150, 240, 150, 100 };

            // Đổi tên các column header và set độ rộng
            for (int i = 0; i < dtgv.Columns.Count; i++)
            {
                dtgv.Columns[i].HeaderText = colHeader[i];
                dtgv.Columns[i].Width = colWidth[i];
                if (i == dtgv.Columns.Count - 1)
                    dtgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadSubject(ComboBox cb)
        {
            var listSubjects = SubjectService.Ins.GetAll();
            var listSubjectsVM = Mapper.Map<List<SubjectVM>>(listSubjects);

            cb.DataSource = listSubjectsVM;
            cb.DisplayMember = "Name";
            cb.ValueMember = "ID";
        }

        private void BtnImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                // chỉ lọc ra các file có định dạng Excel
                dialog.Filter = "Excel|*.xlsx|Excel 2003|*.xls|All Files|*.*";

                // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // mở file excel
                    var package = new ExcelPackage(new FileInfo(dialog.FileName));

                    // lấy ra sheet đầu tiên để thao tác
                    ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

                    // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
                    for (int i = workSheet.Dimension.Start.Row + 2; i <= workSheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            // biến j biểu thị cho một column trong file
                            int j = 1;

                            // lấy ra cột MSSV tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 3
                            // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                            string studentID = workSheet.Cells[i, j++].Value.ToString();
                            string lastName = workSheet.Cells[i, j++].Value.ToString(); // họ
                            string firstName = workSheet.Cells[i, j++].Value.ToString(); // tên
                            var sexTemp = workSheet.Cells[i, j++].Value; // giới tính
                            string sex = "";
                            if (sexTemp != null)
                                sex = "Nữ";
                            else
                                sex = "Nam";
                            string dob = workSheet.Cells[i, j++].Value.ToString(); // ngày sinh
                            string birthplace = workSheet.Cells[i, j++].Value.ToString(); // nơi sinh
                            string classroom = workSheet.Cells[i, j++].Value.ToString(); // lớp
                            var phoneTemp = workSheet.Cells[i, j++].Value; // sđt
                            string phone = "";
                            if (phoneTemp != null)
                                phone = phoneTemp.ToString();
                            var emailTemp = workSheet.Cells[i, j++].Value; // email
                            string email = "";
                            if (emailTemp != null)
                                email = emailTemp.ToString();

                            string subjectID = workSheet.Cells[i, j++].Value.ToString(); // môn thi

                            // tạo studentInfo từ dữ liệu đã lấy được
                            var studentVM = new StudentVM()
                            {
                                ID = studentID,
                                LastName = lastName,
                                FirstName = firstName,
                                Gender = sex,
                                Birthday = dob,
                                Birthplace = birthplace,
                                Course = classroom,
                                Mobile = phone,
                                Email = email,
                                PassForeignLanguage = false,
                                PassInformationTechnology = false
                            };

                            // add sinh viên vào csdl
                            var student = new Student();
                            student.UpdateStudent(studentVM);
                            StudentService.Ins.Add(student);

                            // add thông tin vào bảng Register
                            Register register = new Register()
                            {
                                ID = Guid.NewGuid().ToString(),
                                StudentID = studentID,
                                SubjectID = subjectID
                            };
                            RegisterService.Ins.Add(register);
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
                if (UnitOfWork.Ins.Commit())
                {
                    MessageBox.Show("Import thành công", "");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }

        private void UcSchedules_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
