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
    public partial class ucSchedules : UserControl
    {
        private int ngayIndex;
        public ucSchedules()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            LoadHour(cbHour);
            LoadMinute(cbMinute);
            LoadYear(cbYear);
            LoadMonth(cbMonth);
            LoadDay(31);
            cbDay.SelectedIndex = 0;
        }

        private void LoadHour(ComboBox cb)
        {
            cb.Items.Add("Giờ");
            for (int i = 7; i <= 17; i++)
            {
                cb.Text = i.ToString();
                cb.Items.Add(string.Format("{0:00}", i));
            }
            cb.SelectedIndex = 0;
        }

        private void LoadMinute(ComboBox cb)
        {
            cb.Items.Add("Phút");
            for (int i = 0; i < 60; i = i + 15)
            {
                cb.Text = i.ToString();
                cb.Items.Add(string.Format("{0:00}", i));
            }
            cb.SelectedIndex = 0;
        }

        private void LoadYear(ComboBox cb)
        {
            int minYear = DateTime.Now.Year;
            int maxYear = minYear + 1;

            cb.Items.Add("Năm");
            for (int i = minYear; i <= maxYear; i++)
            {
                cb.Text = i.ToString();
                cb.Items.Add(i);
            }
            cb.SelectedIndex = 0;
        }

        private void LoadMonth(ComboBox cb)
        {
            cb.Items.Add("Tháng");
            for (int i = 1; i <= 12; i++)
            {
                cb.Text = i.ToString();
                cb.Items.Add(i);
            }
            cb.SelectedIndex = 0;
        }

        private void LoadDay(int ngayToiDa)
        {
            cbDay.Items.Clear();
            cbDay.Items.Add("Ngày");
            for (int i = 1; i <= ngayToiDa; i++)
            {
                cbDay.Text = i.ToString();
                cbDay.Items.Add(i);
            }
        }

        private int LayNgayToiDa(int thang)
        {
            int ngayToiDa = 0;

            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ngayToiDa = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ngayToiDa = 30;
                    break;
                case 2:
                    if (cbYear.SelectedIndex > 0 && ((Int32.Parse(cbYear.Text) % 4 == 0 && Int32.Parse(cbYear.Text) % 100 != 0) || Int32.Parse(cbYear.Text) % 400 == 0))
                        ngayToiDa = 29;
                    else
                        ngayToiDa = 28;
                    break;
                default:
                    break;
            }
            return ngayToiDa;
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex < 1)
                return;

            if (cbMonth.Text != "")
            {
                int ngayMax = LayNgayToiDa(cbMonth.SelectedIndex);
                LoadDay(ngayMax);
                if (ngayIndex <= ngayMax)
                    cbDay.SelectedIndex = ngayIndex;
                else
                    cbDay.SelectedIndex = 0;
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex < 1)
                return;

            if (cbYear.Text != "")
            {
                int ngayMax = LayNgayToiDa((sender as ComboBox).SelectedIndex);
                LoadDay(ngayMax);
                if (ngayIndex <= ngayMax)
                    cbDay.SelectedIndex = ngayIndex;
                else
                    cbDay.SelectedIndex = 0;
            }
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex < 1)
                return;

            ngayIndex = (sender as ComboBox).SelectedIndex;
        }
    }
}
