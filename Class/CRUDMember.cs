using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class CRUDMember
    {
        private static readonly char[] turkishControl = new char[] { 'ç', 'Ç', 'ö', 'Ö', 'İ', 'ş', 'Ş', 'ü', 'Ü', 'ğ', 'Ğ', 'ı' };

        internal static bool Control(TextBox TC, TextBox NameSurname, ComboBox Gender, MaskedTextBox Phone, TextBox Email, TextBox Password, RichTextBox Adress, string ID)
        {
            #region TCCONTROL

            if (string.IsNullOrEmpty(TC.Text))
            {
                MessageBox.Show("TC METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TC.Focus();
                return false;
            }
            for (byte i = 0; i < TC.Text.Length; i++)
            {
                if (!char.IsNumber(TC.Text[i]))
                {
                    MessageBox.Show("TC METİN KUTUSUNDA RAKAM DIŞINDA BİR KARAKTER BULUNAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TC.Text = string.Empty;
                    TC.Focus();
                    return false;
                }
            }
            if (TC.Text.Length < 11)
            {
                MessageBox.Show("TC METİN KUTUSU 11 KARAKTERDEN KÜÇÜK OLAMAZ !!", "HATALI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TC.Text = string.Empty;
                TC.Focus();
                return false;
            }

            #endregion TCCONTROL

            #region NAMESURNAMECONTROL

            if (string.IsNullOrEmpty(NameSurname.Text))
            {
                MessageBox.Show("AD SOYAD METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                NameSurname.Focus();
                return false;
            }
            for (byte i = 0; i < NameSurname.Text.Length; i++)
            {
                if (char.IsNumber(NameSurname.Text[i]))
                {
                    MessageBox.Show("AD SOYAD METİN KUTUSUNDA HARF DIŞINDA BİR KARAKTER BULUNAMAZ !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameSurname.Text = string.Empty;
                    NameSurname.Focus();
                    return false;
                }
            }
            if (NameSurname.Text.Length < 5)
            {
                MessageBox.Show("AD SOYAD METİN KUTUSU 5 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                NameSurname.Text = string.Empty;
                NameSurname.Focus();
                return false;
            }

            #endregion NAMESURNAMECONTROL

            #region GENDERCONTROL

            if (string.IsNullOrEmpty(Gender.Text))
            {
                MessageBox.Show("CİNSİYET SEÇİMİ BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Gender.Focus();
                return false;
            }

            #endregion GENDERCONTROL

            #region PHONE

            if (Phone.Text.Length < 13)
            {
                MessageBox.Show("TELEFON METİN KUTUSUNU TAMAMEN DOLDURUNUZ", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Phone.Focus();
                return false;
            }

            if (Phone.Text.Contains(" "))
            {
                MessageBox.Show("TELEFON KUTUSUNU TAMAMEN DOLDURUNUZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Phone.Focus();
                return false;
            }

            #endregion PHONE

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

            #region ADRESSCONTROL

            if (string.IsNullOrEmpty(Adress.Text))
            {
                MessageBox.Show("ADRES METİN KUTUSU BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Adress.Focus();
                return false;
            }
            if (Adress.Text.Length < 8)
            {
                MessageBox.Show("ADRES METİN KUTUSU 8 KARAKTERDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Adress.Text = string.Empty;
                Adress.Focus();
                return false;
            }

            #endregion ADRESSCONTROL

            // Repetitive Control
            Connection.dbConnection.Open();
            SQLiteCommand cmd;
            if (string.IsNullOrEmpty(ID))
            {
                cmd = new("select TC,Phone,E_Mail,NameSurname from Tbl_Member where TC='" + TC.Text + "' or Phone='" + Phone.Text + "' or E_Mail='" + Email.Text + "' or NameSurname='" + NameSurname.Text + "'", Connection.dbConnection);
            }
            else
            {
                cmd = new("select TC,Phone,E_Mail,NameSurname from Tbl_Member where ID <> " + ID + "", Connection.dbConnection);
            }
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0] as string == TC.Text)
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTENEN TC DAHA ÖNCEDEN BAŞKA BİR ÜYEYE  TANIMLANMIŞTIR", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TC.Focus();
                    rd.Close();
                    Connection.dbConnection.Close();
                    return false;
                }
                else if (rd[1] as string == Phone.Text)
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTENEN TELEFON DAHA ÖNCEDEN BAŞKA BİR ÜYEYE TANIMLANMIŞTIR", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Phone.Focus();
                    rd.Close();
                    Connection.dbConnection.Close();
                    return false;
                }
                else if (rd[2] as string == Email.Text || rd[2] as string == Email.Text.ToUpper() || rd[2] as string == Email.Text.ToLower())
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTENEN E-MAİL DAHA ÖNCEDEN BAŞKA BİR ÜYEYE TANIMLANMIŞTIR", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Focus();
                    rd.Close();
                    Connection.dbConnection.Close();
                    return false;
                }
                else if (rd[3] as string == NameSurname.Text || rd[3] as string == NameSurname.Text.ToUpper() || rd[3] as string == NameSurname.Text.ToLower())
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTENEN ÜYE İSMİ DAHA ÖNCEDEN BAŞKA BİR ÜYEYE TANIMLANMIŞTIR", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameSurname.Focus();
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