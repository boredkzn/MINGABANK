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
            ulong summa = Convert.ToUInt64(info.Text);
            ushort srok = Convert.ToUInt16(textBox1.Text);
            double stavka = Convert.ToDouble(textBox2.Text);
            double plata = (summa + summa * stavka * srok / 100) / (srok * 12);
            textBox3.Text = "" + Math.Round(plata, 2);
            info.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
