using System.Data.SQLite;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KutuphaneOtomasyonu.Class
{
    internal class OrderConrol
    {
        internal static bool Control(LookUpEdit member, LookUpEdit book, DateTimePicker Dt_Purchase, DateTimePicker Dt_Delivery)
        {
            if (string.IsNullOrEmpty(member.Text))
            {
                MessageBox.Show("ÜYE ADI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(book.Text))
            {
                MessageBox.Show("KİTAP ADI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Dt_Purchase.Value > Dt_Delivery.Value || Dt_Purchase.Value == Dt_Delivery.Value)
            {
                MessageBox.Show("TESLİM TARİHİ ALIM TARİHİNDEN ÖNCE OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Dt_Delivery.Focus();
                return false;
            }
            #region BOOKCONTROL

            Connection.dbConnection.Open();
            SQLiteCommand cmd = new("select Tbl_OrderFich.ID,BookName,Purchase_Date,Delivery_Date from Tbl_OrderFich inner join Tbl_Book on Tbl_Book.ID=Tbl_OrderFich.BookID where MemberID=" + member.EditValue + " and BookID=" + book.EditValue + " and IsPurchase=0", Connection.dbConnection);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0] is not null)
                {
                    MessageBox.Show($"EMANET VERİLEN KİTAP {rd["BookName"]}  {rd["Purchase_Date"]} TARİHİNDE EMANET VERİLMİŞTİR !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rd.Close();
                    Connection.dbConnection.Close();
                    return false;
                }
            }
            Connection.dbConnection.Close();
            #endregion BOOKCONTROL
            return true;
        }
    }
}