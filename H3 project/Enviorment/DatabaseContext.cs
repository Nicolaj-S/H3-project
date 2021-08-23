using H3_project.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H3_project.Enviorment
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Actor> actor { get; set; }
        public DbSet<Actors> actors { get; set; }
        public DbSet<Admin> admin { get; set;}
        public DbSet<Genre> genre { get; set;}
        public DbSet<Genres> genres{ get; set;}
        public DbSet<Instructor> instructor{ get; set;}
        public DbSet<Language> language{ get; set;}
        public DbSet<Movie> movie{ get; set;}
        public DbSet<PlayTime> playTimes{ get; set;}
        public DbSet<Rating> rating{ get; set;}
        public DbSet<Ticket> ticket{ get; set;}
        public DbSet<User> user{ get; set;}
    }
}
