using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class BookControl
    {
        internal static bool ControlBook(MaskedTextBox barcode, TextBox bookName, TextBox writer, ComboBox publisher, NumericUpDown pageCount, ComboBox bookType, NumericUpDown stockCount, TextBox rackNo, string ID)
        {//RAFNOYA BAK
            #region BARCODE

            if (string.IsNullOrEmpty(barcode.Text))
            {
                MessageBox.Show("BARKOD NO BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barcode.Focus();
                return false;
            }
            if (barcode.Text.Length < 15)
            {
                MessageBox.Show("BARKOD NONUN TAMAMINI DOLDURUNUZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                barcode.Text = null;
                barcode.Focus();
                return false;
            }
            if (barcode.Text.Contains(" "))
            {
                MessageBox.Show("BARKOD NONUN TAMAMINI DOLDURUNUZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                barcode.Text = null;
                barcode.Focus();
                return false;
            }

            #endregion BARCODE

            #region BOOKNAME

            if (string.IsNullOrEmpty(bookName.Text))
            {
                MessageBox.Show("KİTAP ADI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookName.Focus();
                return false;
            }
            if (bookName.Text.Length < 3)
            {
                MessageBox.Show("KİTAP ADI 3 HANEDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookName.Text = null;
                bookName.Focus();
                return false;
            }

            #endregion BOOKNAME

            #region WRITER

            if (string.IsNullOrEmpty(writer.Text))
            {
                MessageBox.Show("YAZAR ADI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writer.Focus();
                return false;
            }
            if (writer.Text.Length < 5)
            {
                MessageBox.Show("YAZAR ADI 5 HANEDEN AZ OLAMAZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                writer.Text = null;
                writer.Focus();
                return false;
            }
            for (byte i = 0; i < writer.Text.Length; i++)
            {
                if (char.IsNumber(writer.Text[i]))
                {
                    MessageBox.Show("YAZAR ADINDA RAKAM OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    writer.Text = null;
                    writer.Focus();
                    return false;
                }
            }

            #endregion WRITER

            #region PUBLISHER

            if (string.IsNullOrEmpty(publisher.Text))
            {
                MessageBox.Show("YAYIN EVİ BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                publisher.Focus();
                return false;
            }

            #endregion PUBLISHER

            #region PAGECOUNT

            if (string.IsNullOrEmpty(pageCount.Text))
            {
                MessageBox.Show("KİTAP SAYISINI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                pageCount.Focus();
                return false;
            }
            for (byte i = 0; i < pageCount.Text.Length; i++)
            {
                if (!char.IsNumber(pageCount.Text[i]))
                {
                    MessageBox.Show("SAYFA SAYINDA RAKAM DIŞINDA KARAKTER BULUNAMAZ !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    pageCount.Text = 1.ToString();
                    pageCount.Focus();
                    return false;
                }
            }
            if (Convert.ToInt32(pageCount.Text) > 9999)
            {
                MessageBox.Show("SAYFA SAYISI 9999 DAN FAZLA OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                pageCount.Text = 1.ToString();
                pageCount.Focus();
                return false;
            }

            #endregion PAGECOUNT

            #region BOOKTYPE

            if (string.IsNullOrEmpty(bookType.Text))
            {
                MessageBox.Show("KİTAP TÜRÜ BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookType.Focus();
                return false;
            }

            #endregion BOOKTYPE

            #region STOCKCOUNT

            if (string.IsNullOrEmpty(stockCount.Text))
            {
                MessageBox.Show("STOK SAYISI BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                stockCount.Focus();
                return false;
            }
            for (byte i = 0; i < stockCount.Text.Length; i++)
            {
                if (!char.IsNumber(stockCount.Text[i]))
                {
                    MessageBox.Show("STOK SAYISI RAKAM DIŞINDA KARAKTER BULUNAMAZ !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    stockCount.Text = 1.ToString();
                    stockCount.Focus();
                    return false;
                }
            }
            if (Convert.ToInt32(stockCount.Text) > 100)
            {
                MessageBox.Show("STOK SAYISI 100 DAN FAZLA OLAMAZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                stockCount.Text = 1.ToString();
                stockCount.Focus();
                return false;
            }

            #endregion STOCKCOUNT

            #region RACKNO

            if (string.IsNullOrEmpty(rackNo.Text))
            {
                MessageBox.Show("RAF NO BOŞ GEÇİLEMEZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rackNo.Focus();
                return false;
            }

            #endregion RACKNO

            #region BARCODECONTROL

            Connection.dbConnection.Open();
            SQLiteCommand cmd;
            SQLiteDataReader rd;
            if (string.IsNullOrEmpty(ID))
            {
                cmd = new("select BarcodeNo from Tbl_Book where BarcodeNo='" + barcode.Text + "' ", Connection.dbConnection);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTEDEĞİNİZ BARCODE DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    barcode.Focus();
                    rd.Close();
                    Connection.dbConnection.Close();
                    return false;
                }
            }
            else
            {
                cmd = new("select BarcodeNo from Tbl_Book where ID <> " + ID + "", Connection.dbConnection);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (barcode.Text.Equals(rd[0]))
                    {
                        MessageBox.Show("GÜNCELLEMEK İSTEDEĞİNİZ BARCODE DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        barcode.Focus();
                        rd.Close();
                        Connection.dbConnection.Close();
                        return false;
                    }
                }
            }
            Connection.dbConnection.Close();

            #endregion BARCODECONTROL

            #region BOOKCONTROL

            Connection.dbConnection.Open();
            SQLiteCommand cmd2;
            SQLiteDataReader rd2;
            if (string.IsNullOrEmpty(ID))
            {
                cmd2 = new("select BookName from Tbl_Book where BookName='" + bookName.Text + "' ", Connection.dbConnection);
                rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    MessageBox.Show("KAYIT EDİLMEK İSTEDEĞİNİZ KİTAP ADI DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bookName.Focus();
                    rd2.Close();
                    Connection.dbConnection.Close();
                    return false;
                }
            }
            else
            {
                cmd2 = new("select BookName from Tbl_Book where ID <> " + ID + "", Connection.dbConnection);
                rd2 = cmd2.ExecuteReader();
                while (rd2.Read())
                {
                    if (bookName.Text.Equals(rd2[0]) || bookName.Text.ToUpper().Equals(rd2[0]) || bookName.Text.ToLower().Equals(rd2[0]))
                    {
                        MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ KİTAP ADI DAHA ÖNCEDEN TANIMLANMIŞTIR !!", "HATALI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bookName.Focus();
                        rd2.Close();
                        Connection.dbConnection.Close();
                        return false;
                    }
                }
            }
            Connection.dbConnection.Close();

            #endregion BOOKCONTROL

            return true;
        }
    }
}