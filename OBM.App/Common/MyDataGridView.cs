using System.Drawing;
using System.Windows.Forms;

namespace OBM.App.Common
{
    internal class MyDataGridView : DataGridView
    {
        public MyDataGridView()
        {
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ColumnHeadersHeight = 36; // chiều cao column header
            RowHeadersVisible = false;
            RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RowTemplate.Height = 34; // chiều cao của các dòng
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //// Set độ rộng mặc định cho các column
            //for (int i = 0; i < Columns.Count - 1; i++)
            //    Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //// Set độ rộng các column theo ý người dùng
            //for (int i = 0; i < Columns.Count; i++)
            //{
            //    // Lưu lại độ rộng mặc định
            //    int colw = Columns[i].Width;

            //    Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    Columns[i].Width = colw;
            //    //Columns[i].Width = 180;
            //    // Nếu là column Email thì set độ rộng 300
            //    //if (i == 2)
            //    //    dtgv.Columns[i].Width = 300;
            //}
            //Columns[Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Setting Cell style
            BorderStyle = BorderStyle.None;
            AlternatingRowsDefaultCellStyle.BackColor = Color.White; // màu background mặc định
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DefaultCellStyle.SelectionBackColor = Color.Gainsboro; // màu background khi chọn vào 1 row
            DefaultCellStyle.SelectionForeColor = Color.FromArgb(66, 66, 66); // màu chữ khi chọn vào 1 row
            BackgroundColor = Color.White; // màu background khi không được chọn
            ForeColor = Color.FromArgb(66, 66, 66); // màu chữ khi không được chọn

            // Setting Column header
            EnableHeadersVisualStyles = false;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(99, 99, 99); // màu background column header
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // màu chữ column header
            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }
    }
}