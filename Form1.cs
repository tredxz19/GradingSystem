using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradingsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)

        {
            try

            {

                double first = (Convert.ToDouble(textBox1.Text));
                double second = (Convert.ToDouble(textBox2.Text));
                double third = (Convert.ToDouble(textBox3.Text));
                double fourth = (Convert.ToDouble(textBox4.Text));

                double final = ((first + second + third + fourth) / 4);

                textBox5.Text = (Convert.ToString(final));



                if (final < 75)
                {
                    label6.Text = "You Is Failed" + " " + (final);
                }
                else
                {
                    label6.Text = "You Is Passed" + " " + (final);
                }
            }

            catch (Exception ex)
            {
                label6.Text = ex.Message;
                label6.Text = "Wrong Input Try Again";
            }










        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
