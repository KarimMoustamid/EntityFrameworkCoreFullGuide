namespace EF.Data
{
    using Domain;
    using Microsoft.EntityFrameworkCore;

    public class FootballLeagueDbContext : DbContext
    {
        public FootballLeagueDbContext(DbContextOptions<FootballLeagueDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        // public DbSet<League> Leagues { get; set; }
        // public DbSet<Match> Matches { get; set; }
        // public DbSet<TeamsAndLeaguesView> TeamsAndLeaguesView { get; set; }
        // public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EFDB;User Id=SA;Password=B5uf1g8p29;");
        }
    }
}