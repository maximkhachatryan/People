using People.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.DAL
{
    public class PeopleContext : DbContext
    {
        public PeopleContext()
            : base("Name=PeopleConnString")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        public virtual DbSet<Person> Folks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>().HasKey(x => x.Id);
            modelBuilder.Entity<Person>().Property(x => x.Id).HasColumnName("PID");

            modelBuilder.Entity<Person>().Property(x => x.FirstName)
                .HasMaxLength(240);

            modelBuilder.Entity<Person>().Property(x => x.LastName)
                .HasMaxLength(240);

            modelBuilder.Entity<Person>().Property(x => x.Notes)
                .HasMaxLength(2400);

            modelBuilder.Entity<Person>().Property(x => x.Phone)
                .HasMaxLength(240);

            modelBuilder.Entity<Person>().Property(x => x.Email)
                .HasMaxLength(240);

            base.OnModelCreating(modelBuilder);
        }
    }
}
