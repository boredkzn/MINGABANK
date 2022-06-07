using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYATAYALABA.Formss
{
    public partial class Ipoteka : Form
    {
        
        public Ipoteka()
        {
            InitializeComponent();
        }

        private void lenta_Scroll(object sender, EventArgs e)
        {
            info.Text = Convert.ToString(lenta.Value);
        }

        private void loginKnopka_Click(object sender, EventArgs e)
        {
            try
            {
                var summa = Convert.ToUInt64(info.Text);
                var srok = Convert.ToUInt16(textBox1.Text);
                var stavka = Convert.ToDouble(textBox2.Text) / 12 / 100;
                var obstavka = Math.Pow((1 + stavka), srok);
                var plata = summa * stavka * obstavka / (obstavka - 1);
                textBox3.Text = Math.Round(plata, 2).ToString();
            }
            catch
            {
                MessageBox.Show("Введите данные");
            }
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
