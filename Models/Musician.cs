using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Musician
    {
        public int MusicianId {get; set;} // Primary Key

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string MusicianName {get; set;} = string.Empty;

        public string Website {get; set;} = string.Empty;

        public List<MusicianInstrument> MusicianInstruments { get; set; } = new List<MusicianInstrument>();
        public List<Discography> Discography {get; set;} = new List<Discography>(); // Navigation Property to Discography.
        public List<Instrument> Instrument {get; set;} = new List<Instrument>(); // Navigation Property to Instrument. 
    }  
}