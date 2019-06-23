using OBM.App.Common;

namespace OBM.App.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.labDisplayName = new System.Windows.Forms.Label();
            this.pbAccountImage = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnSubjectAndRoom = new System.Windows.Forms.Button();
            this.btnFinalTest = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.dragControl1 = new OBM.App.Common.DragControl();
            this.dragControl2 = new OBM.App.Common.DragControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labDisplayName);
            this.panel1.Controls.Add(this.pbAccountImage);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 30);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(45, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phần mềm quản lý điểm chuẩn đầu ra";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::OBM.App.Properties.Resources.left_filled_24px;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 30);
            this.btnBack.TabIndex = 17;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // labDisplayName
            // 
            this.labDisplayName.Dock = System.Windows.Forms.DockStyle.Right;
            this.labDisplayName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDisplayName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labDisplayName.Location = new System.Drawing.Point(885, 0);
            this.labDisplayName.Name = "labDisplayName";
            this.labDisplayName.Size = new System.Drawing.Size(180, 30);
            this.labDisplayName.TabIndex = 16;
            this.labDisplayName.Text = "Tên tài khoản";
            this.labDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbAccountImage
            // 
            this.pbAccountImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAccountImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbAccountImage.ErrorImage = null;
            this.pbAccountImage.Image = global::OBM.App.Properties.Resources.user_male_circle_24px;
            this.pbAccountImage.InitialImage = null;
            this.pbAccountImage.Location = new System.Drawing.Point(1065, 0);
            this.pbAccountImage.Name = "pbAccountImage";
            this.pbAccountImage.Size = new System.Drawing.Size(45, 30);
            this.pbAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAccountImage.TabIndex = 15;
            this.pbAccountImage.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::OBM.App.Properties.Resources.minus_math_filled_24px;
            this.btnMinimize.Location = new System.Drawing.Point(1110, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(44)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::OBM.App.Properties.Resources.multiply_filled_24px;
            this.btnExit.Location = new System.Drawing.Point(1155, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 1);
            this.panel4.TabIndex = 7;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(192)))), ((int)(((byte)(45)))));
            this.pnlLeft.Controls.Add(this.panel8);
            this.pnlLeft.Controls.Add(this.panel7);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 31);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(230, 649);
            this.pnlLeft.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pnlMenu);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 120);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(230, 529);
            this.panel8.TabIndex = 7;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnAccount);
            this.pnlMenu.Controls.Add(this.btnScore);
            this.pnlMenu.Controls.Add(this.btnSubjectAndRoom);
            this.pnlMenu.Controls.Add(this.btnFinalTest);
            this.pnlMenu.Controls.Add(this.btnStudent);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(6, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(224, 529);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnAccount.Image = global::OBM.App.Properties.Resources.user_male_circle_24px;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 172);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(224, 42);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "   Tài khoản";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // btnScore
            // 
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnScore.Image = global::OBM.App.Properties.Resources.user_male_circle_24px;
            this.btnScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.Location = new System.Drawing.Point(0, 129);
            this.btnScore.Margin = new System.Windows.Forms.Padding(0);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(224, 42);
            this.btnScore.TabIndex = 2;
            this.btnScore.Text = "   Kết quả thi";
            this.btnScore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.BtnScore_Click);
            // 
            // btnSubjectAndRoom
            // 
            this.btnSubjectAndRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubjectAndRoom.FlatAppearance.BorderSize = 0;
            this.btnSubjectAndRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjectAndRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectAndRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnSubjectAndRoom.Image = global::OBM.App.Properties.Resources.user_male_circle_24px;
            this.btnSubjectAndRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjectAndRoom.Location = new System.Drawing.Point(0, 86);
            this.btnSubjectAndRoom.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubjectAndRoom.Name = "btnSubjectAndRoom";
            this.btnSubjectAndRoom.Size = new System.Drawing.Size(224, 42);
            this.btnSubjectAndRoom.TabIndex = 2;
            this.btnSubjectAndRoom.Text = "   Môn thi - Phòng thi";
            this.btnSubjectAndRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubjectAndRoom.UseVisualStyleBackColor = true;
            // 
            // btnFinalTest
            // 
            this.btnFinalTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalTest.FlatAppearance.BorderSize = 0;
            this.btnFinalTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalTest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnFinalTest.Image = global::OBM.App.Properties.Resources.user_male_circle_24px;
            this.btnFinalTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalTest.Location = new System.Drawing.Point(0, 43);
            this.btnFinalTest.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinalTest.Name = "btnFinalTest";
            this.btnFinalTest.Size = new System.Drawing.Size(224, 42);
            this.btnFinalTest.TabIndex = 2;
            this.btnFinalTest.Text = "   Quản lý kỳ thi";
            this.btnFinalTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalTest.UseVisualStyleBackColor = true;
            this.btnFinalTest.Click += new System.EventHandler(this.btnFinalTest_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnStudent.Image = global::OBM.App.Properties.Resources.user_male_circle_24px;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 0);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(224, 42);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "   Quản lý sinh viên";
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pnlSide);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(6, 529);
            this.panel9.TabIndex = 0;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(6, 42);
            this.pnlSide.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 120);
            this.panel7.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::OBM.App.Properties.Resources.logo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(47, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(78, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Sky";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(230, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 649);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1190, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 649);
            this.panel3.TabIndex = 12;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(240, 31);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(950, 649);
            this.pnlContainer.TabIndex = 13;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.label2;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Output Benchmark Management";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAccountImage)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DragControl dragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbAccountImage;
        private System.Windows.Forms.Label labDisplayName;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnFinalTest;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubjectAndRoom;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnScore;
        private DragControl dragControl2;
    }
}