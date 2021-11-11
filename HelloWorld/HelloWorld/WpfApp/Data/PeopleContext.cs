using Microsoft.EntityFrameworkCore;
using ObjektoveProgramovani.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Data
{
    class PeopleContext : DbContext
    {

        //mapuju class na tabulky
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Car> Cars { get; set; }

        //konstruktor pro connection string to MSSQL
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer(@$"Server=(localdb)\MSSQLLocalDB; Database=peopledb");

        //konstruktor pro sqlite
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@$"Data Source=peopledb.db");
    }

}
