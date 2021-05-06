using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYATAYALABA
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Word { get; set; }
        public Users(string Name, string Surname, string Login, string Password, string Mail, string Word)
        {

            this.Name = Name;
            this.Surname = Surname;
            this.Login = Login;
            this.Password = Password;
            this.Mail = Mail;
            this.Word = Word;

        }
        public Users() { }

    }
    
}
