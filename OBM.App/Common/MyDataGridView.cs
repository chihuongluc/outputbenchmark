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
            ColumnHeadersHeight = 28;
            RowHeadersVisible = false;
            RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            RowTemplate.Height = 28;
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
            AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 192, 45); // vàng nhạt
            DefaultCellStyle.SelectionForeColor = Color.White;
            BackgroundColor = Color.White;

            // Setting Column header
            EnableHeadersVisualStyles = false;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(198, 113, 0); // vàng đậm
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        }
    }
}