using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantsuvõistlusMVC.Models
{
    public class Võistlus
    {
        public int Id { get; set; }
        [StringLength(64)]
        [Required]
        [Display(Name = "Tantsupaar")]
        public string Tantsupaari_Nimi { get; set; }
        [Range(0, 5)]
        [Display(Name = "I Voor")]
        public int Voor1 { get; set; } = 0;
        [Range(0, 5)]
        [Display(Name = "II Voor")]
        public int Voor2 { get; set; } = 0;
        [Range(0, 5)]
        [Display(Name = "III Voor")]
        public int Voor3 { get; set; } = 0;
        public int KeskmineHinne { get; set; } = 0;
    }
}
