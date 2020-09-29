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
    public partial class Miinus : Form
    {
        public Form1 form1;
        Random rnd = new Random();
        int num1, num2, num3, vastaus, kiekka = 1;

        private void F3uusiNum_Click(object sender, EventArgs e)
        {
            kiekka = kiekka + 1;
            f3kierros.Text = kiekka.ToString();

            f3textbox.Clear();

            num1 = rnd.Next(1, 100);
            num2 = rnd.Next(1, 100);


            f31Numero.Text = num1.ToString();//tulostetaan numerot formiin.
            f32Numero.Text = num2.ToString();
        }

        private void F3vastausNappi_Click(object sender, EventArgs e)
        {
            vastaus = int.Parse(f3textbox.Text);//luetaaan käyttäjän vastaus ja talletetaan muuttujaan vertaamista varten.
            num3 = num1 - num2;

            if (num3 == vastaus)
            {
                f3vastaus.Text = "Oikein!!";
                form1.Oikein++;
                f3vastaus.BackColor = Color.Honeydew;
            }

            else
            {
                f3vastaus.Text = "Väärin!";
            }
        }

        public Miinus(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form3_Load(object sender, EventArgs e)//kun osio aukeaa saa käyttäjä suoraan ensimäisen laskun laskettavaksi
        {
            f3kierros.Text = kiekka.ToString();   

            num1 = rnd.Next(1, 100);
            num2 = rnd.Next(1, 100);

            f31Numero.Text = num1.ToString();//tulostetaan numerot formiin.
            f32Numero.Text = num2.ToString();
        }
    }
}
