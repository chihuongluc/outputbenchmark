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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.flpSchedule = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.mySeparator2 = new OBM.App.Common.MySeparator();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.mySeparator1 = new OBM.App.Common.MySeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dtgv = new OBM.App.Common.MyDataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.mySeparator6 = new OBM.App.Common.MySeparator();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnDownloadTemplate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mySeparator3 = new OBM.App.Common.MySeparator();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSchedule.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnAddSchedule);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnSaveAll);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 60);
            this.pnlTop.TabIndex = 5;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.Image = global::OBM.App.Properties.Resources.Addnew_24px;
            this.btnAddSchedule.Location = new System.Drawing.Point(568, 20);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(115, 32);
            this.btnAddSchedule.TabIndex = 19;
            this.btnAddSchedule.Text = "Thêm mới";
            this.btnAddSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::OBM.App.Properties.Resources.edit_24px;
            this.btnEdit.Location = new System.Drawing.Point(689, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 32);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa thông tin";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveAll.FlatAppearance.BorderSize = 0;
            this.btnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Image = global::OBM.App.Properties.Resources.Save_24px;
            this.btnSaveAll.Location = new System.Drawing.Point(835, 20);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(115, 32);
            this.btnSaveAll.TabIndex = 17;
            this.btnSaveAll.Text = "Lưu tất cả";
            this.btnSaveAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveAll.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(0, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kỳ thi ....";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.cbMonth);
            this.panel1.Controls.Add(this.cbDay);
            this.panel1.Controls.Add(this.cbRoom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbMinute);
            this.panel1.Controls.Add(this.cbHour);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSubject);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 100);
            this.panel1.TabIndex = 6;
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.White;
            this.cbYear.DropDownHeight = 280;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbYear.IntegralHeight = false;
            this.cbYear.Location = new System.Drawing.Point(396, 39);
            this.cbYear.MaxDropDownItems = 13;
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(70, 29);
            this.cbYear.TabIndex = 25;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.Color.White;
            this.cbMonth.DropDownHeight = 280;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbMonth.IntegralHeight = false;
            this.cbMonth.Location = new System.Drawing.Point(326, 39);
            this.cbMonth.MaxDropDownItems = 13;
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(70, 29);
            this.cbMonth.TabIndex = 26;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.Color.White;
            this.cbDay.DropDownHeight = 280;
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbDay.FormattingEnabled = true;
            this.cbDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDay.IntegralHeight = false;
            this.cbDay.Location = new System.Drawing.Point(256, 39);
            this.cbDay.MaxDropDownItems = 13;
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(70, 29);
            this.cbDay.TabIndex = 27;
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // cbRoom
            // 
            this.cbRoom.BackColor = System.Drawing.SystemColors.Window;
            this.cbRoom.DropDownHeight = 280;
            this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbRoom.IntegralHeight = false;
            this.cbRoom.Location = new System.Drawing.Point(712, 39);
            this.cbRoom.MaxDropDownItems = 13;
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(210, 29);
            this.cbRoom.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(708, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Phòng thi:";
            // 
            // cbMinute
            // 
            this.cbMinute.BackColor = System.Drawing.SystemColors.Window;
            this.cbMinute.DropDownHeight = 280;
            this.cbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbMinute.IntegralHeight = false;
            this.cbMinute.Location = new System.Drawing.Point(589, 39);
            this.cbMinute.MaxDropDownItems = 13;
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(105, 29);
            this.cbMinute.TabIndex = 22;
            // 
            // cbHour
            // 
            this.cbHour.BackColor = System.Drawing.SystemColors.Window;
            this.cbHour.DropDownHeight = 280;
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbHour.FormattingEnabled = true;
            this.cbHour.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbHour.IntegralHeight = false;
            this.cbHour.Location = new System.Drawing.Point(484, 39);
            this.cbHour.MaxDropDownItems = 13;
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(105, 29);
            this.cbHour.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(480, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Giờ thi:";
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.SystemColors.Window;
            this.cbSubject.DropDownHeight = 280;
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbSubject.IntegralHeight = false;
            this.cbSubject.Location = new System.Drawing.Point(28, 39);
            this.cbSubject.MaxDropDownItems = 13;
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(210, 29);
            this.cbSubject.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(24, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Chuẩn đầu ra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(252, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ngày thi:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pnlSchedule);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 489);
            this.panel2.TabIndex = 7;
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.Controls.Add(this.flpSchedule);
            this.pnlSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSchedule.Location = new System.Drawing.Point(10, 90);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(280, 339);
            this.pnlSchedule.TabIndex = 7;
            // 
            // flpSchedule
            // 
            this.flpSchedule.AutoScroll = true;
            this.flpSchedule.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.flpSchedule.Location = new System.Drawing.Point(0, 0);
            this.flpSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.flpSchedule.Name = "flpSchedule";
            this.flpSchedule.Size = new System.Drawing.Size(280, 339);
            this.flpSchedule.TabIndex = 7;
            this.flpSchedule.WrapContents = false;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(290, 90);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 339);
            this.panel9.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 90);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 339);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.mySeparator2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 429);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 60);
            this.panel7.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tổng:";
            // 
            // mySeparator2
            // 
            this.mySeparator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.mySeparator2.ForeColor = System.Drawing.Color.Gainsboro;
            this.mySeparator2.isVertical = false;
            this.mySeparator2.Location = new System.Drawing.Point(0, 0);
            this.mySeparator2.Name = "mySeparator2";
            this.mySeparator2.Size = new System.Drawing.Size(300, 23);
            this.mySeparator2.TabIndex = 17;
            this.mySeparator2.Text = "mySeparator2";
            this.mySeparator2.Thickness = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.mySeparator1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 90);
            this.panel6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lịch thi";
            // 
            // mySeparator1
            // 
            this.mySeparator1.ForeColor = System.Drawing.Color.Gainsboro;
            this.mySeparator1.isVertical = false;
            this.mySeparator1.Location = new System.Drawing.Point(0, 50);
            this.mySeparator1.Name = "mySeparator1";
            this.mySeparator1.Size = new System.Drawing.Size(300, 23);
            this.mySeparator1.TabIndex = 16;
            this.mySeparator1.Text = "mySeparator1";
            this.mySeparator1.Thickness = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(300, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 489);
            this.panel3.TabIndex = 8;
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
            this.panel13.Location = new System.Drawing.Point(310, 160);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(640, 489);
            this.panel13.TabIndex = 12;
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
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dtgv.Size = new System.Drawing.Size(620, 339);
            this.dtgv.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(630, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 339);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 339);
            this.panel5.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label6);
            this.panel16.Controls.Add(this.mySeparator6);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 429);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(640, 60);
            this.panel16.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng:";
            // 
            // mySeparator6
            // 
            this.mySeparator6.Dock = System.Windows.Forms.DockStyle.Top;
            this.mySeparator6.ForeColor = System.Drawing.Color.Gainsboro;
            this.mySeparator6.isVertical = false;
            this.mySeparator6.Location = new System.Drawing.Point(0, 0);
            this.mySeparator6.Name = "mySeparator6";
            this.mySeparator6.Size = new System.Drawing.Size(640, 23);
            this.mySeparator6.TabIndex = 17;
            this.mySeparator6.Text = "mySeparator6";
            this.mySeparator6.Thickness = 1;
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
            this.panel14.Size = new System.Drawing.Size(640, 90);
            this.panel14.TabIndex = 3;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnImportExcel.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportExcel.ForeColor = System.Drawing.Color.Green;
            this.btnImportExcel.Image = global::OBM.App.Properties.Resources.Excel_24px;
            this.btnImportExcel.Location = new System.Drawing.Point(344, 15);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(140, 32);
            this.btnImportExcel.TabIndex = 18;
            this.btnImportExcel.Text = "Nhập từ excel";
            this.btnImportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportExcel.UseVisualStyleBackColor = false;
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownloadTemplate.FlatAppearance.BorderSize = 0;
            this.btnDownloadTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadTemplate.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadTemplate.ForeColor = System.Drawing.Color.White;
            this.btnDownloadTemplate.Image = global::OBM.App.Properties.Resources.Download_24px;
            this.btnDownloadTemplate.Location = new System.Drawing.Point(490, 15);
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
            // mySeparator3
            // 
            this.mySeparator3.ForeColor = System.Drawing.Color.Gainsboro;
            this.mySeparator3.isVertical = false;
            this.mySeparator3.Location = new System.Drawing.Point(0, 50);
            this.mySeparator3.Name = "mySeparator3";
            this.mySeparator3.Size = new System.Drawing.Size(640, 23);
            this.mySeparator3.TabIndex = 16;
            this.mySeparator3.Text = "mySeparator3";
            this.mySeparator3.Thickness = 1;
            // 
            // ucSchedules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucSchedules";
            this.Size = new System.Drawing.Size(950, 649);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlSchedule.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel13;
        private Common.MyDataGridView dtgv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label6;
        private Common.MySeparator mySeparator6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnDownloadTemplate;
        private System.Windows.Forms.Label label3;
        private Common.MySeparator mySeparator3;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private Common.MySeparator mySeparator1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private Common.MySeparator mySeparator2;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.FlowLayoutPanel flpSchedule;
    }
}
