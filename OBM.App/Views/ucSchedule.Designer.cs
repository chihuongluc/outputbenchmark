namespace OBM.App.Views
{
    partial class ucSchedule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labRoom = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.labSubject = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labDate = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 139);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(170, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 139);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labRoom);
            this.panel5.Controls.Add(this.labTime);
            this.panel5.Controls.Add(this.labSubject);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.labDate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 139);
            this.panel5.TabIndex = 2;
            // 
            // labRoom
            // 
            this.labRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labRoom.Location = new System.Drawing.Point(0, 107);
            this.labRoom.Name = "labRoom";
            this.labRoom.Size = new System.Drawing.Size(160, 32);
            this.labRoom.TabIndex = 4;
            this.labRoom.Text = "Room";
            this.labRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTime
            // 
            this.labTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTime.Location = new System.Drawing.Point(0, 75);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(160, 32);
            this.labTime.TabIndex = 3;
            this.labTime.Text = "Time";
            this.labTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labSubject
            // 
            this.labSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.labSubject.Location = new System.Drawing.Point(0, 43);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(160, 32);
            this.labSubject.TabIndex = 2;
            this.labSubject.Text = "Subject";
            this.labSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 3);
            this.panel6.TabIndex = 1;
            // 
            // labDate
            // 
            this.labDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.Location = new System.Drawing.Point(0, 0);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(160, 40);
            this.labDate.TabIndex = 0;
            this.labDate.Text = "Date";
            this.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.Name = "ucSchedule";
            this.Size = new System.Drawing.Size(180, 159);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labRoom;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labDate;
    }
}
