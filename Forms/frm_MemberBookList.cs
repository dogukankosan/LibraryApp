using KutuphaneOtomasyonu.Class;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_MemberBookList : Form
    {
        public frm_MemberBookList()
        {
            InitializeComponent();
        }
        private void frm_MemberBookList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void frm_MemberBookList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GeneralCrud.List("select Tbl_Book.ID,BarcodeNo as 'BARKOD_NO',\r\nBookName as 'KITAP_ADI',\r\nWriter as 'YAZAR_ADI',\r\nPublisherName as 'YAYIN_EVI',\r\nBookType as 'KITAP_TURU',\r\nPageCount as 'SAYFA_SAYISI',\r\nStockCount as 'STOK_SAYISI',\r\n RackNo as 'RAF_NO',\r\n Description as 'ACIKLAMA',\r\n _Date as 'KITABIN_KAYIT_TARIHI',\r\n _Picture as 'RESIM'\r\nfrom Tbl_Book inner join Tbl_Publisher on Tbl_Publisher.ID = Tbl_Book.PublisherID inner join Tbl_TypeBook on Tbl_TypeBook.ID = Tbl_Book.BookTypeID\r\nwhere StockCount>0\r\norder by BookName");
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["RESIM"].Visible = false;
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                frm_ImageBookList fr = new();
                fr.images = gridView1.GetFocusedRowCellValue("RESIM").ToString();
                fr.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
    }
}