using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBM.App.Views
{
    public partial class ucRowSchedule : UserControl
    {
        public string Subject
        {
            get { return this.labSubject.Text; }
            set { this.labSubject.Text = value; }
        }

        public string DateTime
        {
            get { return this.labDateTime.Text; }
            set { this.labDateTime.Text = value; }
        }

        public string Room
        {
            get { return this.labRoom.Text; }
            set { this.labRoom.Text = value; }
        }
        public ucRowSchedule()
        {
            InitializeComponent();
        }
    }
}
