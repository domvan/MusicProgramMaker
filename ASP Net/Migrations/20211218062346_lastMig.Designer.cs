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
    [Migration("20211218062346_lastMig")]
    partial class lastMig
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
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.CanView", b =>
                {
                    b.Property<int>("CvID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GuestID")
                        .HasColumnType("int");

                    b.Property<int>("PId")
                        .HasColumnType("int");

                    b.HasKey("CvID");

                    b.HasIndex("GuestID");

                    b.HasIndex("PId");

                    b.ToTable("CanViews");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Cellist", b =>
                {
                    b.Property<int>("PerformerID")
                        .HasColumnType("int");

                    b.HasKey("PerformerID");

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

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Composer", b =>
                {
                    b.Property<int>("CID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Period")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CID");

                    b.ToTable("Composers");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.GroupCanEdit", b =>
                {
                    b.Property<int>("GceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<int>("GID")
                        .HasColumnType("int");

                    b.HasKey("GceID");

                    b.HasIndex("AdminID");

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
                    b.Property<int>("GuestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuestID");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Knows", b =>
                {
                    b.Property<int>("KnowsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PerformerID")
                        .HasColumnType("int");

                    b.Property<int>("PieceID")
                        .HasColumnType("int");

                    b.HasKey("KnowsID");

                    b.HasIndex("PerformerID");

                    b.HasIndex("PieceID");

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

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.HasKey("ManagesID");

                    b.HasIndex("AdminID");

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

                    b.Property<int>("PieceID")
                        .HasColumnType("int");

                    b.HasKey("PerfID");

                    b.HasIndex("MusicProgramPID");

                    b.HasIndex("PieceID");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Performer", b =>
                {
                    b.Property<int>("PerformerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<int>("LevelID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PerformerID");

                    b.HasIndex("ClassID");

                    b.HasIndex("LevelID");

                    b.ToTable("Performers");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Pianist", b =>
                {
                    b.Property<int>("PerformerID")
                        .HasColumnType("int");

                    b.HasKey("PerformerID");

                    b.ToTable("Pianists");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Piece", b =>
                {
                    b.Property<int>("PieceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CID")
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusicSheetLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PieceID");

                    b.HasIndex("CID");

                    b.ToTable("Pieces");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Quartet", b =>
                {
                    b.Property<int>("GID")
                        .HasColumnType("int");

                    b.Property<int>("Cellist")
                        .HasColumnType("int");

                    b.Property<int?>("CellistObjPerformerID")
                        .HasColumnType("int");

                    b.Property<int?>("FViolinistPerformerID")
                        .HasColumnType("int");

                    b.Property<int>("FirstViolin")
                        .HasColumnType("int");

                    b.Property<int?>("SViolinistPerformerID")
                        .HasColumnType("int");

                    b.Property<int>("SecondViolin")
                        .HasColumnType("int");

                    b.Property<int>("Violist")
                        .HasColumnType("int");

                    b.Property<int?>("ViolistObjPerformerID")
                        .HasColumnType("int");

                    b.HasKey("GID");

                    b.HasIndex("CellistObjPerformerID");

                    b.HasIndex("FViolinistPerformerID");

                    b.HasIndex("SViolinistPerformerID");

                    b.HasIndex("ViolistObjPerformerID");

                    b.ToTable("Quartet");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.SoloPerforms", b =>
                {
                    b.Property<int>("SpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PerfID")
                        .HasColumnType("int");

                    b.Property<int>("PerformerID")
                        .HasColumnType("int");

                    b.HasKey("SpID");

                    b.HasIndex("PerfID");

                    b.HasIndex("PerformerID");

                    b.ToTable("SoloPerformsS");
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

                    b.Property<int>("Cellist")
                        .HasColumnType("int");

                    b.Property<int?>("CellistObjPerformerID")
                        .HasColumnType("int");

                    b.Property<int>("Pianist")
                        .HasColumnType("int");

                    b.Property<int?>("PianistObjPerformerID")
                        .HasColumnType("int");

                    b.Property<int>("Violinist")
                        .HasColumnType("int");

                    b.Property<int?>("ViolinistObjPerformerID")
                        .HasColumnType("int");

                    b.HasKey("GID");

                    b.HasIndex("CellistObjPerformerID");

                    b.HasIndex("PianistObjPerformerID");

                    b.HasIndex("ViolinistObjPerformerID");

                    b.ToTable("Trios");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Violinist", b =>
                {
                    b.Property<int>("PerformerID")
                        .HasColumnType("int");

                    b.HasKey("PerformerID");

                    b.ToTable("Violinists");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Violist", b =>
                {
                    b.Property<int>("PerformerID")
                        .HasColumnType("int");

                    b.HasKey("PerformerID");

                    b.ToTable("Violists");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.composerCanEdit", b =>
                {
                    b.Property<int>("CceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdminID")
                        .HasColumnType("int");

                    b.Property<int>("CID")
                        .HasColumnType("int");

                    b.HasKey("CceID");

                    b.HasIndex("AdminID");

                    b.HasIndex("CID");

                    b.ToTable("ComposerCanEdits");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.CanView", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestID")
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
                        .HasForeignKey("PerformerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.GroupCanEdit", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminID")
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
                        .HasForeignKey("PerformerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Piece", "Piece")
                        .WithMany()
                        .HasForeignKey("PieceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");

                    b.Navigation("Piece");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Manages", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminID")
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
                        .HasForeignKey("PieceID")
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
                        .HasForeignKey("PerformerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Piece", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Composer", "Composer")
                        .WithMany()
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Composer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Quartet", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Cellist", "CellistObj")
                        .WithMany()
                        .HasForeignKey("CellistObjPerformerID");

                    b.HasOne("MusicMakerProgram.Models.Violinist", "FViolinist")
                        .WithMany()
                        .HasForeignKey("FViolinistPerformerID");

                    b.HasOne("MusicMakerProgram.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("GID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Violinist", "SViolinist")
                        .WithMany()
                        .HasForeignKey("SViolinistPerformerID");

                    b.HasOne("MusicMakerProgram.Models.Violist", "ViolistObj")
                        .WithMany()
                        .HasForeignKey("ViolistObjPerformerID");

                    b.Navigation("CellistObj");

                    b.Navigation("FViolinist");

                    b.Navigation("SViolinist");

                    b.Navigation("Team");

                    b.Navigation("ViolistObj");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.SoloPerforms", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Performance", "Performance")
                        .WithMany()
                        .HasForeignKey("PerfID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("PerformerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performance");

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Trio", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Cellist", "CellistObj")
                        .WithMany()
                        .HasForeignKey("CellistObjPerformerID");

                    b.HasOne("MusicMakerProgram.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("GID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Pianist", "PianistObj")
                        .WithMany()
                        .HasForeignKey("PianistObjPerformerID");

                    b.HasOne("MusicMakerProgram.Models.Violinist", "ViolinistObj")
                        .WithMany()
                        .HasForeignKey("ViolinistObjPerformerID");

                    b.Navigation("CellistObj");

                    b.Navigation("PianistObj");

                    b.Navigation("Team");

                    b.Navigation("ViolinistObj");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Violinist", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("PerformerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Violist", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Performer", "Performer")
                        .WithMany()
                        .HasForeignKey("PerformerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.composerCanEdit", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Composer", "Composer")
                        .WithMany()
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Composer");
                });
#pragma warning restore 612, 618
        }
    }
}
