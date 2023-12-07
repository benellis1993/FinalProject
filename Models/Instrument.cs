using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Instrument
    {
        public int InstrumentId {get; set;} // Primary Key

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string InstrumentName {get; set;} = string.Empty;
        
        public List<MusicianInstrument> MusicianInstruments { get; set; } = new List<MusicianInstrument>(); // Navigation to MusicianInstrument
    }  
}