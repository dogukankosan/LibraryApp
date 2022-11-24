using KutuphaneOtomasyonu.Class;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMember mbr = new();
            mbr.E_Mail = Interaction.InputBox("MAİL ADRESİNİZİ YAZINIZ", "SİSTEMDE KAYITLI MAİL ADRESİ", null);
            if (string.IsNullOrEmpty(mbr.E_Mail))
            {
                Interaction.MsgBox("MAİL ADRESİ ALANI BOŞ GEÇİLEMEZ !!", MsgBoxStyle.Critical, "HATALI DEĞER");
                return;
            }
            mbr.Password = LoginMember.DbValues(mbr.E_Mail);
            if (string.IsNullOrEmpty(mbr.Password))
            {
                MessageBox.Show("GİRİLMİŞ OLAN E-MAİL SİSTEMDE KAYITLI DEĞİL !!", "BAŞARISIZ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            MailSend.ReadMail();
            MailSend.Code = MailSend.MailSendPassword(mbr.E_Mail, "ŞİFREMİ UNUTTUM");
            if (string.IsNullOrEmpty(MailSend.Code))
                return;
            MailSend.Status = MailSend.Code == Interaction.InputBox("MAİLİNİZE GELEN GÜVENLİK KODUNUZU GİRİNİZ= ", "GÜVENLİK KODU", null)
                  ? true
                  : false;
            if (MailSend.Status)
            {
                MessageBox.Show($"{mbr.Password} ŞİFRENİZ ŞİFRE METİN KUTUSUNA YAPIŞTIRILMIŞTIR !!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Password.Text = mbr.Password;
                Txt_Mail.Focus();
            }
            else
                MessageBox.Show("GÜVENLİK KODU HATALI GİRİLDİ TEKRARDAN GÜVENLİK KODU ALINIZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Mail.Text) && !string.IsNullOrEmpty(Txt_Password.Text))
            {
                LoginMember mnMember = new();
                mnMember.E_Mail = Txt_Mail.Text;
                mnMember.Password = Txt_Password.Text;
                if (LoginMember.DbValuesBool(mnMember.E_Mail, mnMember.Password))
                {
                    MessageBox.Show("GİRİŞ İŞLEMİ BAŞARILI HOŞGELDİNİZ !!", "BAŞARILI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Home fr = new();
                    fr.Show();
                    Hide();
                }
                else
                    MessageBox.Show("GİRİŞ İŞLEMİ BAŞARISIZ !!", "BAŞARISIZ", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("E-MAİL VEYA ŞİFRE DEĞERİ BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            Txt_Password.Text = null;
            Txt_Mail.Text = null;
            Txt_Mail.Focus();
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginAdmin.UserName = Interaction.InputBox("KULLANICI ADINIZI GİRİNİZ= ", "KULLANICI ADI", null);
            if (string.IsNullOrEmpty(LoginAdmin.UserName))
            {
                Interaction.MsgBox("KULLANICI ADI BOŞ GEÇİLEMEZ !!", MsgBoxStyle.Critical, "BOŞ DEĞER");
                return;
            }
            LoginAdmin.Password = Interaction.InputBox("ŞİFRENİZİ GİRİNİZ= ", "ŞİFRE", null);
            if (string.IsNullOrEmpty(LoginAdmin.Password))
            {
                Interaction.MsgBox("ŞİFRE BOŞ GEÇİLEMEZ !!", MsgBoxStyle.Critical, "BOŞ DEĞER");
                return;
            }
            if (LoginAdmin.DbValues())
            {
                MessageBox.Show("ADMİN GİRİŞ İŞLEMİ BAŞARILI HOŞGELDİNİZ !!", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Home fr = new();
                fr.Show();
                Hide();
            }
            else
                MessageBox.Show("ADMİN GİRİŞ İŞLEMİ BAŞARISIZ !!", "BAŞARISIZ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            Txt_Mail.Focus();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_MemberAdd fr = new();
            fr.ShowDialog();
        }
        private void şifreyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char? nullchar = null;
            Txt_Password.PasswordChar = Convert.ToChar(nullchar);
        }
    }
}