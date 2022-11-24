using KutuphaneOtomasyonu.Class;
using Microsoft.VisualBasic;
using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_MemberList : Form
    {
        private string id = null;
        private readonly FolderBrowserDialog fr = new();
        public frm_MemberList()
        {
            InitializeComponent();
        }
        private void Delete()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (MessageBox.Show("ÜYEYİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ SİLERSENİZ ÜYEYE BAĞLI VERİLMİŞ TÜM EMANET KİTAPLAR SİLİNECEKTİR VE KAYBOLACAKTIR EMİN MİSİNİZ?", "SİLME İŞLEMİ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (LoginAdmin.Password == Interaction.InputBox("SİLMEK İÇİN KAYDI GİRİŞ ŞİFRENİZİ YAZMANIZ GEREKİYOR !!", "SİLME İŞLEMİ", null))
                    {
                        if (GeneralCrud.IDU("delete from Tbl_Member where ID=" + id + ""))
                        {
                            MessageBox.Show("ÜYE SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Clear();
                            Txt_TC.Focus();
                            id = null;
                            gridControl1.DataSource = GeneralCrud.List(
                                "SELECT id,\r\n       tc,\r\n       namesurname    AS 'AD_SOYAD',\r\n       birthday       AS 'DOGUM_TARIHI',\r\n       gender         AS 'CINSIYET',\r\n       phone          AS 'TELEFON',\r\n       adress         AS 'ADRES',\r\n       e_mail         AS 'E_MAIL',\r\n       picture        AS 'RESIM',\r\n       password       AS 'SIFRE',\r\n       readbookscount AS 'OKUNAN_KITAP_SAYISI',\r\n\t   Balance as 'BORCU'\r\nFROM   tbl_member ");
                            id = null;
                        }
                    }
                    else
                        Interaction.MsgBox("SİLME İŞLEMİ BAŞARISIZ ÜYE SİLİNEMEDİ !!", MsgBoxStyle.Critical,
                            "SİLME İŞLEMİ");
                }
            }
            else
                MessageBox.Show("SİLMEK İSTEDİĞİNİZ KAYDI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void UpdateMember()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (CRUDMember.Control(Txt_TC, Txt_NameSurname, Cmb_Gender, Msk_Phone, Txt_Email, Txt_Password, Rch_Adress, id))
                {
                    if (MessageBox.Show("ÜYEYİ GÜNCELLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (GeneralCrud.IDU("update Tbl_Member set TC='" + Txt_TC.Text.Trim() + "',NameSurname='" + Txt_NameSurname.Text.Trim() + "',Birthday='" + Dt_Birthday.Text + "',Gender='" + Cmb_Gender.Text + "',Phone='" + Msk_Phone.Text + "',Adress='" + Rch_Adress.Text.Trim() + "',E_Mail='" + Txt_Email.Text.Trim() + "',Picture='" + ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "',Password='" + Encription.Enc(Txt_Password.Text) + "' where ID=" + id + ""))
                        {
                            MessageBox.Show("ÜYE GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Clear();
                            Txt_TC.Focus();
                            id = null;
                            gridControl1.DataSource = GeneralCrud.List(
                                "SELECT id,\r\n       tc,\r\n       namesurname    AS 'AD_SOYAD',\r\n       birthday       AS 'DOGUM_TARIHI',\r\n       gender         AS 'CINSIYET',\r\n       phone          AS 'TELEFON',\r\n       adress         AS 'ADRES',\r\n       e_mail         AS 'E_MAIL',\r\n       picture        AS 'RESIM',\r\n       password       AS 'SIFRE',\r\n       readbookscount AS 'OKUNAN_KITAP_SAYISI',\r\n\t   Balance as 'BORCU'\r\nFROM   tbl_member ");
                        }
                    }
                }
            }
            else
                MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ KAYDI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                id = null;
                Rch_Adress.Text = null;
                Msk_Phone.Text = null;
                Cmb_Gender.Text = null;
                Cmb_Gender.SelectedText = null;
                pictureEdit1.Image = null;
                Dt_Birthday.Text = Dt_Birthday.MaxDate.ToString();
                Lbl_Punishment.Text = "0";
                Txt_TC.Focus();
            }
        }
        private void frm_MemberList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GeneralCrud.List(
                "SELECT id,\r\n       tc,\r\n       namesurname    AS 'AD_SOYAD',\r\n       birthday       AS 'DOGUM_TARIHI',\r\n       gender         AS 'CINSIYET',\r\n       phone          AS 'TELEFON',\r\n       adress         AS 'ADRES',\r\n       e_mail         AS 'E_MAIL',\r\n       picture        AS 'RESIM',\r\n       password       AS 'SIFRE',\r\n       readbookscount AS 'OKUNAN_KITAP_SAYISI',\r\n\t   Balance as 'BORCU'\r\nFROM   tbl_member ");
            gridView1.Columns["RESIM"].Visible = false;
            gridView1.Columns["SIFRE"].Visible = false;
        }
        private void frm_MemberList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                UpdateMember();
            else if (e.KeyCode == Keys.F3)
                Clear();
            else if (e.KeyCode == Keys.F5)
                Delete();
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
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateMember();
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void sifreyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char? nullchar = null;
            Txt_Password.PasswordChar = Convert.ToChar(nullchar);
        }
        private void şifreyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_Password.PasswordChar = '*';
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UyeListesi.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UyeListesi.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UyeListesi.html");
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Txt_Password.PasswordChar = '*';
            try
            {
                id = gridView1.GetFocusedRowCellValue("ID").ToString();
                Txt_TC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
                Txt_NameSurname.Text = gridView1.GetFocusedRowCellValue("AD_SOYAD").ToString();
                Dt_Birthday.Text = gridView1.GetFocusedRowCellValue("DOGUM_TARIHI").ToString();
                Cmb_Gender.Text = gridView1.GetFocusedRowCellValue("CINSIYET").ToString();
                Msk_Phone.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
                Txt_Password.Text = Encription.Desc(gridView1.GetFocusedRowCellValue("SIFRE").ToString());
                Txt_Email.Text = gridView1.GetFocusedRowCellValue("E_MAIL").ToString();
                Rch_Adress.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
                pictureEdit1.Image = ImageConvert.Base64ToImage(gridView1.GetFocusedRowCellValue("RESIM").ToString());
                Lbl_Punishment.Text = gridView1.GetFocusedRowCellValue("BORCU").ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}