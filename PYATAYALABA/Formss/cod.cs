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
    public partial class cod : Form
    {
        public static izmenparol haha;
        public static vosstan izm;
        public Users users;
        public cod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Convert.ToString(izm.pasik))
            {
                izmenparol hehe = new izmenparol();
                hehe.users = users;
                this.Close();
                hehe.Show();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void cod_Load(object sender, EventArgs e)
        {

        }
    }
}
