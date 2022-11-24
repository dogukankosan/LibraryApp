using KutuphaneOtomasyonu.Class;
using System.IO;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Forms
{
    public partial class frm_Settings : Form
    {
        public frm_Settings()
        {
            InitializeComponent();
        }
        private void UpdatePunishment()
        {
            StreamWriter writer = new($"{Application.StartupPath}\\Import\\Punishment.txt");
            writer.WriteLine(Encription.Enc(numericUpDown1.Text));
            writer.Close();
            MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void List()
        {
            StreamReader writer = new($"{Application.StartupPath}\\Import\\Punishment.txt");
            string satir = string.Empty;
            while (true)
            {
                satir = writer.ReadLine();
                if (satir == null)
                    break;
                numericUpDown1.Value = decimal.Parse(Encription.Desc(satir));
            }
            writer.Close();
        }
        private void frm_Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.F5)
                UpdatePunishment();
        }
        private void Btn_Update_Click(object sender, System.EventArgs e)
        {
            UpdatePunishment();
        }
        private void frm_Settings_Load(object sender, System.EventArgs e)
        {
            List();
        }
    }
}