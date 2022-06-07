using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYATAYALABA
{
    public class join
    {
        
        public bool entryTest(string login, string pas)
        {
            using (EntityModelContainer db = new EntityModelContainer())
            {
                foreach (UserData users in db.UserDataSet)
                {
                    if (login == users.Login && pas == users.Password)
                    {                    
                        return true;
                    }                  
                }
                
            }
            return false;
        }

        public bool entryTestLog(string login, string pas)
        {
            if (login != "")
            {
                using (EntityModelContainer db = new EntityModelContainer())
                {
                    foreach (UserData users in db.UserDataSet)
                    {
                        if (login == users.Login && pas == users.Password)
                        {
                            return true;
                        }
                    }

                }
            }
            else
            {
                return true;
            }
            return false;
            
        }

        public bool entryTestPas(string login, string pas)
        {
            if (pas != "")
            {
                using (EntityModelContainer db = new EntityModelContainer())
                {
                    foreach (UserData users in db.UserDataSet)
                    {
                        if (login == users.Login && pas == users.Password)
                        {
                            return true;
                        }
                    }
                }
            }
            else
            {
                return true;
            }
            return false;

        }

        public bool checkReg(string name, string surname, string login, string pass, string mail, string role)
        {
            using (EntityModelContainer us = new EntityModelContainer())
            {
                var all = us.UserDataSet.Select(f => f.Login).ToList();             
                if (!all.Contains(login))
                {
                    UserData users = new UserData() { Name = name, Surname = surname, Login = login, Password = pass, Mail = mail, Role = role };
                    us.UserDataSet.Add(users);                   
                    Balance balance = new Balance() { Summa = "0", UserData = users, NumberCard = Convert.ToString((new Random()).Next(100000000, 999999999)) };
                    us.BalanceSet.Add(balance);                
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public bool deleteUs(string login)
        {
            using (EntityModelContainer us = new EntityModelContainer())
            {
                foreach (UserData users in us.UserDataSet.ToList())
                {
                    if (login == Convert.ToString(users.Login))
                    {
                        return true;
                    }                  
                }
                return false;                
            }
        }

        public bool deleteUsNull(string login)
        {
            if (login != "")
            {
                using (EntityModelContainer us = new EntityModelContainer())
                {
                    foreach (UserData users in us.UserDataSet.ToList())
                    {
                        if (login == Convert.ToString(users.Login))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            else
            {
                return true;
            }

        }

        public bool entryNullTest(string login, string pas)
        {
            using (EntityModelContainer db = new EntityModelContainer())
            {
                foreach (UserData users in db.UserDataSet)
                {
                    if (login == users.Login && pas == users.Password)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public bool checkRegNull(string name, string surname, string login, string pass, string mail, string role)
        {
            if(login != "")
            {
                return false;
                using (EntityModelContainer us = new EntityModelContainer())
                {
                    var all = us.UserDataSet.Select(f => f.Login).ToList();
                    if (!all.Contains(login))
                    {
                        UserData users = new UserData() { Name = name, Surname = surname, Login = login, Password = pass, Mail = mail, Role = role };
                        us.UserDataSet.Add(users);
                        Balance balance = new Balance() { Summa = "0", UserData = users, NumberCard = Convert.ToString((new Random()).Next(100000000, 999999999)) };
                        us.BalanceSet.Add(balance);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            else
            {
                return true;
            }
            
        }

        public bool RaschetStavka(string stavkaa, string sroke, string sum)
        {
            if(stavkaa != "")
            {
                var summa = Convert.ToUInt64(sum);
                var srok = Convert.ToUInt16(sroke);
                var stavka = Convert.ToDouble(stavkaa) / 12 / 100;
                var obstavka = Math.Pow((1 + stavka), srok);
                var plata = summa * stavka * obstavka / (obstavka - 1);
                
            }
            else
            {
                return true;
            }
            return false;
        }

        public bool NomerKart(string num)
        {
            if (num.Contains("-"))
                return true;
            return false;
        }

        public bool CheckFirst(string first)
        {
            if (first[0] == '0')
                return true;
            return false;
        }

        public bool RaschetSrok(string stavkaa, string sroke, string sum)
        {
            if (sroke != "")
            {
                var summa = Convert.ToUInt64(sum);
                var srok = Convert.ToUInt16(sroke);
                var stavka = Convert.ToDouble(stavkaa) / 12 / 100;
                var obstavka = Math.Pow((1 + stavka), srok);
                var plata = summa * stavka * obstavka / (obstavka - 1);

            }
            else
            {
                return true;
            }
            return false;
        }
        public bool Pozhertv(string sum)
        {
            if (sum != "")
            {
                if (Convert.ToInt32(sum) > 0 || sum != "")
                {
                    using (EntityModelContainer db = new EntityModelContainer())
                    {
                    }
                }
                else
                {
                }
            }
            else
            {
                return true;
            }
            return false;
        }

        public bool Raschet(string stavkaa, string sroke, string sum)
        {
            if (sum != "")
            {
                var summa = Convert.ToUInt64(sum);
                var srok = Convert.ToUInt16(sroke);
                var stavka = Convert.ToDouble(stavkaa) / 12 / 100;
                var obstavka = Math.Pow((1 + stavka), srok);
                var plata = summa * stavka * obstavka / (obstavka - 1);

            }
            else
            {
                return true;
            }
            return false;
        }

        public bool DeleteChisl(string a)
        {
            if (a == "")
            {
                return true;
            }
            else
            {
                var summa = a.ToCharArray();
                summa[summa.Length - 1] = '\0';
                a = new string(summa);
            }
            return false;
        }

        public bool checkRegNullName(string name, string surname, string login, string pass, string mail, string role)
        {
            if (name != "")
            {
                return false;
                using (EntityModelContainer us = new EntityModelContainer())
                {
                    var all = us.UserDataSet.Select(f => f.Login).ToList();
                    if (!all.Contains(login))
                    {
                        UserData users = new UserData() { Name = name, Surname = surname, Login = login, Password = pass, Mail = mail, Role = role };
                        us.UserDataSet.Add(users);
                        Balance balance = new Balance() { Summa = "0", UserData = users, NumberCard = Convert.ToString((new Random()).Next(100000000, 999999999)) };
                        us.BalanceSet.Add(balance);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            else
            {
                return true;
            }

        }

        public bool checkRegNullSurname(string name, string surname, string login, string pass, string mail, string role)
        {
            if (surname != "")
            {
                return false;
                using (EntityModelContainer us = new EntityModelContainer())
                {
                    var all = us.UserDataSet.Select(f => f.Login).ToList();
                    if (!all.Contains(login))
                    {
                        UserData users = new UserData() { Name = name, Surname = surname, Login = login, Password = pass, Mail = mail, Role = role };
                        us.UserDataSet.Add(users);
                        Balance balance = new Balance() { Summa = "0", UserData = users, NumberCard = Convert.ToString((new Random()).Next(100000000, 999999999)) };
                        us.BalanceSet.Add(balance);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            else
            {
                return true;
            }

        }

        public bool checkRegNullPass(string name, string surname, string login, string pass, string mail, string role)
        {
            if (pass != "")
            {
                return false;
                using (EntityModelContainer us = new EntityModelContainer())
                {
                    var all = us.UserDataSet.Select(f => f.Login).ToList();
                    if (!all.Contains(login))
                    {
                        UserData users = new UserData() { Name = name, Surname = surname, Login = login, Password = pass, Mail = mail, Role = role };
                        us.UserDataSet.Add(users);
                        Balance balance = new Balance() { Summa = "0", UserData = users, NumberCard = Convert.ToString((new Random()).Next(100000000, 999999999)) };
                        us.BalanceSet.Add(balance);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            else
            {
                return true;
            }

        }

        public bool checkRegNullMail(string name, string surname, string login, string pass, string mail, string role)
        {
            if (mail != "")
            {
                return false;
                using (EntityModelContainer us = new EntityModelContainer())
                {
                    var all = us.UserDataSet.Select(f => f.Login).ToList();
                    if (!all.Contains(login))
                    {
                        UserData users = new UserData() { Name = name, Surname = surname, Login = login, Password = pass, Mail = mail, Role = role };
                        us.UserDataSet.Add(users);
                        Balance balance = new Balance() { Summa = "0", UserData = users, NumberCard = Convert.ToString((new Random()).Next(100000000, 999999999)) };
                        us.BalanceSet.Add(balance);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            else
            {
                return true;
            }

        }

        public bool Perevod(string one, string two)
        {
            if (one != "" && two != "")
            {
                return false;              
            }
            else
            {
                return true;
            }
        }


        public bool Popoln(string one)
        {          
                return true;            
        }


        public bool PopolnNull(string one)
        {
            if(one == "")
                return true;
            return false;
        }

        public bool PopolnLong(int one)
        {
            if (one > 9000000)
                return true;
            return false;
        }
    }
}
