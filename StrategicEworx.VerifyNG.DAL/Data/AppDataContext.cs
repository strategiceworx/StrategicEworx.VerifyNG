using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategicEworx.VerifyNG.Models;

namespace StrategicEworx.VerifyNG.DAL.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("VerifyNGConnection") { }

        /// <summary>
        ///  any entity to be persisted must be declared here.
        /// </summary>
        /// 

        public DbSet<User> User { get; set; }
        //public DbSet<UserEducation> UserEducation { get; set; }
        //public DbSet<UserExamination> UserExamination { get; set; }
        //public DbSet<UserQualification> UserQualification { get; set; }
        //public DbSet<UserActiveWorker> UserActiveWorker { get; set; }

        //public DbSet<Person> Persons { get; set; }
        //public DbSet<PersonEducation> PersonEducations { get; set; }
        ////public DbSet<PersonExamination> PersonExaminations { get; set; }
        //public DbSet<PersonWorkExperience> PersonWorkExperience { get; set; }
        ////public DbSet<PersonQualification> PersonQualifications { get; set; }
        //public DbSet<RetiredWorker> RetiredWorkers { get; set; }
        //public DbSet<ActiveWorker> ActiveWorkers { get; set; }
        //public DbSet<BankAccount> BankAccounts { get; set; }

    }
}
