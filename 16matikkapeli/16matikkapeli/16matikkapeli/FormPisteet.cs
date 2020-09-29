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
    public partial class FormPisteet : Form
    {
        public Form1 form1;
        int points;

        public FormPisteet(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FormPisteet_Load(object sender, EventArgs e)
        {
            points = form1.Oikein;//tänne tulee numero
            pisteet.Text = points.ToString();

            if(points < 5)
            {
                saavutus1.Text = "Liian vähän pisteitä";
            }
            else if (points >= 5)
            {
                saavutus1.Text = "Sait keksin";
            }
            else if(points >= 10)
            {
                saavutus1.Text = "Sait kakkua";
            }
            else
            {
                saavutus1.Text = "Olet aivan mahtava!!";
            }

        }
    }
}
