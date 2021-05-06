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
    public partial class fond : Form
    {
        public UserData users;
        public static Osnova osnova;
        public fond(UserData users)
        {
            InitializeComponent();
            this.users = users;
          
        }

        private void l1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textSUM.Text) > 0 || textSUM.Text != "")
            {
                using (EntityModelContainer db = new EntityModelContainer())
                {


                    //db.BalanceSet.ToList()[i].Summa = Convert.ToString(Convert.ToInt32(db.BalanceSet.ToList()[i].Summa) + Convert.ToInt32(textBox1.Text));

                    db.BalanceSet.Find(users.Balance.ToList()[0].Id).Summa = Convert.ToString(Convert.ToInt32(users.Balance.ToList()[0].Summa) - Convert.ToInt32(textSUM.Text));
                    db.SaveChanges();
                    osnova.label5.Text = db.BalanceSet.Find(users.Balance.ToList()[0].Id).Summa;
                    MessageBox.Show("Храни вас Господь!");
                    this.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Неверный формат");
            }
        }
            

        public void fond_Load(object sender, EventArgs e)
        {
            Osnova.fondhab = this;
        }
    }
}
