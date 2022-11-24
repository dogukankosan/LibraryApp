using KutuphaneOtomasyonu.Class;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_GeneralMemberList : Form
    {
        public frm_GeneralMemberList()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new();
        internal string sql = default;
        private void frm_GeneralMemberList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GeneralCrud.List(sql);
        }
        private void frm_GeneralMemberList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Liste.xlsx");
        }
        private void pdfAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Liste.pdf");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "Liste.html");
        }
    }
}