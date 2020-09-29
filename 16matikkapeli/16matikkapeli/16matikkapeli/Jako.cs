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
    public partial class Jako : Form
    {
        public Form1 form1;
        Random rnd = new Random();
        int num1, num2, num3, vastaus, kiekka = 1;

        private void F5uusiNum_Click(object sender, EventArgs e)
        {
            kiekka = kiekka + 1;
            f3kierros.Text = kiekka.ToString();

            f5textbox.Clear();

            num1 = rnd.Next(1, 100);
            num2 = rnd.Next(1, 100);


            f51Numero.Text = num1.ToString();//tulostetaan numerot formiin.
            f52Numero.Text = num2.ToString();
        }

        private void F5vastausNappi_Click(object sender, EventArgs e)
        {
            vastaus = int.Parse(f5textbox.Text);//luetaaan käyttäjän vastaus ja talletetaan muuttujaan vertaamista varten.
            num3 = num1 * num2;

            if (num3 == vastaus)
            {
                f4vastaus.Text = "Oikein!!";
                form1.Oikein++;
            }

            else
            {
                f4vastaus.Text = "Väärin!";
                f4vastaus.BackColor = Color.LightSeaGreen;
            }
        }

        public Jako(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Jako_Load(object sender, EventArgs e)
        {
            f3kierros.Text = kiekka.ToString();

            num1 = rnd.Next(1, 10);
            num2 = rnd.Next(1, 10);

            f51Numero.Text = num1.ToString();//tulostetaan numerot formiin.
            f52Numero.Text = num2.ToString();
        }
    }
}
