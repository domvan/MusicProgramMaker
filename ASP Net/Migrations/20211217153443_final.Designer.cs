﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicMakerProgram.Data;

namespace MusicMakerProgram.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211217153443_final")]
    partial class final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicMakerProgram.Models.Admin", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.CanView", b =>
                {
                    b.Property<int>("cvID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GUsername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.HasKey("cvID");

                    b.HasIndex("GUsername");

                    b.HasIndex("PId");

                    b.ToTable("CanViews");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Cellist", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Cellists");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumberOfStudents")
                        .HasColumnType("int");

                    b.Property<int>("TID")
                        .HasColumnType("int");

                    b.HasKey("ClassID");

                    b.HasIndex("TID");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Composer", b =>
                {
                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Period")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CName");

                    b.ToTable("Composers");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.GroupCanEdit", b =>
                {
                    b.Property<int>("GceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GID")
                        .HasColumnType("int");

                    b.HasKey("GceID");

                    b.HasIndex("AdminUserName");

                    b.HasIndex("GID");

                    b.ToTable("GroupCanEdits");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.GroupPerforms", b =>
                {
                    b.Property<int>("GpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GID")
                        .HasColumnType("int");

                    b.Property<int>("PerfID")
                        .HasColumnType("int");

                    b.HasKey("GpID");

                    b.HasIndex("GID");

                    b.HasIndex("PerfID");

                    b.ToTable("GroupPerformsS");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Guest", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Knows", b =>
                {
                    b.Property<int>("KnowsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PerformerName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PieceName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("KnowsID");

                    b.HasIndex("PerformerName");

                    b.HasIndex("PieceName");

                    b.ToTable("KnowsS");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Level", b =>
                {
                    b.Property<int>("LevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YearsOfExpirience")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LevelID");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Manages", b =>
                {
                    b.Property<int>("ManagesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.HasKey("ManagesID");

                    b.HasIndex("AdminUserName");

                    b.HasIndex("ClassID");

                    b.ToTable("ManagesS");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.MusicProgram", b =>
                {
                    b.Property<int>("PID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumPerformers")
                        .HasColumnType("int");

                    b.HasKey("PID");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Performance", b =>
                {
                    b.Property<int>("PerfID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MusicProgramPID")
                        .HasColumnType("int");

                    b.Property<int>("PID")
                        .HasColumnType("int");

                    b.Property<string>("Perf_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Piece_name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PerfID");

                    b.HasIndex("MusicProgramPID");

                    b.HasIndex("Piece_name");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Performer", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<int>("LevelID")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("ClassID");

                    b.HasIndex("LevelID");

                    b.ToTable("Performers");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Pianist", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Pianists");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Piece", b =>
                {
                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("C_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusicSheetLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PName");

                    b.HasIndex("C_name");

                    b.ToTable("Pieces");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Quartet", b =>
                {
                    b.Property<int>("GID")
                        .HasColumnType("int");

                    b.Property<string>("Cellist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellistObjName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FViolinistName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstViolin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SViolinistName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SecondViolin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Violist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViolistObjName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GID");

                    b.HasIndex("CellistObjName");

                    b.HasIndex("FViolinistName");

                    b.HasIndex("SViolinistName");

                    b.HasIndex("ViolistObjName");

                    b.ToTable("Quartet");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Teacher", b =>
                {
                    b.Property<int>("TID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Trio", b =>
                {
                    b.Property<int>("GID")
                        .HasColumnType("int");

                    b.Property<string>("Cellist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CellistObjName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Pianist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PianistObjName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Violinist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViolinistObjName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GID");

                    b.HasIndex("CellistObjName");

                    b.HasIndex("PianistObjName");

                    b.HasIndex("ViolinistObjName");

                    b.ToTable("Trios");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Violinist", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Violinists");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Violist", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Violists");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.composerCanEdit", b =>
                {
                    b.Property<int>("CceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CceID");

                    b.HasIndex("AdminUserName");

                    b.HasIndex("CName");

                    b.ToTable("ComposerCanEdits");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.CanView", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.MusicProgram", "Program")
                        .WithMany()
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Program");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Cellist", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Class", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.GroupCanEdit", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminUserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("GID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.GroupPerforms", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("GID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Performance", "Performance")
                        .WithMany()
                        .HasForeignKey("PerfID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performance");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Knows", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("PerformerName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Piece", "Piece")
                        .WithMany()
                        .HasForeignKey("PieceName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");

                    b.Navigation("Piece");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Manages", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminUserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Performance", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.MusicProgram", "MusicProgram")
                        .WithMany()
                        .HasForeignKey("MusicProgramPID");

                    b.HasOne("MusicMakerProgram.Models.Piece", "Piece")
                        .WithMany()
                        .HasForeignKey("Piece_name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MusicProgram");

                    b.Navigation("Piece");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Performer", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Level");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Pianist", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Piece", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Composer", "Composer")
                        .WithMany()
                        .HasForeignKey("C_name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Composer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Quartet", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Cellist", "CellistObj")
                        .WithMany()
                        .HasForeignKey("CellistObjName");

                    b.HasOne("MusicMakerProgram.Models.Violinist", "FViolinist")
                        .WithMany()
                        .HasForeignKey("FViolinistName");

                    b.HasOne("MusicMakerProgram.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("GID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Violinist", "SViolinist")
                        .WithMany()
                        .HasForeignKey("SViolinistName");

                    b.HasOne("MusicMakerProgram.Models.Violist", "ViolistObj")
                        .WithMany()
                        .HasForeignKey("ViolistObjName");

                    b.Navigation("CellistObj");

                    b.Navigation("FViolinist");

                    b.Navigation("SViolinist");

                    b.Navigation("Team");

                    b.Navigation("ViolistObj");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Trio", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Cellist", "CellistObj")
                        .WithMany()
                        .HasForeignKey("CellistObjName");

                    b.HasOne("MusicMakerProgram.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("GID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Pianist", "PianistObj")
                        .WithMany()
                        .HasForeignKey("PianistObjName");

                    b.HasOne("MusicMakerProgram.Models.Violinist", "ViolinistObj")
                        .WithMany()
                        .HasForeignKey("ViolinistObjName");

                    b.Navigation("CellistObj");

                    b.Navigation("PianistObj");

                    b.Navigation("Team");

                    b.Navigation("ViolinistObj");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Violinist", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Violist", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.composerCanEdit", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminUserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Composer", "Composer")
                        .WithMany()
                        .HasForeignKey("CName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Composer");
                });
#pragma warning restore 612, 618
        }
    }
}
