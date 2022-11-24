using System;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class GeneralCrud
    {
        internal static ArrayList TextBoxList(string sql)
        {
            ArrayList lst = new();
            Connection.dbConnection.Open();
            SQLiteCommand cmd = new(sql, Connection.dbConnection);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lst.Add(rd["TC"].ToString());
                lst.Add(rd["NameSurname"].ToString());
                lst.Add(rd["Birthday"].ToString());
                lst.Add(rd["Gender"].ToString());
                lst.Add(rd["Phone"].ToString());
                lst.Add(rd["Adress"].ToString());
                lst.Add(rd["E_Mail"].ToString());
                lst.Add(rd["Picture"].ToString());
                lst.Add(rd["Password"].ToString());
            }
            Connection.dbConnection.Close();
            return lst;
        }

        internal static bool IDU(string sql)
        {
            Connection.dbConnection.Open();
            SQLiteCommand cmd = new(sql, Connection.dbConnection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "HATALI DATABASE İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.dbConnection.Close();
                return false;
            }
            Connection.dbConnection.Close();
            return true;
        }

        internal static DataTable List(string sql)
        {
            SQLiteDataAdapter da = new(sql, Connection.dbConnection);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }
    }
}