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
    public partial class account : Form
    {
        
        public Users users;
        
        public account()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void account_Load(object sender, EventArgs e)
        {
            label3.Text = users.Name;
            label4.Text = users.Surname;
        }
    }
}
