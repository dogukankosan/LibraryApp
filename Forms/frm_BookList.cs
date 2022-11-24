using KutuphaneOtomasyonu.Class;
using Microsoft.VisualBasic;
using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_BookList : Form
    {
        public frm_BookList()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        private string id = null;
        private void Clear()
        {
            if (MessageBox.Show("MESAJ KUTULARIN TAMAMI TEMİZLENECEKTİR EMİN MİSİNİZ ?", "TEMİZLEME",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = null;
                }
                id = null;
                Cmb_Publisher.Text = null;
                Cbm_BookType.Text = null;
                Rch_Description.Text = null;
                Msk_BarcodeNo.Text = null;
                nmr_PageCount.Text = 1.ToString();
                nmr_StockCount.Text = 1.ToString();
                pictureEdit1.Image = null;
                Msk_BarcodeNo.Focus();
            }
        }
        private void UpdateBook()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (BookControl.ControlBook(Msk_BarcodeNo, Txt_BookName, Txt_Writer, Cmb_Publisher, nmr_PageCount,
                    Cbm_BookType, nmr_StockCount, Txt_RackNo, id))
                {
                    if (MessageBox.Show("SEÇİLİ KİTABI GÜNCELLEMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "GÜNCELLEME İŞLEMİ",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (GeneralCrud.IDU("update Tbl_Book set BarcodeNo='" + Msk_BarcodeNo.Text + "',BookName='" + Txt_BookName.Text.Trim() + "',Writer='" + Txt_Writer.Text.Trim() + "',PublisherID=" + Cmb_Publisher.SelectedValue + ",PageCount=" + nmr_PageCount.Value + ",BookTypeID=" + Cbm_BookType.SelectedValue + ",StockCount=" + nmr_StockCount.Value + ",RackNo='" + Txt_RackNo.Text.Trim() + "',Description='" + Rch_Description.Text.Trim() + "',_Picture='" + ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "' where ID=" + id + ""))
                        {
                            MessageBox.Show("KİTAP GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Clear();
                            Msk_BarcodeNo.Focus();
                            gridControl1.DataSource = GeneralCrud.List("select Tbl_Book.ID,BarcodeNo as 'BARKOD_NO',BookName as 'KITAP_ADI',Writer as 'YAZAR_ADI',PublisherName as 'YAYIN_EVI',BookType as 'KITAP_TURU',PageCount as 'SAYFA_SAYISI',StockCount as 'STOK_SAYISI', RackNo as 'RAF_NO', Description as 'ACIKLAMA', _Date as 'TARIH', _Picture as 'RESIM' from Tbl_Book inner join Tbl_Publisher on Tbl_Publisher.ID = Tbl_Book.PublisherID inner join Tbl_TypeBook on Tbl_TypeBook.ID = Tbl_Book.BookTypeID");
                            id = null;
                        }
                    }
                }
            }
            else
                MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ KİTABI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void DeleteBook()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (MessageBox.Show("SEÇİLİ KİTABI SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "SİLME İŞLEMİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                            if (GeneralCrud.IDU("delete from Tbl_Book where ID=" + id + ""))
                            {
                                MessageBox.Show("KİTAP SİLME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                Clear();
                                Msk_BarcodeNo.Focus();
                                gridControl1.DataSource = GeneralCrud.List("select Tbl_Book.ID,BarcodeNo as 'BARKOD_NO',BookName as 'KITAP_ADI',Writer as 'YAZAR_ADI',PublisherName as 'YAYIN_EVI',BookType as 'KITAP_TURU',PageCount as 'SAYFA_SAYISI',StockCount as 'STOK_SAYISI', RackNo as 'RAF_NO', Description as 'ACIKLAMA', _Date as 'TARIH', _Picture as 'RESIM' from Tbl_Book inner join Tbl_Publisher on Tbl_Publisher.ID = Tbl_Book.PublisherID inner join Tbl_TypeBook on Tbl_TypeBook.ID = Tbl_Book.BookTypeID");
                                id = null;
                            }
                        }
                        else
                            Interaction.MsgBox("SİLME İŞLEMİ HATALI KAYIT SİLİNEMEDİ !!", MsgBoxStyle.Critical, "HATALI");
                    }
                }
            }
            else
                MessageBox.Show("SİLMEK İSTEDİĞİNİZ KİTABI LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void frm_BookList_Load(object sender, EventArgs e)
        {
            Cbm_BookType.DataSource = GeneralCrud.List("SELECT * FROM Tbl_TypeBook ");
            Cbm_BookType.DisplayMember = "BookType";
            Cbm_BookType.ValueMember = "ID";
            Cmb_Publisher.DataSource = GeneralCrud.List("SELECT * FROM Tbl_Publisher ");
            Cmb_Publisher.DisplayMember = "PublisherName";
            Cmb_Publisher.ValueMember = "ID";
            Cmb_Publisher.Text = null;
            Cbm_BookType.Text = null; gridControl1.DataSource = GeneralCrud.List("select Tbl_Book.ID,BarcodeNo as 'BARKOD_NO',BookName as 'KITAP_ADI',Writer as 'YAZAR_ADI',PublisherName as 'YAYIN_EVI',BookType as 'KITAP_TURU',PageCount as 'SAYFA_SAYISI',StockCount as 'STOK_SAYISI', RackNo as 'RAF_NO', Description as 'ACIKLAMA', _Date as 'TARIH', _Picture as 'RESIM' from Tbl_Book inner join Tbl_Publisher on Tbl_Publisher.ID = Tbl_Book.PublisherID inner join Tbl_TypeBook on Tbl_TypeBook.ID = Tbl_Book.BookTypeID");
            gridView1.Columns["RESIM"].Visible = false;
        }
        private void frm_BookList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                UpdateBook();
            else if (e.KeyCode == Keys.F3)
                Clear();
            else if (e.KeyCode == Keys.F5)
                DeleteBook();
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdateBook();
        }
        private void Txt_Writer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                id = gridView1.GetFocusedRowCellValue("ID").ToString();
                Msk_BarcodeNo.Text = gridView1.GetFocusedRowCellValue("BARKOD_NO").ToString();
                Txt_BookName.Text = gridView1.GetFocusedRowCellValue("KITAP_ADI").ToString();
                Txt_Writer.Text = gridView1.GetFocusedRowCellValue("YAZAR_ADI").ToString();
                Cmb_Publisher.Text = gridView1.GetFocusedRowCellValue("YAYIN_EVI").ToString();
                nmr_PageCount.Value = long.Parse(gridView1.GetFocusedRowCellValue("SAYFA_SAYISI").ToString());
                Cbm_BookType.Text = gridView1.GetFocusedRowCellValue("KITAP_TURU").ToString();
                nmr_StockCount.Value = long.Parse(gridView1.GetFocusedRowCellValue("STOK_SAYISI").ToString());
                Txt_RackNo.Text = gridView1.GetFocusedRowCellValue("RAF_NO").ToString();
                Rch_Description.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
                pictureEdit1.Image = ImageConvert.Base64ToImage(gridView1.GetFocusedRowCellValue("RESIM").ToString());
            }
            catch (Exception)
            {

            }
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KitapListesi.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KitapListesi.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "KitapListesi.html");
        }
    }
}