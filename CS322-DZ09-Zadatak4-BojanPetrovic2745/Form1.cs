using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_DZ09_Zadatak4_BojanPetrovic2745
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int velicina = Convert.ToInt32(tbNizDuz.Text);
            int sum = 0;
            
            int[] niz = new int[velicina];

            Random rnd = new Random();

            for (int i = 0; i < velicina; i++)
            {
                niz[i] = rnd.Next(1, velicina);
                listBox1.Items.Add(niz[i]);
            }

            sum = niz.Sum();

            int min = niz[0];
            
            // suma niza
            lblZbir.Text = sum.ToString();

            // srednja vrednost niza
            lblSrednja.Text = (sum / velicina).ToString();

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] < min)
                {
                    min = niz[i];
                }
            }

            lblMin.Text = min.ToString();

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] > min)
                {
                    min = niz[i];
                }
                
            }

            lblMax.Text = min.ToString();


        }
    }
}
