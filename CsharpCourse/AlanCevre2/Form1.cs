using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanCevre2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblgizli1.Hide();
            lblgizli2.Hide();
            lblgizli3.Hide();

            txtgizli1.Hide();
            txtgizli2.Hide();
            txtgizli3.Hide();
        }


        private void checkUcgen_CheckedChanged(object sender, EventArgs e)
        {
           

            if (checkAlan.Checked) 
            {
                lblgizli1.Show();
                lblgizli2.Show();
                txtgizli1.Show();
                txtgizli2.Show();

                lblgizli1.Text = "Yükseklik";
                lblgizli2.Text = "Taban";
            }

            if (checkCevre.Checked) 
            {
                lblgizli1.Show();
                lblgizli2.Show();
                lblgizli3.Show();
                txtgizli1.Show();
                txtgizli2.Show();
                txtgizli3.Show();

                lblgizli1.Text = "1. Kenar";
                lblgizli2.Text = "2. Kenar";
                lblgizli3.Text = "2. Kenar";


            }
            
            
                    
           
        }
    }
}
