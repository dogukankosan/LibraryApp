using KutuphaneOtomasyonu.Class;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_BookAdd : Form
    {
        public frm_BookAdd()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            if (MessageBox.Show("MESAJ KUTULARIN TAMAMI TEMİZLENECEKTİR EMİN MİSİNİZ ?", "TEMİZLEME",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = null;
                }
                Rch_Description.Text = null;
                Cmb_Publisher.Text = null;
                Cbm_BookType.Text = null;
                Msk_BarcodeNo.Text = null;
                nmr_PageCount.Text = 1.ToString();
                nmr_StockCount.Text = 1.ToString();
                pictureEdit1.Image = null;
                Msk_BarcodeNo.Focus();
            }
        }
        private void Add()
        {
            if (BookControl.ControlBook(Msk_BarcodeNo, Txt_BookName, Txt_Writer, Cmb_Publisher, nmr_PageCount, Cbm_BookType, nmr_StockCount, Txt_RackNo, null))
            {
                if (MessageBox.Show("KİTAP KAYIT ETMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "KAYIT İŞLEMİ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (GeneralCrud.IDU("insert into Tbl_Book (BarcodeNo,BookName,Writer,PublisherID,PageCount,BookTypeID,StockCount,RackNo,Description,_Date,_Picture) values ('" + Msk_BarcodeNo.Text.Trim() + "','" + Txt_BookName.Text.Trim() + "','" + Txt_Writer.Text.Trim() + "'," + Cmb_Publisher.SelectedValue + "," + nmr_PageCount.Value + "," + Cbm_BookType.SelectedValue + "," + nmr_StockCount.Value + ",'" + Txt_RackNo.Text.Trim() + "','" + Rch_Description.Text.Trim() + "','" + DateTime.Now + "','" + ImageConvert.ImageToBase64(pictureEdit1.Image, ImageFormat.Jpeg) + "')"))
                    {
                        MessageBox.Show("KİTAP EKLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        Msk_BarcodeNo.Focus();
                    }
                }
            }
        }
        private void frm_BookAdd_Load(object sender, System.EventArgs e)
        {
            Cbm_BookType.DataSource = GeneralCrud.List("SELECT * FROM Tbl_TypeBook ");
            Cbm_BookType.DisplayMember = "BookType";
            Cbm_BookType.ValueMember = "ID";
            Cmb_Publisher.DataSource = GeneralCrud.List("SELECT * FROM Tbl_Publisher ");
            Cmb_Publisher.DisplayMember = "PublisherName";
            Cmb_Publisher.ValueMember = "ID";
            Cmb_Publisher.Text = null;
            Cbm_BookType.Text = null;
        }
        private void frm_BookAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F2)
                Add();
            else if (e.KeyCode == Keys.F3)
                Clear();
        }
        private void Txt_Writer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }
        private void Btn_Clear_Click(object sender, System.EventArgs e)
        {
            Clear();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}