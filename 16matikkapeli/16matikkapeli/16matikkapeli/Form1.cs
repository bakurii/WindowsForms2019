using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16matikkapeli
{
    public partial class Form1 : Form
    {        
        //FormPisteet pisteForm;
        int oikein;

        public int Oikein { get => oikein; set => oikein = value; }

        private void PisteNappi_Click(object sender, EventArgs e)//Pisteet ja piste laskuri
        {           
            //MessageBox.Show(oikein.ToString());
            using (var pisteForm = new FormPisteet(this))
            {
                pisteForm.ShowDialog();
            }       
        }

        private void PoistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PlusNappi_Click(object sender, EventArgs e)
        {
            using(var form2 = new PlusLasku(this))
            {
                form2.ShowDialog();
            }            
        }

        public Form1()
        {
            InitializeComponent();                      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MiinusNappi_Click(object sender, EventArgs e)
        {
            using (var form3 = new Miinus(this))
            {
                form3.ShowDialog();
            }
        }

        private void KertoNappi_Click(object sender, EventArgs e)
        {
            using (var form4 = new Kerto(this))
            {
                form4.ShowDialog();
            }
        }

        private void JakoNappi_Click(object sender, EventArgs e)
        {
            using (var form5 = new Jako(this))
            {
                form5.ShowDialog();
            }
        }
    }
}
