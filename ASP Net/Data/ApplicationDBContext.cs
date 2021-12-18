using System;
using Microsoft.EntityFrameworkCore;
using MusicMakerProgram.Models;

//allows us to connect to database
namespace MusicMakerProgram.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        //creates list of DB entries
        public DbSet<Performance> Performances { get; set; }

        public DbSet<Performer> Performers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Composer> Composers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<MusicProgram> Programs { get; set; }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Violinist> Violinists { get; set; }
        public DbSet<Violist> Violists { get; set; }
        public DbSet<Cellist> Cellists { get; set; }
        public DbSet<Pianist> Pianists { get; set; }
        public DbSet<Trio> Trios { get; set; }
        public DbSet<Quartet> Quartet { get; set; }
        public DbSet<GroupCanEdit> GroupCanEdits { get; set; }
        public DbSet<Knows> KnowsS { get; set; }
        public DbSet<Manages> ManagesS { get; set; }
        public DbSet<composerCanEdit> ComposerCanEdits { get; set; }
        public DbSet<CanView> CanViews { get; set; }
        public DbSet<GroupPerforms> GroupPerformsS { get; set; }
        public DbSet<SoloPerforms> SoloPerformsS { get; set; }

    }
}
