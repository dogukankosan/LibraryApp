using KutuphaneOtomasyonu.Class;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_BookType : Form
    {
        public frm_BookType()
        {
            InitializeComponent();
        }
        private string id = string.Empty;
        private readonly FolderBrowserDialog fr = new ();
        private void Add()
        {
            if (BookType.ControlType(Txt_TypeBook, null))
            {
                if (MessageBox.Show("KİTAP TÜRÜNÜ KAYIT ETMEK İSTİYOR MUSUNUZ ?", "KAYIT İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GeneralCrud.IDU("insert into Tbl_TypeBook (BookType) values ('" + Txt_TypeBook.Text.Trim() + "')"))
                    {
                        MessageBox.Show("KİTAP TÜRÜ KAYIT İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Txt_TypeBook.Text = null;
                        id = null;
                        Txt_TypeBook.Focus();
                        gridControl1.DataSource = GeneralCrud.List("SELECT ID,BookType as 'KITAP_TURU' FROM Tbl_TypeBook order by BookType");
                    }
                }
            }
        }
        private void UpdateBook()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (BookType.ControlType(Txt_TypeBook, id))
                {
                    if (MessageBox.Show("KİTAP TÜRÜNÜ GÜNCELLEMEK İSTİYOR MUSUNUZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (GeneralCrud.IDU("update Tbl_TypeBook set BookType='" + Txt_TypeBook.Text.Trim() + "' where ID=" + id + ""))
                        {
                            MessageBox.Show("KİTAP TÜRÜ GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Txt_TypeBook.Text = null;
                            Txt_TypeBook.Focus();
                            id = null;
                            gridControl1.DataSource = GeneralCrud.List("SELECT ID,BookType as 'KITAP_TURU' FROM Tbl_TypeBook order by BookType");
                        }
                    }
                }
            }
            else
                MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ KİTAP TÜRÜNÜ LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (MessageBox.Show("SEÇİLEN KİTAP TÜRÜNÜ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ SİLERSENİZ ?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show(
                        "KİTABI SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ SİLERSENİZ KİTABA BAĞLI VERİLMİŞ TÜM EMANET KİTAPLAR SİLİNECEKTİR VE KAYBOLACAKTIR EMİN MİSİNİZ?",
                        "SİLME İŞLEMİ",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (LoginAdmin.Password ==
                            Interaction.InputBox("SİLMEK İÇİN KAYDI GİRİŞ ŞİFRENİZİ YAZMANIZ GEREKİYOR !!",
                                "SİLME İŞLEMİ", null))
                        {
                            if (GeneralCrud.IDU("delete from Tbl_TypeBook where ID=" + id + ""))
                            {
                                MessageBox.Show("KİTAP TÜRÜ SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                Txt_TypeBook.Text = null;
                                id = null;
                                Txt_TypeBook.Focus();
                                gridControl1.DataSource =
                                    GeneralCrud.List(
                                        "SELECT ID,BookType as 'KITAP_TURU' FROM Tbl_TypeBook order by BookType");
                            }
                        }
                        else
                            Interaction.MsgBox("KİTAP TÜRÜ SİLME İŞLEMİ BAŞARISIZ SİLME İŞLEMİ HATALI",
                                MsgBoxStyle.Critical, "HATALI");
                    }
                }
            }
            else
                MessageBox.Show("SİLMEK İSTEDİĞİNİZ KİTAP TÜRÜNÜ LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void frm_BookType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                Add();
            else if (e.KeyCode == Keys.F5)
                UpdateBook();
        }
        private void Txt_TypeBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }
        private void frm_BookType_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GeneralCrud.List("SELECT ID,BookType as 'KITAP_TURU' FROM Tbl_TypeBook order by BookType");
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateBook();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                id = gridView1.GetFocusedRowCellValue("ID").ToString();
                Txt_TypeBook.Text = gridView1.GetFocusedRowCellValue("KITAP_TURU").ToString();
            }
            catch (Exception)
            {
            }
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KitapTuru.xlsx");

        }
        private void pDFAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KitapTuru.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KitapTuru.html");
        }
    }
}