using PYATAYALABA.Formss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYATAYALABA
{
    public partial class Form1 : Form
    {
        public static Form2 f2;
        public static vosstan vos;
        public static Admini admini;
        
        
        public Form1()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            textBox1.Text = "ksu";
            textBox2.Text = "ksu";
        }

        private void regKnopka_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2.f1 = this;
            vosstan.vosem = this;
            Admini.admini = this;
            
        }

        private void loginKnopka_Click(object sender, EventArgs e)
        {
            using (EntityModelContainer db = new EntityModelContainer())
            {
                foreach (UserData users in db.UserDataSet)
                {
                    if (textBox1.Text == users.Login && this.GetHashString(textBox2.Text) == users.Password)
                    {
                        MessageBox.Show("Добро пожаловать, " + users.Name);

                        Osnova osn = new Osnova(users);
                        osn.Show();
                        this.Hide();
                        return;
                    }
                }
                MessageBox.Show("Логин или пароль ввведен неверно!");
            } 
            
        }
        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vosstan vos = new vosstan();
            vos.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admini admini = new Admini();
            admini.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vosstan vos = new vosstan();
            vos.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Admini admini = new Admini();
            admini.Show();
        }
    }
}
