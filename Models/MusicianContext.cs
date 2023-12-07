using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    	public class MusicianDbContext : DbContext
	{
		public MusicianDbContext (DbContextOptions<MusicianDbContext> options)
			: base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configuring the many-to-many relationship
            modelBuilder.Entity<MusicianInstrument>()
                .HasKey(mi => new {mi.MusicianInstrumentId});
                
            modelBuilder.Entity<MusicianInstrument>()
                .HasOne(mi => mi.Musician)
                .WithMany(m => m.MusicianInstruments)
                .HasForeignKey(mi => mi.MusicianId);

            modelBuilder.Entity<MusicianInstrument>()
                .HasOne(mi => mi.Instrument)
                .WithMany(i => i.MusicianInstruments)
                .HasForeignKey(mi => mi.InstrumentId);
        }
		public DbSet<Musician> Musicians {get; set;} = default!;
		public DbSet<Instrument> Instruments {get; set;} = default!;
        public DbSet<Discography> Discographys {get; set;} = default!;
        public DbSet<MusicianInstrument> MusicianInstruments {get; set;} = default!;
	}
}