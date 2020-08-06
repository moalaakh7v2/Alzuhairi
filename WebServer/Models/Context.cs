namespace WebServer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAdmin> tblAdmins { get; set; }
        public virtual DbSet<tblCode> tblCodes { get; set; }
        public virtual DbSet<tblDept> tblDepts { get; set; }
        public virtual DbSet<tblNota> tblNotas { get; set; }
        public virtual DbSet<tblPhone> tblPhones { get; set; }
        public virtual DbSet<tblQrCode> tblQrCodes { get; set; }
        public virtual DbSet<tblSerialNumber> tblSerialNumbers { get; set; }
        public virtual DbSet<tblSubject> tblSubjects { get; set; }
        public virtual DbSet<tblUserInfo> tblUserInfos { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserSerial> tblUserSerials { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblDept>()
                .HasMany(e => e.tblSubjects)
                .WithRequired(e => e.tblDept)
                .HasForeignKey(e => e.IdDept);

            modelBuilder.Entity<tblDept>()
                .HasMany(e => e.tblUsers)
                .WithRequired(e => e.tblDept)
                .HasForeignKey(e => e.IdDept);

            modelBuilder.Entity<tblNota>()
                .HasMany(e => e.tblQrCodes)
                .WithRequired(e => e.tblNota)
                .HasForeignKey(e => e.IdNota);

            modelBuilder.Entity<tblNota>()
                .HasMany(e => e.tblSerialNumbers)
                .WithRequired(e => e.tblNota)
                .HasForeignKey(e => e.IdNota);

            modelBuilder.Entity<tblPhone>()
                .HasMany(e => e.tblCodes)
                .WithRequired(e => e.tblPhone)
                .HasForeignKey(e => e.IdPhone);

            modelBuilder.Entity<tblSubject>()
                .HasMany(e => e.tblNotas)
                .WithRequired(e => e.tblSubject)
                .HasForeignKey(e => e.IdSubject);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblPhones)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.IdUser);

            modelBuilder.Entity<tblUser>()
                .HasMany(e => e.tblUserInfos)
                .WithRequired(e => e.tblUser)
                .HasForeignKey(e => e.IdUser);
        }
    }
}
