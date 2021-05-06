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
    public partial class Osnova : Form
    {
        public UserData users;
        private char[] summa;
        public static fond fondhab;
        public static poplnit popa;
        public Osnova(UserData users)
        {
            
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            labelName.Text = users.Name + " " + users.Surname;
            this.users = users;
            label5.Text = users.Balance.ToList()[0].Summa;
            label4.Text = "";
            for (int i = 5; i < users.Balance.ToList()[0].NumberCard.Length; i++)
            {
                label4.Text += users.Balance.ToList()[0].NumberCard[i];
            }
            pictureBox8.Visible = true;
            panel6.Visible = true;
            label19.Visible = false;
            label18.Visible = false;
            
            button12.Visible = false;
            panel3.Visible = true;
           

          
           

            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void Osnova_Load(object sender, EventArgs e)
        {
            fond.osnova = this;
            poplnit.osnova = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Нечего стирать");
            }
            else
            {
                summa = textBox1.Text.ToCharArray();
                summa[summa.Length - 1] = '\0';
                textBox1.Text = new string(summa);
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //label20.Visible = true;
            //textBox3.Visible = true;
            //pictureBox5.Visible = false;
            //label12.Visible = false;
            //panel2.Visible = false;
            //panel3.Visible = false;



            //label18.Visible = false;
            //label19.Visible = false;
            //textBox1.Visible = false;
            //textBox2.Visible = false;

            //button1.Visible = true;
            //button2.Visible = true;
            //button3.Visible = true;
            //button4.Visible = true;
            //button5.Visible = true;
            //button6.Visible = true;
            //button7.Visible = true;
            //button8.Visible = true;
            //button9.Visible = true;
            //button10.Visible = true;
            //button11.Visible = true;
            //loginKnopka.Visible = true;
            //loginKnopka.Text = "Пополнить";
            //button12.Visible = true;
            //textBox1.Visible = false;
            //textBox2.Visible = false;
            pictureBox5.Visible = true;
            label12.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            ////panel6.Visible = true;
            //loginKnopka.Text = "Перевести";
            label18.Visible = false;
            label19.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            loginKnopka.Visible = false;
            button12.Visible = false;
           

            //panel6.Visible = true;
            //loginKnopka.Text = "Пополнить";
            poplnit popo = new poplnit(users);
            popo.Show();

        
          
        }

        private void label9_Click(object sender, EventArgs e)
        {
            loginKnopka.Text = "Перевести";
            textBox1.Enabled = false;
            pictureBox5.Visible = false;
            label12.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            ////panel6.Visible = true;
            //loginKnopka.Text = "Перевести";
            label18.Visible = true;
            label19.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            loginKnopka.Visible = true;
            button12.Visible = true;

           
            pictureBox5.Visible = false;
            label12.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            
            


            

        }

        private void loginKnopka_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                using (EntityModelContainer db = new EntityModelContainer())
                {
                    for (int i = 0; i < db.BalanceSet.ToList().Count; i++)
                    {
                        if (db.BalanceSet.ToList()[i].NumberCard == textBox2.Text && (textBox2.Text != users.Balance.ToList()[0].NumberCard))
                        {
                            db.BalanceSet.ToList()[i].Summa = Convert.ToString(Convert.ToInt32(db.BalanceSet.ToList()[i].Summa) + Convert.ToInt32(textBox1.Text));

                            db.BalanceSet.Find(users.Balance.ToList()[0].Id).Summa = Convert.ToString(Convert.ToInt32(users.Balance.ToList()[0].Summa) - Convert.ToInt32(textBox1.Text));
                            db.SaveChanges();
                            label5.Text = db.BalanceSet.Find(users.Balance.ToList()[0].Id).Summa;
                            MessageBox.Show("Успешно!");
                            return;
                        }

                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            label12.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            ////panel6.Visible = true;
            //loginKnopka.Text = "Перевести";
            label18.Visible = false;
            label19.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
           
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            loginKnopka.Visible = false;
            button12.Visible = false;
          
        }

        private void l1_Click(object sender, EventArgs e)
        {
        }

        private void l2_Click(object sender, EventArgs e)
        {
        }

        private void l3_Click(object sender, EventArgs e)
        {
        }

        private void l4_Click(object sender, EventArgs e)
        {
        }

        private void l5_Click(object sender, EventArgs e)
        {
        }

        private void l6_Click(object sender, EventArgs e)
        {
        }

        private void l7_Click(object sender, EventArgs e)
        {
        }

        private void l8_Click(object sender, EventArgs e)
        {
        }

        private void l9_Click(object sender, EventArgs e)
        {
        }

        private void l10_Click(object sender, EventArgs e)
        {
        }

        private void l11_Click(object sender, EventArgs e)
        {
            //summa = textBox3.Text.ToCharArray();
            //summa[summa.Length - 1] = '\0';
            //textBox3.Text = new string(summa);
        }

        private void l12_Click(object sender, EventArgs e)
        {
             pictureBox5.Visible = true;
            label12.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            ////panel6.Visible = true;
            //loginKnopka.Text = "Перевести";
       
            //label19.Visible = false;
            //textBox1.Visible = false;
         
            //panel5.Visible = false;
           
            using (EntityModelContainer db = new EntityModelContainer())
            {
                //db.BalanceSet.Find(users.Balance.ToList()[0].Id).Summa = Convert.ToString(Convert.ToInt32(users.Balance.ToList()[0].Summa) + Convert.ToInt32(textBox3.Text));
                db.SaveChanges();
                label5.Text = "";

            }
            label5.Text = users.Balance.ToList()[0].Summa;
            MessageBox.Show("Успешно");


        }

        private void baba1_Click(object sender, EventArgs e)
        {
            using (EntityModelContainer db = new EntityModelContainer())
            {
                //db.BalanceSet.Find(users.Balance.ToList()[0].Id).Summa = Convert.ToString(Convert.ToInt32(users.Balance.ToList()[0].Summa) + Convert.ToInt32(textBox3.Text));
                db.SaveChanges();
                label5.Text = "";
                
            }
            label5.Text = users.Balance.ToList()[0].Summa;
            MessageBox.Show("Успешно");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            fond fondhab = new fond(users);
            fondhab.Show();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Ipoteka ipo = new Ipoteka();
            ipo.Show();
        }
    }
}
