using KutuphaneOtomasyonu.Class;
using System;
using System.Collections;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_MemberUpdate : Form
    {
        public frm_MemberUpdate()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            if (MessageBox.Show("METİN KUTULARIN İÇERİĞİNİN TAMAMI TEMİZLENECEKTİR EMİN MİSİNİZ ?", "TEMİZLEME",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = string.Empty;
                }
                Cmb_Gender.Text = null;
                Cmb_Gender.SelectedText = null;
                pictureEdit1.Image = null;
                Dt_Birthday.Text = DateTime.Today.ToString();
                Txt_TC.Focus();
                Rch_Adress.Text = null;
                Msk_Phone.Text = null;
            }
        }
        private void MemberUpdate()
        {
            if (CRUDMember.Control(Txt_TC, Txt_NameSurname, Cmb_Gender, Msk_Phone, Txt_Email, Txt_Password, Rch_Adress, LoginMember.ID))
            {
                if (MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GeneralCrud.IDU("update Tbl_Member set TC='" + Txt_TC.Text.Trim() + "',NameSurname='" + Txt_NameSurname.Text.Trim() + "',Birthday='" + Dt_Birthday.Text + "',Gender='" + Cmb_Gender.Text + "',Phone='" + Msk_Phone.Text + "',Adress='" + Rch_Adress.Text.Trim() + "',E_Mail='" + Txt_Email.Text.Trim() + "',Picture='" + ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "',Password='" + Encription.Enc(Txt_Password.Text) + "' where ID=" + LoginMember.ID + ""))
                    {
                        MessageBox.Show("ÜYE GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
        }
        private void List()
        {
            ArrayList lst = GeneralCrud.TextBoxList(
                "select TC,NameSurname,Birthday,Gender,Phone,Adress,E_Mail,Picture,Password from Tbl_Member where ID=" +
                LoginMember.ID + "");
            Txt_TC.Text = lst[0].ToString();
            Txt_NameSurname.Text = lst[1].ToString();
            Dt_Birthday.Text = lst[2].ToString();
            Cmb_Gender.Text = lst[3].ToString();
            Msk_Phone.Text = lst[4].ToString();
            Rch_Adress.Text = lst[5].ToString();
            Txt_Email.Text = lst[6].ToString();
            pictureEdit1.Image = ImageConvert.Base64ToImage(lst[7].ToString());
            Txt_Password.Text = Encription.Desc(lst[8].ToString());
        }
        private void frm_MemberUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F3)
                Clear();
            else if (e.KeyCode == Keys.F2)
                MemberUpdate();
        }
        private void frm_MemberUpdate_Load(object sender, System.EventArgs e)
        {
            List();
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void şifreyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_Password.PasswordChar = '*';
        }
        private void sifreyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char? charnull = null;
            Txt_Password.PasswordChar = Convert.ToChar(charnull);
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            MemberUpdate();
        }
    }
}