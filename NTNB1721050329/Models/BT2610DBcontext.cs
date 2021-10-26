using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTNB1721050329.Models
{
    public partial class BT2610DBcontext : DbContext
    {
        public BT2610DBcontext()
            : base("name=BT2610DBcontext")
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
              .Property(e => e.PersonID)
              .IsUnicode(true);
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonName)
            .IsUnicode(true);
            modelBuilder.Entity<Lecture>()
               .Property(e => e.Faculty)
               .IsUnicode(true);
            modelBuilder.Entity<Lecture>()
                .Property(e => e.Department)
                .IsUnicode(true);
        }
    }
}
