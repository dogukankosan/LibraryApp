using KutuphaneOtomasyonu.Class;
using System;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_OrderFiche : Form
    {
        public frm_OrderFiche()
        {
            InitializeComponent();
        }
        private bool values = default;
        private void Clear()
        {
            Rch_Desc.Text = null;
            Dt_Delivery.Value = DateTime.Now;
            Dt_Purchase.Value = DateTime.Now;
            Lk_Member.Enabled = false;
            values = false;
            Lk_Book.EditValue = null;
        }
        private void ComboList()
        {
            Lk_Book.Properties.DataSource = GeneralCrud.List("select ID,BookName as 'KITAP_ADI',Tbl_Book.Writer AS 'YAZAR_ADI',BarcodeNo AS 'BARKOD_NO' from Tbl_Book where StockCount>0");
            Lk_Member.Properties.DataSource = GeneralCrud.List("select ID,NameSurname as 'AD_SOYAD',Tbl_Member.TC,Tbl_Member.Balance AS 'BORC',Tbl_Member.ReadBooksCount as 'OKUNAN_KITAP' from Tbl_Member");
            Lk_Book.Properties.DisplayMember = "KITAP_ADI";
            Lk_Book.Properties.ValueMember = "ID";
            Lk_Member.Properties.DisplayMember = "AD_SOYAD";
            Lk_Member.Properties.ValueMember = "ID";
            Lk_Book.Text = null;
            Lk_Member.Text = null;
        }
        private void Add()
        {
            if (dataGridView1.RowCount > 0)
            {
                if (MessageBox.Show("EMANET KİTAP VERMEK İSTİYOR MUSUNUZ ?", "EMANET KİTAP İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (byte i = 0; i < dataGridView1.RowCount; i++)
                    {
                        values = GeneralCrud.IDU(
                            "insert into Tbl_OrderFich (BookID,MemberID,Purchase_Date,Delivery_Date,Description) values (" +
                            dataGridView1.Rows[i].Cells[5].Value + "," + dataGridView1.Rows[i].Cells[6].Value + ",'" +
                            dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value +
                            "','" + dataGridView1.Rows[i].Cells[4].Value + "')");
                    }
                    if (values)
                    {
                        MessageBox.Show("EMANET KİTAP VERME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        Lk_Member.EditValue = null;
                        Lk_Member.Enabled = true;
                        dataGridView1.Rows.Clear();
                    }
                    else
                        MessageBox.Show("EMANET KİTAP VERME İŞLEMİ HATALI !!", "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ComboList();
            }
            else
                MessageBox.Show("SATIR EKLENMEMİŞTİR ÖNCE SATIR EKLEYİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        private void frm_OrderFiche_Load(object sender, EventArgs e)
        {
            ComboList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }
        private void frm_OrderFiche_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                Add();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void Btn_RowAdd_Click(object sender, EventArgs e)
        {
            string DeliveryDate = string.Concat(Dt_Delivery.Value.Year.ToString(), '-', Dt_Delivery.Value.Month.ToString(), '-', Dt_Delivery.Value.Day.ToString());
            string PurchaseDate = string.Concat(Dt_Purchase.Value.Year.ToString(), '-', Dt_Purchase.Value.Month.ToString(), '-', Dt_Purchase.Value.Day.ToString());
            if (OrderConrol.Control(Lk_Member, Lk_Book, Dt_Purchase, Dt_Delivery))
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    dataGridView1.Rows.Add(Lk_Member.Text, Lk_Book.Text, PurchaseDate, DeliveryDate, Rch_Desc.Text, Lk_Book.EditValue, Lk_Member.EditValue);
                    Clear();
                    return;
                }
                for (byte i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[5].Value.Equals(Lk_Book.EditValue))
                        values = true;
                }
                if (values)
                {
                    MessageBox.Show("EMANET VERİLEN KİTAP DAHA ÖNCEDEN VERİLMİŞTİR !!", "HATALI", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    values = false;
                }
                else
                {
                    dataGridView1.Rows.Add(Lk_Member.Text, Lk_Book.Text, PurchaseDate, DeliveryDate, Rch_Desc.Text, Lk_Book.EditValue, Lk_Member.EditValue);
                    Clear();
                }
            }
        }
    }
}