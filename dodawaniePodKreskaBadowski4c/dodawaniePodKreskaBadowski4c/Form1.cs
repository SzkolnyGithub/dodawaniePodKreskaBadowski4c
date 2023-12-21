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
        private void przygotuj()
        {
            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = 0;
            }
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
                }
                else if (i == 4)
                {
                    licz1 += liczby[i];
                }
                else if (i < 10)
                {
                    licz2 += liczby[i] + "   ";
                }
                else if (i == 10)
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
            l1.Text = "";
            l2.Text = "";
            l3.Text = "";
            l4.Text = "";
            l5.Text = "";
            l6.Text = "";
            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            p4.Text = "";
            p5.Text = "";
            wynik.Text = "Oblicz wynik!";
            reset.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
            przygotuj();
            //label1.Text = liczby[4] + " " + liczby[9];
        }
        private void checker1()
        {
            if (l1.Text == null) { return; }
            if (l1.Text == "") { return; }
            if (p1.Text == null) { return; }
            if (p1.Text == "") { return; }

            int suma = liczby[4] + liczby[9];
            //wynik.Text = suma.ToString() + " " + suma % 9 + " " + suma / 9;
            if (suma % 9 == Convert.ToInt32(l1.Text) && (suma / 9).ToString() == p1.Text)
            {
                l2.Enabled = true;
                p2.Enabled = true;
            }
        }
        private void checker2()
        {
            if (l2.Text == null) { return; }
            if (l2.Text == "") { return; }
            if (p2.Text == null) { return; }
            if (p2.Text == "") { return; }

            int suma = liczby[3] + liczby[8] + Convert.ToInt32(p1.Text);
            //wynik.Text = suma.ToString() + " " + suma % 9 + " " + suma / 9;
            if (suma % 9 == Convert.ToInt32(l2.Text) && (suma / 9).ToString() == p2.Text)
            {
                l3.Enabled = true;
                p3.Enabled = true;
            }
        }
        private void checker3()
        {
            if (l3.Text == null) { return; }
            if (l3.Text == "") { return; }
            if (p3.Text == null) { return; }
            if (p3.Text == "") { return; }

            int suma = liczby[2] + liczby[7] + Convert.ToInt32(p2.Text);
            //wynik.Text = suma.ToString() + " " + suma % 9 + " " + suma / 9;
            if (suma % 9 == Convert.ToInt32(l3.Text) && (suma / 9).ToString() == p3.Text)
            {
                l4.Enabled = true;
                p4.Enabled = true;
            }
        }
        private void checker4()
        {
            if (l4.Text == null) { return; }
            if (l4.Text == "") { return; }
            if (p4.Text == null) { return; }
            if (p4.Text == "") { return; }

            int suma = liczby[1] + liczby[6] + Convert.ToInt32(p3.Text);
            //wynik.Text = suma.ToString() + " " + suma % 9 + " " + suma / 9;
            if (suma % 9 == Convert.ToInt32(l4.Text) && (suma / 9).ToString() == p4.Text)
            {
                l5.Enabled = true;
                p5.Enabled = true;
            }
        }
        private void checker5()
        {
            if (l5.Text == null) { return; }
            if (l5.Text == "") { return; }
            if (p5.Text == null) { return; }
            if (p5.Text == "") { return; }

            int suma = liczby[0] + liczby[5] + Convert.ToInt32(p4.Text);
            //wynik.Text = suma.ToString() + " " + suma % 9 + " " + suma / 9;
            if (suma % 9 == Convert.ToInt32(l5.Text) && (suma / 9).ToString() == p5.Text)
            {
                l6.Enabled = true;
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
        private void l2_TextChanged(object sender, EventArgs e)
        {
            checker2();
        }

        private void p2_TextChanged(object sender, EventArgs e)
        {
            checker2();
        }

        private void l3_TextChanged(object sender, EventArgs e)
        {
            checker3();
        }

        private void p3_TextChanged(object sender, EventArgs e)
        {
            checker3();
        }

        private void l4_TextChanged(object sender, EventArgs e)
        {
            checker4();
        }

        private void p4_TextChanged(object sender, EventArgs e)
        {
            checker4();
        }

        private void l5_TextChanged(object sender, EventArgs e)
        {
            checker5();
        }

        private void p5_TextChanged(object sender, EventArgs e)
        {
            checker5();
        }
        private void koniec(int jest)
        {
            if (jest == 1)
            {
                string Wynik = l5.Text + l4.Text + l3.Text + l2.Text + l1.Text;
                wynik.Text = "Udało ci się obliczyć działanie! Jest to : " + Wynik;
            }
            else
            {
                string Wynik = l6.Text + l5.Text + l4.Text + l3.Text + l2.Text + l1.Text;
                wynik.Text = "Udało ci się obliczyć działanie! Jest to : " + Wynik;
            }
            reset.Enabled = true;
        }
        private void l6_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(p5.Text) != 0)
            {
                if (l6.Text == p5.Text)
                {
                    koniec(0);
                }
            }
            else
            {
                if (l6.Text == p5.Text)
                {
                    koniec(1);
                }
            }
        }
        private void l1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void l2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void l3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void l4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void l5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void l6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void p1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void p2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void p3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void p4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void p5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { ToolTip t1 = new ToolTip(); t1.ToolTipTitle = "Błąd wprowadzania"; t1.Show("Wprowadź liczbę od 0 do 9", l1, 0, -20, 5000); }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //wynik.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gdi = e.Graphics; // 260, 230 punkt z lewej 445, 230 z prawej
            Pen Black = new Pen(Color.Black, 2);
            gdi.DrawLine(Black, 260, 230, 445, 230);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            przygotuj();
            Invalidate();
            Update();
        }
    }
}
