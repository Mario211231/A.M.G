using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.M.G.Models;
using Microsoft.EntityFrameworkCore;

namespace A.M.G.Data
{
    public class AMGDbContext:DbContext
    {

        public AMGDbContext(DbContextOptions<AMGDbContext> options) : base(options)
        {

        }
    

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AMGActor_Movie>().HasKey(am => new 
                {
                  am.ActorId,
                  am.MovieId

                });
                
            modelBuilder.Entity<AMGActor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<AMGActor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
            base.OnModelCreating(modelBuilder);
        }
    
        public DbSet<AMGActor> Actors { get; set; }
        public DbSet<AMGMovie> Movies { get; set; }
        public DbSet<AMGActor_Movie> Actors_Movies { get; set; }
        public DbSet<AMGCinema> Cinemas { get; set; }
        public DbSet<AMGProducer> Producers { get; set; }
    }


}
