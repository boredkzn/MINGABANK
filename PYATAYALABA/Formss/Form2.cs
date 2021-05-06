using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYATAYALABA
{
    public partial class Form2 : Form
    {
        public static Form1 f1;
        public static Admini admin;

        public Form2()
        {
            InitializeComponent();
            admin = new Admini();
            
        }

       

        private void regKnopka_Click(object sender, EventArgs e)
        {
            using (EntityModelContainer us = new EntityModelContainer())
            {
                UserData users = new UserData() { Name = textBox1.Text, Surname = textBox2.Text, Login = textBox3.Text, Password = this.GetHashString(textBox4.Text), Mail = textBox5.Text, Role = "User" };
                us.UserDataSet.Add(users);
                us.SaveChanges();
                Balance balance = new Balance() { Summa = "0", UserData = users, NumberCard = Convert.ToString((new Random()).Next(100000000, 999999999)) };
                us.BalanceSet.Add(balance);
                us.SaveChanges();
                admin.listBox1.Items.Add(users.Login);
                this.Close();
            }
            admin.UpdateListBox();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1.f2 = this;
            Admini.form22 = this;
            
            
            
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
    }
}
