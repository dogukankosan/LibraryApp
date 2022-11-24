using DevExpress.XtraGrid.Views.Grid;
using System;
using System.IO;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Class
{
    internal class Punishment
    {
        private static string punishmet { get; set; }
        internal static bool PunisDb(GridView gridView1, string ID)
        {
            try
            {
                StreamReader writer = new($"{Application.StartupPath}\\Import\\Punishment.txt");
                string satir = string.Empty;
                while (true)
                {
                    satir = writer.ReadLine();
                    if (satir == null)
                        break;
                    punishmet = Encription.Desc(satir);
                }
                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "METİN OKUMA HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime thisDate1 = DateTime.Now;
            DateTime dt2 = DateTime.Parse(gridView1.GetFocusedRowCellValue("TESLIM_TARIHI").ToString());
            double balance = default;
            string dbBalance = default;
            try
            {
                balance = thisDate1.Subtract(dt2).Days * double.Parse(punishmet);
                dbBalance = balance.ToString().Replace(',', '.');
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "İADE İŞLEMİ HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (GeneralCrud.IDU("update tbl_member set Balance=Balance - " + dbBalance + " where ID=" + ID + ""))
            {
                MessageBox.Show($"ÜYEYE {balance} ₺ TUTARINDA CEZA UYGULANMIŞTIR !!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                MessageBox.Show("ÜYEYE CEZA UYGULAMA İŞLEMİ HATALI KONTROL EDİNİZ !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}