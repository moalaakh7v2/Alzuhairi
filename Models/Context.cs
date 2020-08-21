using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Models
{
    public partial class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<CheckCode> CheckCodes { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<NoteBookFeature> NoteBookFeatures { get; set; }
        public virtual DbSet<NoteBook> NoteBooks { get; set; }
        public virtual DbSet<NoteBookSerial> NoteBookSerials { get; set; }
        public virtual DbSet<NoteBooksSold> NoteBooksSolds { get; set; }
        public virtual DbSet<RegisterCode> RegisterCodes { get; set; }
        public virtual DbSet<Reseller> Resellers { get; set; }
        public virtual DbSet<StudentNoteBook> StudentNoteBooks { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<View> Views { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var foreignKey in entity.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
                }
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }
    }
}
