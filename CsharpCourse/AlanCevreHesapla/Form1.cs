using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanCevreHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabuton_Click(object sender, EventArgs e)
        {
            int kisaKenar, uzunKenar, sonuc = 0;
            kisaKenar = Convert.ToInt32(txtKisaKenar.Text);
            uzunKenar = Convert.ToInt32(txtUzunKenar.Text);

            if (checkAlan.Checked)
                sonuc = kisaKenar * uzunKenar;
            else if (checkCevre.Checked)
                sonuc = 2 * (kisaKenar + uzunKenar);
            else
                MessageBox.Show("Lütfen seçim yapınız.");

            AlanCevreSonuc.Text = "Sonuç : " + sonuc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
