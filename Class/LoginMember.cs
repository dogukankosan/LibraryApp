using System.Data.SQLite;

namespace KutuphaneOtomasyonu.Class
{
    internal class LoginMember
    {
        //LOGIN USER INFO
        internal string E_Mail = default;

        internal string Password = default;
        internal static string ID = default;
        internal static string IsMember = "1";

        //LOGIN DB VALUES CONTROL
        internal static string DbValues(string _email)
        {
            string password = default;
            Connection.dbConnection.Open();
            SQLiteCommand cmd = new("select E_Mail,Password from Tbl_Member", Connection.dbConnection);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0] as string == _email)
                {
                    password = Encription.Desc(rd[1] as string);
                    rd.Close();
                    Connection.dbConnection.Close();
                    return password;
                }
            }
            Connection.dbConnection.Close();
            return null;
        }

        internal static bool DbValuesBool(string _email, string _password)
        {
            Connection.dbConnection.Open();
            SQLiteCommand cmd = new("select E_Mail,Password,IsMember,ID from Tbl_Member", Connection.dbConnection);
            SQLiteDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[0] as string == _email && rd[1] as string == Encription.Enc(_password))
                {
                    LoginMember.ID = rd[3].ToString();
                    LoginMember.IsMember = rd[2].ToString();
                    Connection.dbConnection.Close();
                    return true;
                }
            }
            Connection.dbConnection.Close();
            return false;
        }
    }
}