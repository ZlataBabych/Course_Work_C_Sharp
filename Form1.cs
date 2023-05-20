using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Course_work_4_semestr
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\Zlata\\C#\\portret.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            double x = 0;
            double xmin = 0, dx = 0, xmax = 0;
            double f = 0;
            uint count_f1 = 0, count_f2 = 0;
            double q = 0;
            Random random = new Random();

            try
            {
                xmin = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid value entered in xmin");
            }

            try
            {
                dx = Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid value entered in dx");
            }

            try
            {
                xmax = Convert.ToDouble(textBox3.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid value entered in xmax");
            }

            if (xmin < xmax && dx > 0)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                for (x = xmin; x <= xmax; x += dx)
                {
                    q = random.NextDouble();
                    label4.Text = $"q = {q}";
                    if (q > 0 && q <= 0.4)
                    {
                        count_f1++;
                        if (Math.Tan(q * x) > 0)
                        {
                            f = Math.Log(Math.Tan(q * x));
                            listBox1.Items.Add("x = " + x.ToString() + " f = " + f.ToString());
                        }
                        else
                            listBox1.Items.Add("It is`t possible to calculate function for x = " + x.ToString());
                    }
                    else if (0.4 < q && q <= 1)
                    {
                        count_f2++;
                        if (x != 0.0 && ((Math.Sin(q * x) / x) >= 0))
                        {
                            f = Math.Sqrt(Math.Sin(q * x) / x);
                            listBox2.Items.Add("x = " + x.ToString() + " f = " + f.ToString());
                        }
                        else
                            listBox2.Items.Add("It is`t possible to calculate function for x = " + x.ToString());

                    }
                }
                label9.Text = "The number of calculations using the formula f1(x) = " + Convert.ToString(count_f1);
                label10.Text = "The number of calculations using the formula f2(x) = " + Convert.ToString(count_f2);
            }
            else
            {
                MessageBox.Show("Error!\nCheck the correctness of the input:\nxmin < xmax\ndx > 0");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}


