using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moja2WindowsAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIzracun_Click(object sender, EventArgs e)
        {
            int brojA, brojB, zbroj = 0, iznimka = 1;
            try
            {
                brojA = Convert.ToInt32(unosBrojaA.Text);
                zbroj = brojA;
            }
            catch
            {
                unosBrojaA.Text = "Pogrešan unos, upišite broj";
                iznimka = 0;
            }
            try
            {
                brojB = Convert.ToInt32(unosBrojaB.Text);
                zbroj += brojB;
            }
            catch
            {
                unosBrojaB.Text = "Pogrešan unos, upišite broj";
                iznimka = 0;
            }
            

            rezultat.Text = "" + (zbroj * iznimka);
        }

        private void unosBrojaB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
