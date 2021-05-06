using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYATAYALABA
{
    public partial class vosstan : Form
    {
        Random rnd = new Random();
        public int pasik;
        public static Form1 vosem;
        cod cod;
        vosstan vos;
        public Users users;

        public vosstan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MailAddress from = new MailAddress("forchess202@mail.ru", "Крем по увеличению члена");
            MailAddress to = new MailAddress(textBox1.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Важная информация";
            using (UserContext db = new UserContext())
            {
                foreach(Users users in db.Users)
                {
                    if (textBox1.Text == users.Mail && textBox2.Text == users.Word)
                    {
                        pasik = rnd.Next(100000, 999999);
                        m.Body = "<h1>Код для восстановления пароля: " + pasik + "</h1>";
                        m.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                        smtp.Credentials = new NetworkCredential("forchess202@mail.ru", "logitech45");
                        smtp.EnableSsl = true;
                        smtp.Send(m);

                        cod cod = new cod();
                        cod.users = users;
                        cod.Show();
                        this.Close();


                        return;
                    }
                    
                }
                MessageBox.Show("Ошибка!");

            }
            
            

        }

        private void vosstan_Load(object sender, EventArgs e)
        {
            cod.izm = this;
           
        }
    }
}
