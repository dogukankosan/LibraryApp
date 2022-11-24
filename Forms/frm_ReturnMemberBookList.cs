using KutuphaneOtomasyonu.Class;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_ReturnMemberBookList : Form
    {
        public frm_ReturnMemberBookList()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        private string ID = default;
        private string memberID = default;
        private void frm_ReturnMemberBookList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GeneralCrud.List("SELECT tbl_orderfich.id,\r\n       tbl_member.id             AS 'MEMBERIDD',\r\n       tbl_member.namesurname    AS 'ISIM_SOYISIM',\r\n       bookname                  AS 'KITAP_ADI',\r\n       purchase_date             AS 'EMANET_TARIHI',\r\n       delivery_date             AS 'TESLIM_TARIHI',\r\n       CASE ispurchase\r\n         WHEN 0 THEN 'TESLIM EDILMEDI'\r\n         WHEN 1 THEN 'TESLIM EDILI'\r\n         ELSE 'HATALI'\r\n       END 'TESLIM_EDILDI_MI',\r\n\t   CASE IsTimelyDelivery\r\n         WHEN 0 THEN 'DAHA TESLIM EDILMEDI'\r\n         WHEN 1 THEN 'ZAMANINDA TESLIM EDILDI'\r\n\t\twhen -1 then 'ZAMANINDA TESLIM EDILMEDI'\r\n         ELSE 'HATALI'\r\n       END 'ZAMANINDA_TESLIM_EDILDI_MI',\r\n\t   IsTimelyDate as 'UYENIN_TESLIM_ETTIGI_TARIH',\r\n       tbl_orderfich.description AS 'ACIKLAMA'\r\nFROM   tbl_orderfich\r\n       INNER JOIN tbl_member\r\n               ON memberid = tbl_member.id\r\n       INNER JOIN tbl_book\r\n               ON tbl_book.id = bookid \r\n\t\t\t   WHERE ispurchase=0");
            gridView1.Columns["MEMBERIDD"].Visible = false;
        }
        private void üyeİadeEttiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID))
            {
                if (DateTime.Parse(gridView1.GetFocusedRowCellValue("TESLIM_TARIHI").ToString()) < DateTime.Now)
                {
                    MessageBox.Show(
                        "TESLİM TARİHİ BUGÜNDEN SONRADIR ÜYE ZAMANINDA TESLİM ETMEMİŞTİR BUTONUNDAN İŞLEMİNİZİ YAPINIZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("SEÇİLİ KAYDIN ÜYE KİTABI ZAMANINDA TESLİM ETMİŞTİR İADE İŞLEMİ YAPILACAKTIR VE GERİ ALINAMAZ EMİN MİSİNİZ ?", "İADE İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (LoginAdmin.Password == Interaction.InputBox("GİRİŞ ŞİFREİNİZİ GİRİNİZ", "KAYDIN GÜNCELLENEBİLMESİ İÇİN GİRİŞ ŞİFRESİNİ GİRİNİZ", null))
                    {
                        if (GeneralCrud.IDU("update Tbl_OrderFich set ISPurchase=1 , IsTimelyDelivery=1,IsTimelyDate='" + DateTime.Now + "' where ID=" + ID + ""))
                            MessageBox.Show("İADE İŞLEMİ BAŞARILI !!", "İADE İŞLEMİ", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        else
                            MessageBox.Show("İADE ALMA İŞLEMİ HATALI", "HATALI", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                    else
                        Interaction.MsgBox("KAYIT GÜNCELLENEMEDİ HATALI !!", MsgBoxStyle.Critical, "HATALI");
                    ID = null;
                    gridControl1.DataSource = GeneralCrud.List("SELECT tbl_orderfich.id,\r\n       tbl_member.id             AS 'MEMBERIDD',\r\n       tbl_member.namesurname    AS 'ISIM_SOYISIM',\r\n       bookname                  AS 'KITAP_ADI',\r\n       purchase_date             AS 'EMANET_TARIHI',\r\n       delivery_date             AS 'TESLIM_TARIHI',\r\n       CASE ispurchase\r\n         WHEN 0 THEN 'TESLIM EDILMEDI'\r\n         WHEN 1 THEN 'TESLIM EDILI'\r\n         ELSE 'HATALI'\r\n       END 'TESLIM_EDILDI_MI',\r\n\t   CASE IsTimelyDelivery\r\n         WHEN 0 THEN 'DAHA TESLIM EDILMEDI'\r\n         WHEN 1 THEN 'ZAMANINDA TESLIM EDILDI'\r\n\t\twhen -1 then 'ZAMANINDA TESLIM EDILMEDI'\r\n         ELSE 'HATALI'\r\n       END 'ZAMANINDA_TESLIM_EDILDI_MI',\r\n\t   IsTimelyDate as 'UYENIN_TESLIM_ETTIGI_TARIH',\r\n       tbl_orderfich.description AS 'ACIKLAMA'\r\nFROM   tbl_orderfich\r\n       INNER JOIN tbl_member\r\n               ON memberid = tbl_member.id\r\n       INNER JOIN tbl_book\r\n               ON tbl_book.id = bookid \r\n\t\t\t   WHERE ispurchase=0");
                }
            }
            else
                MessageBox.Show("İADE İŞLEMİ YAPABİLMEK İÇİN SATIRI SEÇİNİZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                ID = gridView1.GetFocusedRowCellValue("ID").ToString();
                memberID = gridView1.GetFocusedRowCellValue("MEMBERIDD").ToString();
            }
            catch (Exception)
            {

            }
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UyeKitap.html");
        }
        private void pDFAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UyeKitap.pdf");
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "UyeKitap.xlsx");
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID))
            {
                if (DateTime.Parse(gridView1.GetFocusedRowCellValue("TESLIM_TARIHI").ToString()) > DateTime.Now)
                {
                    MessageBox.Show(
                        "TESLİM TARİHİ BUGÜNDEN ÖNCEDİR ÜYE ZAMANINDA TESLİM ETMİŞTİR BUTONUNDAN İŞLEMİNİZİ YAPINIZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (DialogResult.Yes == MessageBox.Show("SEÇİLİ KAYDIN ÜYE KİTABI ZAMANINDA TESLİM ETMEMİŞTİR İADE İŞLEMİ YAPILACAKTIR VE GERİ ALINAMAZ EMİN MİSİNİZ ?", "İADE İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (LoginAdmin.Password == Interaction.InputBox("GİRİŞ ŞİFREİNİZİ GİRİNİZ", "KAYDIN GÜNCELLENEBİLMESİ İÇİN GİRİŞ ŞİFRESİNİ GİRİNİZ", null))
                    {
                        if (GeneralCrud.IDU("update Tbl_OrderFich set ISPurchase=1 , IsTimelyDelivery=-1,IsTimelyDate='" + DateTime.Now + "' where ID=" + ID + ""))
                        {
                            MessageBox.Show("İADE İŞLEMİ  BAŞARILI !!", "İADE İŞLEMİ", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Punishment.PunisDb(gridView1, memberID);
                        }
                        else
                            MessageBox.Show("İADE İŞLEMİ HATALI KAYIT GÜNCELLENEMEDİ !!", "HATALI",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        Interaction.MsgBox("KAYIT GÜNCELLENEMEDİ HATALI !!", MsgBoxStyle.Critical, "HATALI");
                    ID = null;
                    gridControl1.DataSource = GeneralCrud.List("SELECT tbl_orderfich.id,\r\n       tbl_member.id             AS 'MEMBERIDD',\r\n       tbl_member.namesurname    AS 'ISIM_SOYISIM',\r\n       bookname                  AS 'KITAP_ADI',\r\n       purchase_date             AS 'EMANET_TARIHI',\r\n       delivery_date             AS 'TESLIM_TARIHI',\r\n       CASE ispurchase\r\n         WHEN 0 THEN 'TESLIM EDILMEDI'\r\n         WHEN 1 THEN 'TESLIM EDILI'\r\n         ELSE 'HATALI'\r\n       END 'TESLIM_EDILDI_MI',\r\n\t   CASE IsTimelyDelivery\r\n         WHEN 0 THEN 'DAHA TESLIM EDILMEDI'\r\n         WHEN 1 THEN 'ZAMANINDA TESLIM EDILDI'\r\n\t\twhen -1 then 'ZAMANINDA TESLIM EDILMEDI'\r\n         ELSE 'HATALI'\r\n       END 'ZAMANINDA_TESLIM_EDILDI_MI',\r\n\t   IsTimelyDate as 'UYENIN_TESLIM_ETTIGI_TARIH',\r\n       tbl_orderfich.description AS 'ACIKLAMA'\r\nFROM   tbl_orderfich\r\n       INNER JOIN tbl_member\r\n               ON memberid = tbl_member.id\r\n       INNER JOIN tbl_book\r\n               ON tbl_book.id = bookid \r\n\t\t\t   WHERE ispurchase=0");
                }
            }
            else
                MessageBox.Show("İADE İŞLEMİ YAPABİLMEK İÇİN SATIRI SEÇİNİZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void frm_ReturnMemberBookList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}