﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicMakerProgram.Data;

namespace MusicMakerProgram.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211217151812_updatePKs")]
    partial class updatePKs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicMakerProgram.Models.Composer", b =>
                {
                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Period")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CName");

                    b.ToTable("Composer");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.MusicProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumPerformers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MusicProgram");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Performance", b =>
                {
                    b.Property<int>("PerfID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PID")
                        .HasColumnType("int");

                    b.Property<string>("Perf_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Piece_name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PerfID");

                    b.HasIndex("PID");

                    b.HasIndex("Piece_name");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Piece", b =>
                {
                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("C_name")
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

                    b.ToTable("Piece");
                });

            modelBuilder.Entity("MusicMakerProgram.Models.Performance", b =>
                {
                    b.HasOne("MusicMakerProgram.Models.MusicProgram", "Program")
                        .WithMany()
                        .HasForeignKey("PID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicMakerProgram.Models.Piece", "Piece")
                        .WithMany()
                        .HasForeignKey("Piece_name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Piece");

                    b.Navigation("Program");
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
#pragma warning restore 612, 618
        }
    }
}
