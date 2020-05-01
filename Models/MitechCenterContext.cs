using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MitechCenter.vn.Models
{
    // Add-Migration MitechCenterDatabaseCreation
    // Remove-Migration
    // Update-Database
    public class MitechCenterContext : DbContext
    {
        public MitechCenterContext(DbContextOptions<MitechCenterContext> options) : base(options)
        {
        }

        public virtual DbSet<AboutUs> Abouts { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<NewsCategory> NewsCategories { get; set; }
        public virtual DbSet<News> TheNews { get; set; }
        public virtual DbSet<StaticElement> StaticElements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Thao tác đối với bảng AboutUs
            modelBuilder.Entity<AboutUs>(entity =>
            {
                entity.ToTable(typeof(AboutUs).Name);
                entity.HasIndex(e => e.auId).HasName("FK_" + typeof(AboutUs).Name + "_Id_Index");
                entity.Property(e => e.createAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.updateAt).HasDefaultValueSql("GETDATE()");
            });
            #endregion

            #region Thao tác đối với bảng Feedback
            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable(typeof(Feedback).Name);
                entity.HasIndex(e => e.fId).HasName("FK_" + typeof(Feedback).Name + "_Id_Index");
                entity.Property(e => e.createAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.updateAt).HasDefaultValueSql("GETDATE()");
            });
            #endregion

            #region Thao tác đối với bảng User
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(typeof(User).Name);
                entity.HasIndex(e => e.uId).HasName("FK_" + typeof(User).Name + "_Id_Index");
                entity.Property(e => e.createAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.updateAt).HasDefaultValueSql("GETDATE()");
            });
            #endregion

            #region Thao tác đối với bảng Teacher
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable(typeof(Teacher).Name);
                entity.HasIndex(e => e.tId).HasName("FK_" + typeof(Teacher).Name + "_Id_Index");
                entity.Property(e => e.createAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.updateAt).HasDefaultValueSql("GETDATE()");
            });
            #endregion

            #region Thao tác đối với bảng Course
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable(typeof(Course).Name);
                entity.HasIndex(e => e.cId).HasName("FK_" + typeof(Course).Name + "_Id_Index");
                entity.Property(e => e.createAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.updateAt).HasDefaultValueSql("GETDATE()");
            });
            #endregion

            #region Thao tác đối với bảng NewsCategory
            modelBuilder.Entity<NewsCategory>(entity =>
            {
                entity.ToTable(typeof(NewsCategory).Name);
                entity.HasIndex(e => e.ncId).HasName("FK_" + typeof(NewsCategory).Name + "_Id_Index");
                entity.Property(e => e.createAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.updateAt).HasDefaultValueSql("GETDATE()");
            });
            #endregion

            #region Thao tác đối với bảng News
            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable(typeof(News).Name);
                entity.HasIndex(e => e.nId).HasName("FK_" + typeof(News).Name + "_Id_Index");
                entity.Property(e => e.createAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.updateAt).HasDefaultValueSql("GETDATE()");
            });
            #endregion

            #region Thao tác đối với bảng ElementTbl
            modelBuilder.Entity<StaticElement>(entity =>
            {
                // Tạo bảng
                entity.ToTable(typeof(StaticElement).Name);
                // Khởi tạo Index
                entity.HasIndex(e => e.eId).HasName("FK_ElementTbl_Id_Index");
                entity.HasIndex(e => e.eKey).HasName("FK_ElementTbl_Key_Index").IsUnique();
                // Default value
                entity.Property(e => e.createAt).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.updateAt).HasDefaultValueSql("GETDATE()");
                // Khởi tạo dữ liệu ban đầu
                using (StreamReader r = File.OpenText("./statics/staticElements.json"))
                {
                    string json = r.ReadToEnd();
                    List<StaticElement> ses = JsonConvert.DeserializeObject<List<StaticElement>>(json);
                    for (int i = 0; i < ses.Count; i++)
                    {
                        ses[i].eId = i + 1;
                        ses[i].createAt = DateTime.Now;
                        ses[i].updateAt = DateTime.Now;
                    }
                    entity.HasData(ses);
                }
            });
            #endregion
        }
    }
}

// dotnet ef migrations add MyFirstMigration