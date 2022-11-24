using KutuphaneOtomasyonu.Class;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_ImageBookList : Form
    {
        public frm_ImageBookList()
        {
            InitializeComponent();
        }
        internal string images = default;
        private void frm_ImageBookList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void frm_ImageBookList_Load(object sender, System.EventArgs e)
        {
            pictureBox1.Image = ImageConvert.Base64ToImage(images);
        }
    }
}