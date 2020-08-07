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
        public virtual DbSet<Admin> tblAdmins { get; set; }
        public virtual DbSet<Code> tblCodes { get; set; }
        public virtual DbSet<Dept> tblDepts { get; set; }
        public virtual DbSet<Nota> tblNotas { get; set; }
        public virtual DbSet<Phone> tblPhones { get; set; }
        public virtual DbSet<QrCode> tblQrCodes { get; set; }
        public virtual DbSet<SerialNumber> tblSerialNumbers { get; set; }
        public virtual DbSet<Subject> tblSubjects { get; set; }
        public virtual DbSet<UserInfo> tblUserInfos { get; set; }
        public virtual DbSet<User> tblUsers { get; set; }
        public virtual DbSet<UserSerial> tblUserSerials { get; set; }

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
