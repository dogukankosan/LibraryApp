using KutuphaneOtomasyonu.Class;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_Publisher : Form
    {
        public frm_Publisher()
        {
            InitializeComponent();
        }
        private readonly FolderBrowserDialog fr = new ();
        private string id = null;
        private void Add()
        {
            if (Publisher.ControlType(Txt_PublisherName, null))
            {
                if (MessageBox.Show("YAYİN EVİ KAYIT ETMEK İSTİYOR MUSUNUZ ?", "KAYIT İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GeneralCrud.IDU("insert into Tbl_Publisher (PublisherName) values ('" + Txt_PublisherName.Text.Trim() + "')"))
                    {
                        MessageBox.Show("YAYİN EVİ KAYIT İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Txt_PublisherName.Text = null;
                        id = null;
                        Txt_PublisherName.Focus();
                        gridControl1.DataSource = GeneralCrud.List("SELECT ID,PublisherName as 'YAYIN_EVI' FROM Tbl_Publisher order by PublisherName");
                    }
                }
            }
        }
        private void UpdatePublis()
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (Publisher.ControlType(Txt_PublisherName, id))
                {
                    if (MessageBox.Show("YAYİN EVİ GÜNCELLEMEK İSTİYOR MUSUNUZ ?", "GÜNCELLEME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (GeneralCrud.IDU("update Tbl_Publisher set PublisherName='" + Txt_PublisherName.Text.Trim() + "' where ID=" + id + ""))
                        {
                            MessageBox.Show("YAYİN EVİ GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Txt_PublisherName.Text = null;
                            Txt_PublisherName.Focus();
                            id = null;
                            gridControl1.DataSource = GeneralCrud.List("SELECT ID,PublisherName as 'YAYIN_EVI' FROM Tbl_Publisher order by PublisherName");
                        }
                    }
                }
            }
            else
                MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ KİTAP TÜRÜNÜ LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void frm_Publisher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                Add();
            else if (e.KeyCode == Keys.F5)
                UpdatePublis();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            UpdatePublis();
        }
        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                if (MessageBox.Show("SEÇİLEN YAYİN EVİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show(
                            "YAYIN EVİNİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ SİLERSENİZ YAYIN EVİNE BAĞLI VERİLMİŞ TÜM EMANET KİTAPLAR SİLİNECEKTİR VE KAYBOLACAKTIR EMİN MİSİNİZ?",
                            "SİLME İŞLEMİ",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (LoginAdmin.Password ==
                            Interaction.InputBox("SİLMEK İÇİN KAYDI GİRİŞ ŞİFRENİZİ YAZMANIZ GEREKİYOR !!",
                                "SİLME İŞLEMİ", null))
                        {
                            if (GeneralCrud.IDU("delete from Tbl_Publisher where ID=" + id + ""))
                            {
                                MessageBox.Show("YAYİN EVİ İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                Txt_PublisherName.Text = null;
                                Txt_PublisherName.Focus();
                                id = null;
                                gridControl1.DataSource = GeneralCrud.List("SELECT ID,PublisherName as 'YAYIN_EVI' FROM Tbl_Publisher order by PublisherName");
                            }
                        }
                        else
                            Interaction.MsgBox("SEÇİLİ YAYIN EVİ SİLİNEMEDİ !!", MsgBoxStyle.Critical, "HATALI");
                    }
                }
            }
            else
                MessageBox.Show("SİLMEK İSTEDİĞİNİZ YAYİN EVİ LİSTEDEN SEÇİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void Txt_PublisherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }
        private void frm_Publisher_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GeneralCrud.List("SELECT ID,PublisherName as 'YAYIN_EVI' FROM Tbl_Publisher order by PublisherName");
        }
        private void resimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "YayınEvi.html");
        }
        private void pDFAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "YayınEvi.pdf");
        }
        private void excelAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fr.ShowDialog() == DialogResult.OK)
                DataExport.GridExport(gridControl1, fr.SelectedPath, "YayınEvi.xlsx");
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                id = gridView1.GetFocusedRowCellValue("ID").ToString();
                Txt_PublisherName.Text = gridView1.GetFocusedRowCellValue("YAYIN_EVI").ToString();
            }
            catch (Exception)
            {
            
            }
        }
    }
}