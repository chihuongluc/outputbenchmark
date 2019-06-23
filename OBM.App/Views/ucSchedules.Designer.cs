namespace OBM.App.Views
{
    partial class ucSchedules
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSchedules));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.labTotal = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnDownloadTemplate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgv = new OBM.App.Common.MyDataGridView();
            this.mySeparator6 = new OBM.App.Common.MySeparator();
            this.mySeparator3 = new OBM.App.Common.MySeparator();
            this.pnlTop.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.cbSubject);
            this.pnlTop.Controls.Add(this.btnSaveAll);
            this.pnlTop.Controls.Add(this.button1);
            this.pnlTop.Controls.Add(this.labTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 60);
            this.pnlTop.TabIndex = 5;
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.White;
            this.cbSubject.DropDownHeight = 280;
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSubject.IntegralHeight = false;
            this.cbSubject.Location = new System.Drawing.Point(438, 22);
            this.cbSubject.MaxDropDownItems = 13;
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(210, 29);
            this.cbSubject.TabIndex = 22;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveAll.FlatAppearance.BorderSize = 0;
            this.btnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAll.Image")));
            this.btnSaveAll.Location = new System.Drawing.Point(830, 20);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(120, 32);
            this.btnSaveAll.TabIndex = 17;
            this.btnSaveAll.Text = "Tách nhóm";
            this.btnSaveAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveAll.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(654, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Đánh số báo danh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labTitle.Location = new System.Drawing.Point(0, 20);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(108, 32);
            this.labTitle.TabIndex = 14;
            this.labTitle.Text = "Kỳ thi ....";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 10);
            this.panel1.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.dtgv);
            this.panel13.Controls.Add(this.panel4);
            this.panel13.Controls.Add(this.panel5);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 70);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(950, 579);
            this.panel13.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(940, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 429);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 429);
            this.panel5.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.labTotal);
            this.panel16.Controls.Add(this.mySeparator6);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 519);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(950, 60);
            this.panel16.TabIndex = 4;
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.ForeColor = System.Drawing.Color.DimGray;
            this.labTotal.Location = new System.Drawing.Point(10, 20);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(46, 20);
            this.labTotal.TabIndex = 19;
            this.labTotal.Text = "Tổng:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnImportExcel);
            this.panel14.Controls.Add(this.btnDownloadTemplate);
            this.panel14.Controls.Add(this.label3);
            this.panel14.Controls.Add(this.mySeparator3);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(950, 90);
            this.panel14.TabIndex = 3;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnImportExcel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.ForeColor = System.Drawing.Color.Green;
            this.btnImportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnImportExcel.Image")));
            this.btnImportExcel.Location = new System.Drawing.Point(654, 15);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(140, 32);
            this.btnImportExcel.TabIndex = 18;
            this.btnImportExcel.Text = "Nhập từ excel";
            this.btnImportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.BtnImportExcel_Click);
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadTemplate.FlatAppearance.BorderSize = 0;
            this.btnDownloadTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadTemplate.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadTemplate.ForeColor = System.Drawing.Color.White;
            this.btnDownloadTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnDownloadTemplate.Image")));
            this.btnDownloadTemplate.Location = new System.Drawing.Point(800, 15);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(140, 32);
            this.btnDownloadTemplate.TabIndex = 19;
            this.btnDownloadTemplate.Text = "Tải mẫu excel";
            this.btnDownloadTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadTemplate.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Danh sách dự thi";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.Location = new System.Drawing.Point(10, 90);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv.RowTemplate.Height = 34;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(930, 429);
            this.dtgv.TabIndex = 6;
            // 
            // mySeparator6
            // 
            this.mySeparator6.Dock = System.Windows.Forms.DockStyle.Top;
            this.mySeparator6.ForeColor = System.Drawing.Color.Gainsboro;
            this.mySeparator6.isVertical = false;
            this.mySeparator6.Location = new System.Drawing.Point(0, 0);
            this.mySeparator6.Name = "mySeparator6";
            this.mySeparator6.Size = new System.Drawing.Size(950, 23);
            this.mySeparator6.TabIndex = 17;
            this.mySeparator6.Text = "mySeparator6";
            this.mySeparator6.Thickness = 1;
            // 
            // mySeparator3
            // 
            this.mySeparator3.ForeColor = System.Drawing.Color.Gainsboro;
            this.mySeparator3.isVertical = false;
            this.mySeparator3.Location = new System.Drawing.Point(0, 50);
            this.mySeparator3.Name = "mySeparator3";
            this.mySeparator3.Size = new System.Drawing.Size(950, 23);
            this.mySeparator3.TabIndex = 16;
            this.mySeparator3.Text = "mySeparator3";
            this.mySeparator3.Thickness = 1;
            // 
            // ucSchedules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucSchedules";
            this.Size = new System.Drawing.Size(950, 649);
            this.Load += new System.EventHandler(this.UcSchedules_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel13;
        private Common.MyDataGridView dtgv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label labTotal;
        private Common.MySeparator mySeparator6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnDownloadTemplate;
        private System.Windows.Forms.Label label3;
        private Common.MySeparator mySeparator3;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button button1;
    }
}
