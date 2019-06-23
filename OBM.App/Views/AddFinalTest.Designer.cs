namespace OBM.App.Views
{
    partial class AddFinalTest
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
            this.dragControl1 = new OBM.App.Common.DragControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkTHCB = new System.Windows.Forms.CheckBox();
            this.chkTHVP = new System.Windows.Forms.CheckBox();
            this.chkHoaVan = new System.Windows.Forms.CheckBox();
            this.chkToeic = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.label2;
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
            this.label2.Text = "    Thêm kỳ thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 224);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.chkTHCB);
            this.panel3.Controls.Add(this.chkTHVP);
            this.panel3.Controls.Add(this.chkHoaVan);
            this.panel3.Controls.Add(this.chkToeic);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 192);
            this.panel3.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DimGray;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(20, 140);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(360, 32);
            this.btnOK.TabIndex = 35;
            this.btnOK.Text = "Lưu lại";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // chkTHCB
            // 
            this.chkTHCB.AutoSize = true;
            this.chkTHCB.Location = new System.Drawing.Point(205, 90);
            this.chkTHCB.Name = "chkTHCB";
            this.chkTHCB.Size = new System.Drawing.Size(137, 25);
            this.chkTHCB.TabIndex = 19;
            this.chkTHCB.Text = "Tin học căn bản";
            this.chkTHCB.UseVisualStyleBackColor = true;
            // 
            // chkTHVP
            // 
            this.chkTHVP.AutoSize = true;
            this.chkTHVP.Location = new System.Drawing.Point(205, 55);
            this.chkTHVP.Name = "chkTHVP";
            this.chkTHVP.Size = new System.Drawing.Size(157, 25);
            this.chkTHVP.TabIndex = 19;
            this.chkTHVP.Text = "Tin học văn phòng";
            this.chkTHVP.UseVisualStyleBackColor = true;
            // 
            // chkHoaVan
            // 
            this.chkHoaVan.AutoSize = true;
            this.chkHoaVan.Location = new System.Drawing.Point(50, 90);
            this.chkHoaVan.Name = "chkHoaVan";
            this.chkHoaVan.Size = new System.Drawing.Size(86, 25);
            this.chkHoaVan.TabIndex = 19;
            this.chkHoaVan.Text = "Hoa văn";
            this.chkHoaVan.UseVisualStyleBackColor = true;
            // 
            // chkToeic
            // 
            this.chkToeic.AutoSize = true;
            this.chkToeic.Location = new System.Drawing.Point(50, 55);
            this.chkToeic.Name = "chkToeic";
            this.chkToeic.Size = new System.Drawing.Size(63, 25);
            this.chkToeic.TabIndex = 19;
            this.chkToeic.Text = "Toeic";
            this.chkToeic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chọn môn chuẩn đầu ra";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 30);
            this.panel2.TabIndex = 1;
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
            // AddFinalTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(402, 224);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFinalTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFinalTest";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Common.DragControl dragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkTHCB;
        private System.Windows.Forms.CheckBox chkTHVP;
        private System.Windows.Forms.CheckBox chkHoaVan;
        private System.Windows.Forms.CheckBox chkToeic;
        private System.Windows.Forms.Label label1;
    }
}