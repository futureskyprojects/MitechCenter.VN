﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MitechCenter.vn.Models;

namespace MitechCenter.vn.Migrations
{
    [DbContext(typeof(MitechCenterContext))]
    partial class MitechCenterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MitechCenter.vn.Models.AboutUs", b =>
                {
                    b.Property<int>("auId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("auContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("auTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("isServices")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bit");

                    b.Property<int>("uId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("auId");

                    b.HasIndex("auId")
                        .HasName("FK_AboutUs_Id_Index");

                    b.HasIndex("uId");

                    b.ToTable("AboutUs");
                });

            modelBuilder.Entity("MitechCenter.vn.Models.Course", b =>
                {
                    b.Property<int>("cId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cLearningTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("cPrice")
                        .HasColumnType("real");

                    b.Property<string>("cSchedule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("tId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("cId");

                    b.HasIndex("cId")
                        .HasName("FK_Course_Id_Index");

                    b.HasIndex("tId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("MitechCenter.vn.Models.Feedback", b =>
                {
                    b.Property<int>("fId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("fAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fFullname")
                        .HasColumnType("int");

                    b.Property<string>("fPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("fReplyByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("fId");

                    b.HasIndex("fId")
                        .HasName("FK_Feedback_Id_Index");

                    b.HasIndex("fReplyByUserId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("MitechCenter.vn.Models.News", b =>
                {
                    b.Property<int>("nId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("nContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nFeatureImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ncId")
                        .HasColumnType("int");

                    b.Property<int>("uId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("nId");

                    b.HasIndex("nId")
                        .HasName("FK_News_Id_Index");

                    b.HasIndex("ncId");

                    b.HasIndex("uId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("MitechCenter.vn.Models.NewsCategory", b =>
                {
                    b.Property<int>("ncId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("ncDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ncName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("ncId");

                    b.HasIndex("ncId")
                        .HasName("FK_NewsCategory_Id_Index");

                    b.ToTable("NewsCategory");
                });

            modelBuilder.Entity("MitechCenter.vn.Models.StaticElement", b =>
                {
                    b.Property<int>("eId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("eData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("updateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("eId");

                    b.HasIndex("eId")
                        .HasName("FK_ElementTbl_Id_Index");

                    b.HasIndex("eKey")
                        .IsUnique()
                        .HasName("FK_ElementTbl_Key_Index")
                        .HasFilter("[eKey] IS NOT NULL");

                    b.ToTable("StaticElement");

                    b.HasData(
                        new
                        {
                            eId = 1,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 447, DateTimeKind.Local).AddTicks(3043),
                            eData = "Trung tâm CNTT & NN - Trường ĐH Thông Tin Liên Lạc",
                            eDescription = "",
                            eKey = "OWNER",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(4495)
                        },
                        new
                        {
                            eId = 2,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5122),
                            eData = "assets/images/logo-icon.png",
                            eDescription = "",
                            eKey = "LOGO",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5144)
                        },
                        new
                        {
                            eId = 3,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5157),
                            eData = "",
                            eDescription = "",
                            eKey = "CAROUSEL",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5159)
                        },
                        new
                        {
                            eId = 4,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5161),
                            eData = "",
                            eDescription = "",
                            eKey = "DEVELOPMENT_MOTTO",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5163)
                        },
                        new
                        {
                            eId = 5,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5164),
                            eData = "",
                            eDescription = "",
                            eKey = "SERIVE_MOTTO",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5166)
                        },
                        new
                        {
                            eId = 6,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5167),
                            eData = "",
                            eDescription = "",
                            eKey = "PARTNER",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5169)
                        },
                        new
                        {
                            eId = 7,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5171),
                            eData = "Trung tâm CNTT & NN - Trường ĐH Thông Tin Liên Lạc (Mitech Center) thành lập theo Quyết định số 988/QĐ-BQP ngày 28/3/2015 của BQP, có chức năng đào tạo, nghiên cứu và cung cấp dịch vụ CNTT.",
                            eDescription = "",
                            eKey = "DECIDE_TO_ESTABLISH",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5172)
                        },
                        new
                        {
                            eId = 8,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5174),
                            eData = "",
                            eDescription = "",
                            eKey = "CONTACT_INFO",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5175)
                        },
                        new
                        {
                            eId = 9,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5177),
                            eData = "",
                            eDescription = "",
                            eKey = "EMBED",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5178)
                        },
                        new
                        {
                            eId = 10,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5180),
                            eData = "Copyright © Trung Tâm CNTT & NN Đại học Thông Tin Liên Lạc",
                            eDescription = "",
                            eKey = "COPY_RIGHT",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5181)
                        },
                        new
                        {
                            eId = 11,
                            createAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5184),
                            eData = "",
                            eDescription = "",
                            eKey = "EDUCATION_PROGRAM",
                            updateAt = new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5185)
                        });
                });

            modelBuilder.Entity("MitechCenter.vn.Models.Teacher", b =>
                {
                    b.Property<int>("tId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("tAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("updateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("tId");

                    b.HasIndex("tId")
                        .HasName("FK_Teacher_Id_Index");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("MitechCenter.vn.Models.User", b =>
                {
                    b.Property<int>("uId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UseruId")
                        .HasColumnType("int");

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("createAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("displayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("encryptPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updateAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uId");

                    b.HasIndex("UseruId");

                    b.HasIndex("uId")
                        .HasName("FK_User_Id_Index");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MitechCenter.vn.Models.AboutUs", b =>
                {
                    b.HasOne("MitechCenter.vn.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("uId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MitechCenter.vn.Models.Course", b =>
                {
                    b.HasOne("MitechCenter.vn.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("tId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MitechCenter.vn.Models.Feedback", b =>
                {
                    b.HasOne("MitechCenter.vn.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("fReplyByUserId");
                });

            modelBuilder.Entity("MitechCenter.vn.Models.News", b =>
                {
                    b.HasOne("MitechCenter.vn.Models.NewsCategory", "NewsCategory")
                        .WithMany("News")
                        .HasForeignKey("ncId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MitechCenter.vn.Models.User", "User")
                        .WithMany("News")
                        .HasForeignKey("uId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MitechCenter.vn.Models.User", b =>
                {
                    b.HasOne("MitechCenter.vn.Models.User", null)
                        .WithMany("AboutUs")
                        .HasForeignKey("UseruId");
                });
#pragma warning restore 612, 618
        }
    }
}
