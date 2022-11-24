using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class BookType
    {
        internal static bool ControlType(TextBox type, string ID)
        {
            if (string.IsNullOrEmpty(type.Text))
            {
                MessageBox.Show("KİTAP TÜRÜ METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                type.Focus();
                return false;
            }
            for (byte i = 0; i < type.Text.Length; i++)
            {
                if (char.IsNumber(type.Text[i]))
                {
                    MessageBox.Show("KİTAP TÜRÜ METİN KUTUSUNDA RAKAM BULUNAMAZ !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    type.Focus();
                    type.Text = null;
                    return false;
                }
            }
            if (type.Text.Length < 4)
            {
                MessageBox.Show("KİTAP TÜRÜ 4 KARAKTERDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                type.Text = null;
                type.Focus();
                return false;
            }
            Connection.dbConnection.Open();
            SQLiteCommand cmd;
            if (string.IsNullOrEmpty(ID))
            {
                cmd = new("select BookType from Tbl_TypeBook where BookType='" + type.Text + "'", Connection.dbConnection);
            }
            else
            {
                cmd = new("select BookType from Tbl_TypeBook where ID <> " + ID + "", Connection.dbConnection);
            }
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0] as string == type.Text || rd[0] as string == type.Text.ToLower() || rd[0] as string == type.Text.ToUpper())
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTEDEN KİTAP TÜRÜ DAHA ÖNCEDEN KAYIT EDİLMİŞTİR !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    type.Focus();
                    rd.Close();
                    Connection.dbConnection.Close();
                    return false;
                }
            }
            rd.Close();
            Connection.dbConnection.Close();
            return true;
        }
    }
}