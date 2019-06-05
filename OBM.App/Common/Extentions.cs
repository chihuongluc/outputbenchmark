using SimpleInjector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBM.App.Common
{
    public static class Extentions
    {
        public static Container container;
        public static void AddFormIntoPanel(object frm, Panel pnl)
        {
            if (pnl.Controls.Count > 0)
                pnl.Controls.RemoveAt(0);
            Form f = frm as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnl.Controls.Add(f);
            pnl.Tag = f;
            f.Show();
        }

        public static void ShowPassword(CheckBox chk, TextBox txb)
        {
            if (chk.Checked)
                txb.UseSystemPasswordChar = false;
            else
                txb.UseSystemPasswordChar = true;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Md5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        /// <summary>
        /// Hàm Gửi Email
        /// </summary>
        /// <param name="fromEmail"> Địa chỉ Email gửi thư </param>
        /// <param name="passEmail"> Mật khẩu của địa chỉ email gửi </param>
        /// <param name="toEmail"> Người nhận </param>
        /// <param name="mailSubject"> Tiêu đề mail </param>
        /// <param name="mailMessage"> Nội dung mail </param>
        public static void SendEmail(string fromEmail, string passEmail, string toEmail, string mailSubject, string mailMessage)
        {
            try
            {
                MailMessage mess = new MailMessage(fromEmail, toEmail, mailSubject, mailMessage);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(fromEmail, passEmail);
                client.Send(mess);
            }
            catch (Exception e)
            { e.Message.ToString(); }
        }

        public static void ExportToTextFile(string userName, string password, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine("Phần mềm quản lý Điểm Chuẩn đầu ra BDU.CM");
            sWriter.WriteLine("Thông tin tài khoản của bạn:");
            sWriter.WriteLine("      - Username: " + userName);
            sWriter.WriteLine("      - Password: " + password);
            sWriter.WriteLine("Ngày khởi tạo: " + DateTime.Now);
            sWriter.WriteLine("--------\n");
            sWriter.Close();
            fs.Close();
            //Process.Start(filePath);
        }
    }
}
