using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol1_vyjimky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(textBox1.Text);
                int N = Convert.ToInt32(textBox2.Text);

                double vysledek = 1;

                if (N >= 0)
                {
                    for (int i = 0; i < N; i++)
                    {
                        vysledek *= A;
                    }
                }
                else
                {
                    for (int i = 0; i > N; i--)
                    {
                        vysledek *= A;
                    }

                    vysledek = 1 / vysledek;
                }

                MessageBox.Show(A + " na " + N + " je " + vysledek);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nezadal jsi číslo!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Zadal jsi moc velké číslo!");
            }
        }
    }
}
