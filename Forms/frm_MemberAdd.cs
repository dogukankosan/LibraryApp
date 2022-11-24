using KutuphaneOtomasyonu.Class;
using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_MemberAdd : Form
    {
        public frm_MemberAdd()
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
                Rch_Adress.Text = null;
                Msk_Phone.Text = null;
                Cmb_Gender.Text = null;
                Cmb_Gender.SelectedText = null;
                pictureEdit1.Image = null;
                Dt_Birthday.Text = Dt_Birthday.MaxDate.ToString();
                Txt_TC.Focus();
            }
        }
        private void Add()
        {
            if (CRUDMember.Control(Txt_TC, Txt_NameSurname, Cmb_Gender, Msk_Phone, Txt_Email, Txt_Password, Rch_Adress, null))
            {
                if (MessageBox.Show("ÜYE EKLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "EKLEME İŞLEMİ", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GeneralCrud.IDU("insert into Tbl_Member (TC,NameSurname,Birthday,Gender,Phone,Adress,E_Mail,Picture,Password) values ('" + Txt_TC.Text.Trim() + "','" + Txt_NameSurname.Text.Trim() + "','" + Dt_Birthday.Text + "','" + Cmb_Gender.Text + "','" + Msk_Phone.Text + "','" + Rch_Adress.Text.Trim() + "','" + Txt_Email.Text.Trim() + "','" + ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "','" + Encription.Enc(Txt_Password.Text) + "')"))
                    {
                        MessageBox.Show("ÜYE EKLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        Txt_TC.Focus();
                    }
                }
            }
        }
        private void frm_MemberAdd_Load(object sender, EventArgs e)
        {
        }
        private void frm_MemberAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.KeyCode == Keys.F3)
                Clear();
            else if (e.KeyCode == Keys.F2)
                Add();
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Txt_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Txt_NameSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void sifreyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char? charnull = null;
            Txt_Password.PasswordChar = Convert.ToChar(charnull);
        }
        private void şifreyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_Password.PasswordChar = '*';
        }
    }
}