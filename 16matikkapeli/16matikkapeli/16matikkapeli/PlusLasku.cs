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
    public partial class PlusLasku : Form
    {
        public Form1 form1;

        Random rnd = new Random();
        int num1, num2, num3, vastaus, kiekka = 1;
        int oikein;

        public PlusLasku(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void PoistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)//ensimäinen kierros ja numerot
        {
            f2kierros.Text = kiekka.ToString();

            num1 = rnd.Next(1, 100);//arvotaan numerot laskuriin.
            num2 = rnd.Next(1, 100);

            f21Numero.Text = num1.ToString();//tulostetaan numerot formiin.
            f22Numero.Text = num2.ToString();        
        }

        private void F2uusiNum_Click(object sender, EventArgs e)//loput kierrokset uusi numero nappulasta.
        {
            kiekka = kiekka + 1;
            f2kierros.Text = kiekka.ToString();

            f2textbox.Clear();
            num1 = rnd.Next(1, 100);//arvotaan numerot laskuriin.
            num2 = rnd.Next(1, 100);

            f21Numero.Text = num1.ToString();//tulostetaan numerot formiin.
            f22Numero.Text = num2.ToString();               
        }

        private void F2vastausNappi_Click(object sender, EventArgs e)
        {
            vastaus = int.Parse(f2textbox.Text);//luetaaan käyttäjän vastaus ja talletetaan muuttujaan vertaamista varten.

            num3 = num1 + num2;
            if (num3 == vastaus)
            {
                f2vastaus.Text = "Oikein!!";
                form1.Oikein++;
                f2vastaus.BackColor = Color.Magenta;
            }

            else
            {
                f2vastaus.Text = "Väärin!";
            }
            
        }
    }
}
