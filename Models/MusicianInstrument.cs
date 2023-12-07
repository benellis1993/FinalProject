using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class MusicianInstrument
    {
        public int MusicianInstrumentId {get; set;} // Primary Key
        public int MusicianId {get; set;} // Foreign Key for Musician.
        public Musician? Musician {get; set;}

        public int InstrumentId {get; set;} // Foreign Key for Instrument.
        public Instrument? Instrument {get; set;}
    }
}