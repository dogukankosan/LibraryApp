using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class LoginAdmin
    {
        private static readonly char[] turkishControl = new char[] { 'ç', 'Ç', 'ö', 'Ö', 'İ', 'ş', 'Ş', 'ü', 'Ü', 'ğ', 'Ğ', 'ı' };

        // LOGIN ADMIN INFO
        internal static string ID = default;

        internal static string UserName = default;
        internal static string Password = default;
        internal static string IsLogin = default;

        //LOGIN DATABASE VALUES CONTROL
        internal static bool DbValues()
        {
            Connection.dbConnection.Open();
            SQLiteCommand cmd = new("select ID,User,Password,IsMember from Tbl_Login", Connection.dbConnection);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[1] as string == LoginAdmin.UserName && rd[2] as string == Encription.Enc(LoginAdmin.Password))
                {
                    ID = rd[0].ToString();
                    LoginAdmin.IsLogin = rd[3].ToString();
                    Connection.dbConnection.Close();
                    return true;
                }
            }
            Connection.dbConnection.Close();
            return false;
        }

        internal static bool Control(TextBox username, TextBox Password, TextBox Email, string ID)
        {
            #region USERNAME

            if (string.IsNullOrEmpty(username.Text))
            {
                MessageBox.Show("KULLANICI ADI METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Focus();
                return false;
            }
            if (username.Text.Length < 3)
            {
                MessageBox.Show("KULLANICI ADI 3 HANEDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Focus();
                return false;
            }

            #endregion USERNAME

            #region PASSWORD

            if (string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("ŞİFRE METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Focus();
                return false;
            }
            if (Password.Text.Length < 3)
            {
                MessageBox.Show("ŞİFRE METİN KUTUSU 3 HANEDEN KÜÇÜK OLAMAZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Focus();
                return false;
            }
            bool valuesNumber = default;
            bool valuesUpper = default;
            bool valuesLower = default;
            bool valuesSymbol = default;
            for (byte i = 0; i < Password.Text.Length; i++)
            {
                if (char.IsNumber(Password.Text[i]))
                    valuesNumber = true;
                if (char.IsLower(Password.Text[i]))
                    valuesLower = true;
                if (char.IsUpper(Password.Text[i]))
                    valuesUpper = true;
                if (Password.Text[i] == '.' || Password.Text[i] == '*' || Password.Text[i] == '-' || Password.Text[i] == '/' || Password.Text[i] == ',')
                    valuesSymbol = true;
            }
            if (!valuesNumber)
            {
                MessageBox.Show("ŞİFRE METİN KUTUSUNDA EN AZ 1 ADET RAKAM İÇERMELİDİR !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Focus();
                return false;
            }
            if (!valuesUpper)
            {
                MessageBox.Show("ŞİFRE METİN KUTUSUNDA EN AZ 1 ADET BÜYÜK HARF İÇERMELİDİR !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Focus();
                return false;
            }
            if (!valuesLower)
            {
                MessageBox.Show("ŞİFRE METİN KUTUSUNDA EN AZ 1 ADET KÜÇÜK HARF İÇERMELİDİR !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Focus();
                return false;
            }
            if (!valuesSymbol)
            {
                MessageBox.Show("ŞİFRE METİN KUTUSUNDA EN AZ 1 ADET (. , / * -) KARAKTERLERİNDEN BİRİNİ İÇERMELİDİR !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Focus();
                return false;
            }

            #endregion PASSWORD

            #region EMAILCONTNROL

            if (string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("E-MAİL KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Email.Focus();
                return false;
            }
            if (!Email.Text.Contains("@"))
            {
                MessageBox.Show("MAİL FORMATI GEÇERSİZ TEKRAR GİRİŞİ YAPINIZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Email.Focus();
                Email.Text = string.Empty;
                return false;
            }
            if (Email.Text.Length < 8)
            {
                MessageBox.Show("E-MAİL KUTUSU GİRİLEN MAİL 8 KARAKTERDEN KISA OLAMAZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email.Focus();
                return false;
            }
            for (byte i = 0; i < turkishControl.Length; i++)
            {
                if (Email.Text.Contains(turkishControl[i]))
                {
                    MessageBox.Show("MAİL METİN KUTUSUNDA TÜRKÇE KARAKTER OLAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Text = string.Empty;
                    Email.Focus();
                    return false;
                }
            }

            #endregion EMAILCONTNROL

            Connection.dbConnection.Open();
            SQLiteCommand cmd;
            if (string.IsNullOrEmpty(ID))
            {
                cmd = new("select User,E_Mail from Tbl_Login where User='" + username.Text + "' or E_Mail='" + Email.Text + "'", Connection.dbConnection);
            }
            else
            {
                cmd = new("select User,E_Mail from Tbl_Login where ID <> " + ID + " ", Connection.dbConnection);
            }
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0] as string == username.Text)
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTENEN KULLANICI ADI DAHA ÖNCEDEN TANIMLANMIŞTIR", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username.Focus();
                    rd.Close();
                    Connection.dbConnection.Close();
                    return false;
                }
                else if (rd[1] as string == Email.Text)
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTENEN EMAİL ADRESİ DAHA ÖNCEDEN TANIMLANMIŞTIR", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Focus();
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