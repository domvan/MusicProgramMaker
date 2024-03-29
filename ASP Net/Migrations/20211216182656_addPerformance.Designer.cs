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
    [Migration("20211216182656_addPerformance")]
    partial class addPerformance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicMakerProgram.Models.Performance", b =>
                {
                    b.Property<int>("perfID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("pID")
                        .HasColumnType("int");

                    b.Property<string>("piece_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("perfID");

                    b.ToTable("Performances");
                });
#pragma warning restore 612, 618
        }
    }
}
