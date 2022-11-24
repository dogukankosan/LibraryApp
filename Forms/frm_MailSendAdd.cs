using KutuphaneOtomasyonu.Class;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_MailSendAdd : Form
    {
        public frm_MailSendAdd()
        {
            InitializeComponent();
        }
        private void List()
        {
            ArrayList list = new();
            StreamReader writer = new($"{Application.StartupPath}\\Import\\Mail.txt");
            string satir = string.Empty;
            while (true)
            {
                satir = writer.ReadLine();
                if (satir == null)
                    break;
                list.Add(satir);
            }
            writer.Close();
            Txt_Email.Text = Encription.Desc(list[0].ToString());
            Txt_Password.Text = Encription.Desc(list[1].ToString());
            Txt_Host.Text = Encription.Desc(list[2].ToString());
            numericUpDown1.Value = ushort.Parse(Encription.Desc((list[3].ToString())));
        }
        private void UpdateMail()
        {
            if (MailSend.Control(Txt_Email, Txt_Password, Txt_Host, numericUpDown1))
            {
                StreamWriter writer = new($"{Application.StartupPath}\\Import\\Mail.txt");
                writer.WriteLine(Encription.Enc(Txt_Email.Text));
                writer.WriteLine(Encription.Enc(Txt_Password.Text));
                writer.WriteLine(Encription.Enc(Txt_Host.Text));
                writer.WriteLine(Encription.Enc(numericUpDown1.Text));
                writer.Close();
                MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void sifreyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char? nullchar = null;
            Txt_Password.PasswordChar = Convert.ToChar(nullchar);
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateMail();
        }
        private void frm_MailSendAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                UpdateMail();
        }
        private void frm_MailSendAdd_Load(object sender, EventArgs e)
        {
            List();
        }
        private void şifreyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_Password.PasswordChar = '*';
        }
    }
}