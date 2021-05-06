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
            using (UserContext db = new UserContext())
            {
                foreach (Users users in db.Users)
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
            using (UserContext db = new UserContext())
            {
                for (int i = 0; i < db.Users.ToList().Count; i++)
                {
                    listBox1.Items.Add(db.Users.ToList()[i].Login);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                foreach (Users users in db.Users)
                {
                    if (Convert.ToString(listBox1.SelectedItem) == Convert.ToString(users.Login))
                    {

                        db.Users.Remove(users);
                    }

                }
                db.SaveChanges();
            }
            this.UpdateListBox();
            //for (int i = 0; i <= this.ListAccounts.accounts.Count; i++)
            //{

            //    if (Convert.ToString(listBox1.SelectedItem) == this.ListAccounts.accounts[i].Surname)
            //    {
            //        MessageBox.Show("");
            //        this.ListAccounts.accounts.Remove(this.ListAccounts.accounts[i]);
            //    }
            //}
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Admini_Load(object sender, EventArgs e)
        {
            Form2.admin = this;
           
                 
        }
    }
}
