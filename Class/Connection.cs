using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class Connection
    {
        internal static readonly SQLiteConnection dbConnection = new($"Data source={Application.StartupPath}\\Database\\LibraryDb.db;Versiyon=3");
        internal static void Backup(string strDestination)
        {
            using (var location = new SQLiteConnection($"Data source={Application.StartupPath}\\Database\\LibraryDb.db;Versiyon=3"))
            using (var destination = new SQLiteConnection(string.Format(@"Data Source={0}\\LibraryDbBackup.db; Version=3;", strDestination)))
            {
                location.Open();
                destination.Open();
                location.BackupDatabase(destination, "main", "main", -1, null, 0);
            }
        }
    }
}