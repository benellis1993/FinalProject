using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Discography
    {
        public int DiscographyId {get; set;} // Primary Key

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string RecordName {get; set;} = string.Empty;

        public int ReleaseDate {get; set;}

        [Display(Name = "Musician")]
        [Required]
        public int MusicianId {get; set;} // Foreign Key linking Course to Musician
        public Musician? Musician {get; set;}// Navigation Property
    }  
}