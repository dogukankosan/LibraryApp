using KutuphaneOtomasyonu.Class;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_Chart : Form
    {
        public frm_Chart()
        {
            InitializeComponent();
        }
        internal string sql = default;
        private readonly FolderBrowserDialog fr = new();
        void List(string sql)
        {
            Connection.dbConnection.Open();
            SQLiteCommand cmd = new(sql, Connection.dbConnection);
            try
            {
                SQLiteDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    chartControl1.Series[0].Points.AddPoint(rd[0].ToString(), (long)rd[1]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Connection.dbConnection.Close();
        }
        private void frm_Chart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "Chart.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "Chart.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.ChartExport(chartControl1, fr.SelectedPath, "Chart.html");
        }
        private void frm_Chart_Load(object sender, EventArgs e)
        {
            List(sql);
        }
    }
}