using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class MailSend
    {
        private static readonly char[] turkishControl = new char[] { 'ç', 'Ç', 'ö', 'Ö', 'İ', 'ş', 'Ş', 'ü', 'Ü', 'ğ', 'Ğ', 'ı' };
        private static ArrayList lstInfo = new();
        internal static string Code = default;
        internal static bool Status = default;

        internal static void ReadMail()
        {
            string file = $"{Application.StartupPath}\\Import\\Mail.txt";
            try
            {
                using (FileStream fs = new(file, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new(fs))
                    {
                        while (!sr.EndOfStream)
                            lstInfo.Add(Encription.Desc(sr.ReadLine()));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("HATALI MAİL BİLGİLERİ OKUMA İŞLEMİ", e.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        internal static string MailSendPassword(string _fromMail, string _subject)
        {
            Random rd = new();
            string _Code = rd.Next(100000, 1000000).ToString();
            SmtpClient cl = new();
            MailMessage ms = new();
            cl.EnableSsl = true;
            ms.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            ms.Priority = MailPriority.High;
            cl.DeliveryMethod = SmtpDeliveryMethod.Network;
            cl.Credentials = new NetworkCredential(lstInfo[0].ToString(), lstInfo[1].ToString());
            ms.From = new MailAddress(lstInfo[0].ToString());
            cl.Host = lstInfo[2].ToString();
            cl.Port = int.Parse(lstInfo[3].ToString());
            ms.Subject = _subject;
            ms.Body = $"GÜVENLİK KODUNUZ= {_Code}";
            try
            {
                ms.To.Add(_fromMail);
                cl.Send(ms);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "MAİL GÖNDERME İŞLEMİ BAŞARISIZ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
            MessageBox.Show("MAİL GÖNDERME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return _Code;
        }

        internal static bool Control(TextBox Email, TextBox password, TextBox host, NumericUpDown port)
        {
            #region MAİLCONTROL

            if (string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("E-MAİL KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Email.Focus();
                return false;
            }
            if (!Email.Text.Contains("@"))
            {
                MessageBox.Show("MAİL FORMATI GEÇERSİZ TEKRAR GİRİŞİ YAPINIZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Email.Focus();
                Email.Text = string.Empty;
                return false;
            }
            if (Email.Text.Length < 8)
            {
                MessageBox.Show("E-MAİL KUTUSU GİRİLEN MAİL 8 KARAKTERDEN KISA OLAMAZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email.Focus();
                return false;
            }
            for (byte i = 0; i < turkishControl.Length; i++)
            {
                if (Email.Text.Contains(turkishControl[i]))
                {
                    MessageBox.Show("MAİL METİN KUTUSUNDA TÜRKÇE KARAKTER OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Text = string.Empty;
                    Email.Focus();
                    return false;
                }
            }

            #endregion MAİLCONTROL

            #region PASSWORD CONTROL

            if (string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("ŞİFRE METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                password.Focus();
                return false;
            }
            if (password.Text.Length < 3)
            {
                MessageBox.Show("ŞİFRE METİN 3 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                password.Focus();
                return false;
            }

            #endregion PASSWORD CONTROL

            #region HOSTCONTROL

            if (string.IsNullOrEmpty(host.Text))
            {
                MessageBox.Show("HOST METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                host.Focus();
                return false;
            }
            if (host.Text.Length < 5)
            {
                MessageBox.Show("HOST METİN KUTUSU 5 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                host.Focus();
                return false;
            }

            #endregion HOSTCONTROL

            return true;
        }
    }
}