using PYATAYALABA.Formss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYATAYALABA
{
    public partial class poplnit : Form
    {
        private char[] summa;
        private UserData users;
        public static Osnova osnova;
        public poplnit(UserData users)
        {
            InitializeComponent();
            this.users = users;
            textBox3.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Нечего стирать");
            }
            else
            {
                summa = textBox3.Text.ToCharArray();
                summa[summa.Length - 1] = '\0';
                textBox3.Text = new string(summa);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                using (EntityModelContainer db = new EntityModelContainer())
                {
                    db.BalanceSet.Find(users.Balance.ToList()[0].Id).Summa = Convert.ToString(Convert.ToInt32(users.Balance.ToList()[0].Summa) + Convert.ToInt32(textBox3.Text));
                    db.SaveChanges();
                    osnova.label5.Text = db.BalanceSet.Find(users.Balance.ToList()[0].Id).Summa;
                    MessageBox.Show("Пополнено!");
                    this.Close();
                    return;

                }
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text += "3";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text += "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text += "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text += "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text += "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text += "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void poplnit_Load(object sender, EventArgs e)
        {
            Osnova.popa = this;
        }
    }
}
