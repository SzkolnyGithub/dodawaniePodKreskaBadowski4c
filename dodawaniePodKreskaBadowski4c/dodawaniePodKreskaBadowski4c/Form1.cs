using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dodawaniePodKreskaBadowski4c
{
    public partial class Form1 : Form
    {
        int[] liczby = new int[10];
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int temp = rand.Next(0, 9);
                liczby[i] = temp;
            }
            string licz1 = "";
            string licz2 = "";
            for (int i = 0; i < 10; i++)
            {
                if (i < 4)
                {
                    licz1 += liczby[i] + "   ";
                } else if (i == 4)
                {
                    licz1 += liczby[i];
                } else if (i < 10)
                {
                    licz2 += liczby[i] + "   ";
                } else if (i == 10)
                {
                    licz2 += liczby[i];
                }
            }
            liczba1.Text = licz1;
            liczba2.Text = licz2;
            l2.Enabled = false;
            l3.Enabled = false;
            l4.Enabled = false;
            l5.Enabled = false;
            l6.Enabled = false;
            p2.Enabled = false;
            p3.Enabled = false;
            p4.Enabled = false;
            p5.Enabled = false;
            //label1.Text = liczby[4] + " " + liczby[9];
        }
        private void checker1()
        {
            int suma = liczby[4] + liczby[9];
            if (suma % 9 == Convert.ToInt32(l1.Text) && (suma / 9).ToString() == p1.Text)
            {
                l2.Enabled = true;
                p2.Enabled = true;
            }
        }
        private void l1_TextChanged(object sender, EventArgs e)
        {
            checker1();
        }
        private void p1_TextChanged(object sender, EventArgs e)
        {
            checker1();
        }


        private void l1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void l2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void l3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void l4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void l5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void l6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void p1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void p2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void p3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void p4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }

        private void p5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.ToolTipTitle = "Błąd wprowadzania";
            t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000);
        }
        private void b1_Click(object sender, EventArgs e)
        {

        }

    }
}
