using System.Windows.Forms;

namespace OBM.App.Views
{
    public partial class ucSchedule : UserControl
    {
        public string Date
        {
            get { return this.labDate.Text; }
            set { this.labDate.Text = value; }
        }

        public string Subject
        {
            get { return this.labSubject.Text; }
            set { this.labSubject.Text = value; }
        }

        public string Time
        {
            get { return this.labTime.Text; }
            set { this.labTime.Text = value; }
        }

        public string Room
        {
            get { return this.labRoom.Text; }
            set { this.labRoom.Text = value; }
        }

        public ucSchedule()
        {
            InitializeComponent();
        }
    }
}