using OgrenciSistemi.InsanTipleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSistemi
{
    public partial class Anasayfa : Form
    {

        private List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

        public Anasayfa()
        {
            InitializeComponent();

            gizli1label.Hide();
            gizli2label.Hide();
            gizli3label.Hide();

            textBoxGizli1.Hide();
            textBoxGizli2.Hide();
            textBoxGizli3.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (robotkontrolu.Checked)
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    Ogrenci gariban = new Ogrenci();

                    gariban.Isim = textBox1.Text;
                    gariban.Soyisim = textBox2.Text;
                    gariban.GNO = gizli1label.Text;
                    gariban.DersSayisi = gizli2label.Text;
                    gariban.Bolum = gizli3label.Text;

                    ogrenciListesi.Add(gariban);

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    FehmiDayi dayi = new FehmiDayi();

                    dayi.Isim = textBox1.Text;
                    dayi.Soyisim = textBox2.Text;
                    dayi.OsiloskobSayisi = gizli1label.Text;
                    dayi.PahaliProbMarkasi = gizli2label.Text;
                    dayi.LaboratuvarIsmi = gizli3label.Text;
                }
                else
                {
                    Akademisyen hocalar = new Akademisyen();

                    hocalar.Isim = textBox1.Text;
                    hocalar.Soyisim = textBox2.Text;
                    hocalar.VerdigiDersSayisi = gizli1label.Text;
                    hocalar.Maas = gizli2label.Text;
                    hocalar.ArabaMarkasi = gizli3label.Text;
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            gizli1label.Show();
            gizli2label.Show();
            gizli3label.Show();
            textBoxGizli1.Show();
            textBoxGizli2.Show();
            textBoxGizli3.Show();

            if (comboBox1.SelectedItem.ToString() == "Öğrenci")
            {

                gizli1label.Text = "Genel Not Ortalaması";
                gizli2label.Text = "Ders Sayısı";
                gizli3label.Text = "Bölüm";

            }
            else if (comboBox1.SelectedItem.ToString() == "Akademisyen")
            {

                gizli1label.Text = "Verdiği Ders Sayısı";
                gizli2label.Text = "Maaş";
                gizli3label.Text = "Araba Markası";

            }
            else
            {
                gizli1label.Text = "Osiloskob Sayisi";
                gizli2label.Text = "Pahalı Prob Sayısı";
                gizli3label.Text = "Laboratuvar Ismi";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            label4.Text = "";

            for (int i = 0; i < ogrenciListesi.Count; i++)
            {
                label4.Text = label4.Text + "\n" + ogrenciListesi[i].Isim;
            }

        }
    }
}
