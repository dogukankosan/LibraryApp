using KutuphaneOtomasyonu.Class;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }
        private void üyeEklemeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MemberAdd fr = new();
            fr.ShowDialog();
        }
        private void üyeListelemeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MemberList fr = new();
            fr.ShowDialog();
        }
        private void kitapEklemeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BookAdd fr = new();
            fr.ShowDialog();
        }
        private void kitapYayınEviEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Publisher fr = new();
            fr.ShowDialog();
        }
        private void kitapTürüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BookType fr = new();
            fr.ShowDialog();
        }
        private void kitapListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BookList fr = new();
            fr.ShowDialog();
        }
        private void emanetKitapVermeİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_OrderFiche fr = new();
            fr.ShowDialog();
        }
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AdminAdd fr = new();
            fr.ShowDialog();
        }
        private void mailHesabıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MailSendAdd fr = new();
            fr.ShowDialog();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            if (LoginAdmin.IsLogin == "1")
            {
                kİTAPLARToolStripMenuItem.Visible = false;
                üYEİŞLEMLERİToolStripMenuItem1.Visible = false;
            }
            if (LoginMember.IsMember == "0")
            {
                aDMİNAYARLARIToolStripMenuItem.Visible = false;
                üYEİŞLEMLERİToolStripMenuItem.Visible = false;
                kİTAPİŞLEMLERİToolStripMenuItem.Visible = false;
                eMANETKİTAPİŞLEMLERİToolStripMenuItem.Visible = false;
                rAPORLAMAGRAFİKLERToolStripMenuItem.Visible = false;
                aDMİNAYARLARIToolStripMenuItem.Visible = false;
            }
        }
        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MemberBookList fr = new();
            fr.ShowDialog();
        }
        private void bilgileriniziDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MemberUpdate fr = new();
            fr.ShowDialog();
        }
        private void emanetAldığınızKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "select BookName as 'KITAP_ADI',Purchase_Date as 'EMANET_TARIHI',Delivery_Date as 'TESLIM_TARIHI',Tbl_OrderFich.Description as 'ACIKLAMA' from Tbl_OrderFich inner join Tbl_Book on Tbl_Book.ID=BookID where ISPurchase=0 and Tbl_OrderFich.MemberID=" + LoginMember.ID + "";
            fr.ShowDialog();
        }
        private void teslimEttiğinizKitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "select BookName as 'KITAP_ADI',Purchase_Date as 'EMANET_TARIHI',Delivery_Date as 'TESLIM_TARIHI',\r\nCASE IsTimelyDelivery\r\n WHEN 0 THEN 'DAHA TESLIM EDILMEDI' \r\n WHEN 1 THEN 'ZAMANINDA TESLIM EDİLDİ'   \r\n WHEN -1 THEN 'ZAMANINDA TESLIM EDİLMEDİ'  \r\n ELSE 'HATALI' \r\n END 'ZAMANINDA_TESLIM_EDILDI_MI'\r\n\r\n,IsTimelyDate as 'TESLIM_ETTIGIN_TARIH',Tbl_OrderFich.Description as 'ACIKLAMA'\r\n from Tbl_OrderFich inner join Tbl_Book on Tbl_Book.ID=BookID where ISPurchase=1 and Tbl_OrderFich.MemberID="+LoginMember.ID+"\r\n ";
            fr.ShowDialog();
        }
        private void enÇokOkunanKitaplarımızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "select BookName as 'KITAP_ADI',Count(*) as 'SAYISI' from Tbl_OrderFich inner join Tbl_Book on Tbl_Book.ID=BookID where ISPurchase=1 group by BookName order by count(*) desc";
            fr.ShowDialog();
        }
        private void enÇokOkunanKitapTürümüzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "select Tbl_TypeBook.BookType as 'KITAP_TURU', count(*) as 'SAYISI 'from Tbl_OrderFich inner join  Tbl_Book on Tbl_Book.ID=Tbl_OrderFich.BookID inner join Tbl_TypeBook on Tbl_TypeBook.ID=Tbl_Book.BookTypeID GROUP by Tbl_Book.BookTypeID";
            fr.ShowDialog();
        }
        private void emanetKitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ReturnMemberBookList fr = new();
            fr.ShowDialog();
        }
        private void emanetKitapListesiİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "SELECT tbl_orderfich.id,\r\n        tbl_member.tc,\r\n        tbl_member.namesurname AS 'ISIM_SOYISIM',\r\n        tbl_member.e_mail      AS 'E_MAIL',\r\n        tbl_member.phone       AS 'TELEFON',\r\n        bookname               AS 'KITAP_ADI',\r\n        booktype               AS 'KITAP_TURU',\r\n        publishername          AS 'YAYIN_EVI',\r\n        purchase_date          AS 'EMANET_TARIHI',\r\n        delivery_date          AS 'TESLIM_TARIHI',\r\n        case ispurchase WHEN   0 THEN\r\n'TESLIM EDILMEDI'\r\nWHEN 1 THEN\r\n  'TESLIM EDILI' else 'HATALI' end TESLIM_EDILDI_MI,\r\n  \r\n   case IsTimelyDelivery WHEN   0 THEN\r\n'DAHA TESLIM EDILMEDI'\r\nWHEN 1 THEN\r\n  'ZAMANINDA TESLIM EDILI' WHEN -1  THEN 'ZAMANINDA TESLİM EDİLMEDİ' else 'HATALI' end ZAMANINDA_TESLIM_EDILDI_MI,\r\n  \r\ntbl_orderfich.description AS 'ACIKLAMA'  from tbl_orderfich inner JOIN tbl_member ON memberid=tbl_member.id inner JOIN tbl_book ON tbl_book.id=bookid inner JOIN tbl_typebook ON tbl_typebook.id=tbl_book.booktypeid inner JOIN tbl_publisher ON tbl_publisher.id=tbl_book.publisherid\r\n  \r\n  \r\n";
            fr.ShowDialog();
        }
        private void sQLCümlesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sql fr = new();
            fr.ShowDialog();
        }
        private void veriTabanıYedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fr = new();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(fr.SelectedPath))
                {
                    Connection.Backup(fr.SelectedPath);
                    MessageBox.Show("YEDEK ALMA İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("YEDEK ALMA İŞLEMİ BAŞARISIZ YOL SEÇİLMEDİ !!", "BAŞARISIZ", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void grafikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Chart fr = new ();
            fr.sql = "select NameSurname,ReadBooksCount from Tbl_Member order by ReadBooksCount desc";
            fr.ShowDialog();
        }
        private void cezaİşlemiAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Settings fr = new ();
            fr.ShowDialog();
        }
        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "SELECT tbl_orderfich.id,\r\n         tbl_member.namesurname AS 'AD_SOYAD',\r\n                                tbl_member.tc,\r\n         tbl_member.phone       AS 'TELEFON',\r\n         tbl_member.e_mail      AS 'E_MAIL',\r\n         tbl_book.bookname      AS 'KITAP_ADI',\r\n         purchase_date          AS 'EMANET_TARIHI',\r\n         delivery_date          AS 'TESLIM_TARIHI',\r\n          \r\n       CASE ispurchase  \r\n              WHEN 0 THEN 'TESLIM EDILMEDI'  \r\n              WHEN 1 THEN 'TESLIM EDİLDİ'  \r\n              ELSE 'HATALI'  \r\n       END 'TESLIM_EDILDI_MI',\r\n         tbl_orderfich.description AS 'ACIKLAMA'\r\nFROM   tbl_orderfich INNER join tbl_member\r\nON tbl_member.id=memberid INNER join tbl_book\r\nON tbl_book.id=bookid\r\nWHERE  ispurchase=0\r\nAND    istimelydelivery=0 and strftime('%Y%m%d',datetime('now','localtime'))>=replace(delivery_date,'-','') \r\n";
            fr.ShowDialog();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "SELECT tbl_orderfich.id,\r\n         tbl_member.namesurname AS 'AD_SOYAD',\r\n                                tbl_member.tc,\r\n         tbl_member.phone       AS 'TELEFON',\r\n         tbl_member.e_mail      AS 'E_MAIL',\r\n         tbl_book.bookname      AS 'KITAP_ADI',\r\n         purchase_date          AS 'EMANET_TARIHI',\r\n         delivery_date          AS 'TESLIM_TARIHI',\r\n          \r\n       CASE ispurchase  \r\n              WHEN 0 THEN 'TESLIM EDILMEDI'  \r\n              WHEN 1 THEN 'TESLIM EDİLDİ'  \r\n              ELSE 'HATALI'  \r\n       END 'TESLIM_EDILDI_MI',\r\n         tbl_orderfich.description AS 'ACIKLAMA'\r\nFROM   tbl_orderfich INNER join tbl_member\r\nON tbl_member.id=memberid INNER join tbl_book\r\nON tbl_book.id=bookid\r\nWHERE  ispurchase=0\r\nAND    istimelydelivery=0 and strftime('%Y%m%d',datetime('now','localtime'))<=replace(delivery_date,'-','') ";
            fr.ShowDialog();
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "SELECT tbl_orderfich.id,\r\n       tbl_member.namesurname AS 'AD_SOYAD',\r\n         tbl_member.tc,\r\n         tbl_member.phone     AS 'TELEFON',\r\n         tbl_member.e_mail    AS 'E_MAIL',\r\n         tbl_book.bookname    AS 'KITAP_ADI',\r\n         purchase_date        AS 'EMANET_TARIHI',\r\n         delivery_date        AS 'TESLIM_TARIHI',\r\n         case ispurchase WHEN 0 THEN\r\n'TESLIM EDILMEDI'  when 1 THEN\r\n'TESLIM EDİLDİ'  else 'HATALI'  end 'TESLIM_EDILDI_MI',  tbl_orderfich.description AS 'ACIKLAMA',  case istimelydelivery\r\nWHEN 0 THEN\r\n  'DAHA TESLIM EDILMEDI'  when 1 THEN\r\n  'ZAMANINDA TESLIM EDİLDİ'  when -1 THEN\r\n  'ZAMANINDA TESLIM ETMEDİ'  else 'HATALI'  end 'ZAMANINDA_TESLIM_EDILDI_MI'  from tbl_orderfich   inner JOIN tbl_member ON tbl_member.id=memberid  inner JOIN tbl_book ON tbl_book.id=bookid  where ispurchase=1\r\n  AND\r\n  istimelydelivery=1\r\n";
            fr.ShowDialog();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "SELECT id,\r\n       tc,\r\n       namesurname    AS 'AD_SOYAD',\r\n       birthday       AS 'DOGUM_TARIHI',\r\n       gender         'CINSIYET',\r\n       phone          AS 'TELEFON',\r\n       adress         AS 'ADRES',\r\n       e_mail         AS 'E_MAIL',\r\n       readbookscount AS 'OKUNAN KITAP SAYISI',\r\n       balance        AS 'BORC'\r\nFROM   tbl_member\r\nWHERE  balance < 0 ";
            fr.ShowDialog();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "SELECT id,\r\n       tc,\r\n       namesurname AS 'AD_SOYAD',\r\n       birthday    AS 'DOGUM_TARIHI',\r\n       gender 'CINSIYET',\r\n       phone          AS 'TELEFON',\r\n       adress         AS 'ADRES',\r\n       e_mail         AS 'E_MAIL',\r\n       readbookscount AS 'OKUNAN KITAP SAYISI',\r\n       balance        AS 'BORC'    from tbl_member\r\n\t   where Balance=0";
            fr.ShowDialog();
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "select BookName as 'KITAP_ADI',Count(*) as 'SAYISI' from Tbl_OrderFich inner join Tbl_Book on Tbl_Book.ID=BookID  group by BookName order by count(*) desc";
            fr.ShowDialog();
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "select Tbl_TypeBook.BookType as 'KITAP_TURU', count(*) as 'SAYISI 'from Tbl_OrderFich inner join  Tbl_Book on Tbl_Book.ID=Tbl_OrderFich.BookID inner join Tbl_TypeBook on Tbl_TypeBook.ID=Tbl_Book.BookTypeID GROUP by Tbl_Book.BookTypeID";
            fr.ShowDialog();
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "select Tbl_Publisher.PublisherName as 'YAYIN_EVI', count(*) as 'SAYISI '\r\nfrom Tbl_OrderFich inner join  Tbl_Book on Tbl_Book.ID=Tbl_OrderFich.BookID \r\ninner join Tbl_Publisher on Tbl_Publisher.ID=Tbl_Book.PublisherID\r\nGROUP by Tbl_Book.PublisherID";
            fr.ShowDialog();
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frm_GeneralMemberList fr = new();
            fr.sql = "select Tbl_Book.ID,BarcodeNo as 'BARKOD_NO',\r\nBookName AS 'KITAP_ADI',\r\nWriter as 'YAZAR_ADI',\r\nBookType as 'KITAP_ADI',\r\nPublisherName as 'YAZAR_EVI',\r\nStockCount as 'STOK_DURUMU',\r\nRackNo as 'RAF_NO',\r\nDescription as 'ACIKLAMA',\r\n_Date as 'KAYIT_TARIHI'\r\n from Tbl_Book\r\n inner join Tbl_Publisher on Tbl_Publisher.ID=PublisherID\r\n inner join Tbl_TypeBook on Tbl_TypeBook.ID=BookTypeID\r\n where StockCount=0\r\n \r\n";
            fr.ShowDialog();
        }
        private void toolStripMenuItem9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Chart fr = new();
            fr.sql = "select NameSurname,ReadBooksCount from Tbl_Member where ReadBooksCount<1 order by ReadBooksCount";
            fr.ShowDialog();
        }
    }
}