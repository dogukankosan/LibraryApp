using KutuphaneOtomasyonu.Class;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_Sql : Form
    {
        public frm_Sql()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new ();
        private void SQL(string sql)
        {
            if (sql.ToUpper().Contains("SELECT"))
            {
                try
                {
                    SQLiteDataAdapter da = new(sql, Connection.dbConnection);
                    DataTable ds = new();
                    da.Fill(ds);
                    gridControl1.DataSource = ds;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("SQL CÜMLESİ SELECT DIŞINDA BİR SORGU ÇALIŞTIRILIYOR EMİN MİSİNİZ ?", "SQL CÜMLESİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (LoginAdmin.Password == Interaction.InputBox("ADMİN GİRİŞ ŞİFREİNİZİ GİRİNİZ", "SQL CÜMLESİ", null))
                    {
                        Connection.dbConnection.Open();
                        SQLiteCommand cmd = new(sql, Connection.dbConnection);
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Connection.dbConnection.Close();
                        MessageBox.Show("SORGU BAŞARILI BİR ŞEKİLDE ÇALIŞTIRILDI", "SQL CÜMLESİ", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                        Interaction.MsgBox("HATALI ŞİFRE GİRİŞİ SQL CÜMLESİ ÇALIŞTIRILMADI", MsgBoxStyle.Critical,
                            "HATALI");
                }
            }
        }
        private void frm_Sql_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                SQL(Rctxt_SQL.Text);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void frm_Sql_Load(object sender, System.EventArgs e)
        {

        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "SQL.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "SQL.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "SQL.html");
        }
    }
}