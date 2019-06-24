namespace OBM.App.Views
{
    partial class UpdateSchedule
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.labTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dragControl1 = new OBM.App.Common.DragControl();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 338);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbRoom);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbMinute);
            this.panel3.Controls.Add(this.cbHour);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cbYear);
            this.panel3.Controls.Add(this.cbMonth);
            this.panel3.Controls.Add(this.cbDay);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.labTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 306);
            this.panel3.TabIndex = 3;
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
            this.cbRoom.Location = new System.Drawing.Point(50, 194);
            this.cbRoom.MaxDropDownItems = 13;
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(300, 29);
            this.cbRoom.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(46, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Phòng thi:";
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
            this.cbMinute.Location = new System.Drawing.Point(200, 134);
            this.cbMinute.MaxDropDownItems = 13;
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(150, 29);
            this.cbMinute.TabIndex = 40;
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
            this.cbHour.Location = new System.Drawing.Point(50, 134);
            this.cbHour.MaxDropDownItems = 13;
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(150, 29);
            this.cbHour.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(46, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Giờ thi:";
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
            this.cbYear.Location = new System.Drawing.Point(250, 74);
            this.cbYear.MaxDropDownItems = 13;
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(100, 29);
            this.cbYear.TabIndex = 37;
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
            this.cbMonth.Location = new System.Drawing.Point(150, 74);
            this.cbMonth.MaxDropDownItems = 13;
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(100, 29);
            this.cbMonth.TabIndex = 38;
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
            this.cbDay.Location = new System.Drawing.Point(50, 74);
            this.cbDay.MaxDropDownItems = 13;
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(100, 29);
            this.cbDay.TabIndex = 39;
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(46, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ngày thi:";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DimGray;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(20, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(360, 32);
            this.btnOK.TabIndex = 35;
            this.btnOK.Text = "Lưu lại";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labTitle.Location = new System.Drawing.Point(15, 10);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(165, 30);
            this.labTitle.TabIndex = 18;
            this.labTitle.Text = "Cập nhật lịch thi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 30);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "    Cập nhật lịch thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::OBM.App.Properties.Resources.multiply_filled_gray_24px;
            this.btnExit.Location = new System.Drawing.Point(355, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.ContainerControl = this;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.label2;
            // 
            // UpdateSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(402, 338);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateSchedule";
            this.Load += new System.EventHandler(this.UpdateSchedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labTitle;
        private Common.DragControl dragControl1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}