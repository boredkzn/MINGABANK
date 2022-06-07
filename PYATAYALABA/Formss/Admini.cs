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
    
    public partial class Admini : Form
    {
        public static Form1 admini;
        public static Form2 form22;
        public Admini()
        {
            InitializeComponent();
            using (EntityModelContainer us = new EntityModelContainer())
            {
                foreach (UserData users in us.UserDataSet.ToList())
                {
                    listBox1.Items.Add(users.Login);
                    
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
            
        }
        public void UpdateListBox()
        {
            listBox1.Items.Clear();
            using (EntityModelContainer db = new EntityModelContainer())
            {
                for (int i = 0; i < db.UserDataSet.ToList().Count; i++)
                {
                    listBox1.Items.Add(db.UserDataSet.ToList()[i].Login);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (EntityModelContainer us = new EntityModelContainer())
            {
                foreach (UserData userss in us.UserDataSet.ToList())
                {
                    if (Convert.ToString(listBox1.SelectedItem) == Convert.ToString(userss.Login))
                    {
                        foreach(Balance bal in us.BalanceSet.ToList())
                        {
                            if (bal.UserData.Id == userss.Id)
                            {
                                us.BalanceSet.Remove(bal);
                                break;
                            }
                        }                     
                        us.UserDataSet.Remove(userss);                       
                    }
                }
                us.SaveChanges();
            }
            this.UpdateListBox();
         
        }

        private void Admini_Load(object sender, EventArgs e)
        {
            Form2.admin = this;
           
                 
        }
    }
}
