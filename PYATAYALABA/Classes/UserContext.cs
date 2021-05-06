using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PYATAYALABA
{
    class UserContext : DbContext
    {
        public UserContext() : base("UserDB") { }
        public DbSet<Users> Users { get; set; }

        static UserContext()
        {
            Database.SetInitializer<UserContext>(null);
        }

    }
}
