using KutuphaneOtomasyonu.Class;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_AdminAdd : Form
    {
        public frm_AdminAdd()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        private string id = default;
        private void Clear()
        {
            if (DialogResult.Yes == MessageBox.Show("METİN KUTULARINI TEMİZLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "TEMİZLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = null;
                }
                id = null;
                Txt_UserName.Focus();
            }
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Add()
        {
            if (LoginAdmin.Control(Txt_UserName, Txt_Password, Txt_Email, null))
            {
                if (MessageBox.Show("YENİ ADMİN EKLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "EKLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GeneralCrud.IDU("insert into Tbl_Login (User,Password,E_Mail) values ('" + Txt_UserName.Text + "','" + Encription.Enc(Txt_Password.Text) + "','" + Txt_Email.Text + "')"))
                    {
                        MessageBox.Show("EKLEME İŞLEMİ BAŞARILI !!", "EKLEME İŞLEMİ", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        gridControl1.DataSource = GeneralCrud.List("select ID,User as 'KULLANICI_ADI',E_Mail AS 'E_MAIL',Password as 'SIFRE' from Tbl_Login");
                    }
                    else
                        MessageBox.Show("EKLEME İŞLEMİ BAŞARISIZ !!", "DATABASE İŞLEMİ", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateAdmin()
        {
            if (string.IsNullOrEmpty(id))
                MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ ADMİNİ LİSTEDEN SEÇİNİZ !!", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (LoginAdmin.Control(Txt_UserName, Txt_Password, Txt_Email, id))
                {
                    if (MessageBox.Show("ADMİN GÜNCELLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (id == LoginAdmin.ID)
                        {
                            if (MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ ADMİN KENDİ HESABINIZDIR EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (GeneralCrud.IDU("update Tbl_Login set User='" + Txt_UserName.Text + "',Password='" + Encription.Enc(Txt_Password.Text) + "',E_Mail='" + Txt_Email.Text + "' where ID=" + id + ""))
                                {
                                    MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARILI GÜNCELLEMENİN ONAYLANMASI İÇİN PROGRAMA TEKRARDAN GİRİŞ YAPINIZ !!", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    Application.Exit();
                                }
                                else
                                    MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARISIZ !!", "DATABASE İŞLEMİ", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (GeneralCrud.IDU("update Tbl_Login set User='" + Txt_UserName.Text + "',Password='" + Encription.Enc(Txt_Password.Text) + "',E_Mail='" + Txt_Email.Text + "' where ID=" + id + ""))
                            {
                                MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARILI !!", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                Clear();
                                id = null;
                                gridControl1.DataSource = GeneralCrud.List("select ID,User as 'KULLANICI_ADI',E_Mail AS 'E_MAIL',Password as 'SIFRE' from Tbl_Login");
                            }
                            else
                                MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARISIZ !!", "DATABASE İŞLEMİ", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void DeleteAdmin()
        {
            if (string.IsNullOrEmpty(id))
                MessageBox.Show("SİLMEK İSTEDİĞİNİZ ADMİNİ LİSTEDEN SEÇİNİZ !!", "SİLME İŞLEMİ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                if (MessageBox.Show("SEÇİLİ KAYDI SİLMEK İSTEDİĞİNZDEN EMİN MİSİNİZ ?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (id == LoginAdmin.ID)
                    {
                        if (MessageBox.Show("SİLMEK İSTEDİĞİNİZ ADMİN KENDİ HESABINIZDIR EMİN MİSİNİZ ?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (LoginAdmin.Password == Interaction.InputBox("HESABINIZ SİLİNEBİLMESİ İÇİN GİRİŞ ŞİFRENİZİN GİRMESİ GEREKMEKTEDİR EMİN MİSİNİZ ?", "SİLME İŞLEMİ", null))
                            {
                                if (GeneralCrud.IDU("delete from Tbl_Login where ID=" + id + ""))
                                {
                                    MessageBox.Show("ADMİN SİLME İŞLEMİ BAŞARILI GÜNCELLEME ONAYLANMASI İÇİN PROGRAMA TEKRARDAN GİRİŞ YAPINIZ !!", "BAŞARILI", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    Application.Exit();
                                }
                                else
                                    MessageBox.Show("ADMİN SİLME İŞLEMİ BAŞARISIZ !!", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                Interaction.MsgBox("SİLME İŞLEMİ HATALI KAYIT SİLİNEMEDİ !!", MsgBoxStyle.Critical, "HATALI");
                        }
                    }
                    else
                    {
                        if (GeneralCrud.IDU("delete from Tbl_Login where ID=" + id + ""))
                        {
                            MessageBox.Show("ADMİN SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Clear();
                            id = null;
                            gridControl1.DataSource = GeneralCrud.List("select ID,User as 'KULLANICI_ADI',E_Mail AS 'E_MAIL',Password as 'SIFRE' from Tbl_Login");
                        }
                        else
                            MessageBox.Show("ADMİN SİLME İŞLEMİ BAŞARISIZ !!", "BAŞARISIZ", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void frm_AdminAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F3)
                Clear();
            else if (e.KeyCode == Keys.F2)
                Add();
            else if (e.KeyCode == Keys.F5)
                UpdateAdmin();
        }
        private void frm_AdminAdd_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GeneralCrud.List("select ID,User as 'KULLANICI_ADI',E_Mail AS 'E_MAIL',Password as 'SIFRE' from Tbl_Login");
            gridView1.Columns["SIFRE"].Visible = false;
        }
        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAdmin();
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateAdmin();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void şifreyiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char? nulchar = null;
            Txt_Password.PasswordChar = Convert.ToChar(nulchar);
        }
        private void şifreyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_Password.PasswordChar = '*';
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "AdminListesi.xlsx");
        }
        private void pDFAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "AdminListesi.pdf");
        }
        private void htmlAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "AdminListesi.html");
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            Txt_Password.PasswordChar = '*';
            try
            {
                id = gridView1.GetFocusedRowCellValue("ID").ToString();
                Txt_UserName.Text = gridView1.GetFocusedRowCellValue("KULLANICI_ADI").ToString();
                Txt_Email.Text = gridView1.GetFocusedRowCellValue("E_MAIL").ToString();
                Txt_Password.Text = Encription.Desc(gridView1.GetFocusedRowCellValue("SIFRE").ToString());
            }
            catch (Exception)
            {

            }
        }
    }
}