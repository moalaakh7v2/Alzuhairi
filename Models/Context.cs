using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Data.Common;
namespace Models
{
    public partial class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<CheckCode> CheckCodes { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<NoteBookFeature> NoteBookFeatures { get; set; }
        public virtual DbSet<NoteBook> NoteBooks { get; set; }
        public virtual DbSet<NoteBookSerial> NoteBookSerials { get; set; }
        public virtual DbSet<Reseller> Resellers { get; set; }
        public virtual DbSet<ResellerAndNoteBook> ResellerAndNoteBooks { get; set; }
        public virtual DbSet<StudentNoteBook> StudentNoteBooks { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<View> Views { get; set; }
    }
}
