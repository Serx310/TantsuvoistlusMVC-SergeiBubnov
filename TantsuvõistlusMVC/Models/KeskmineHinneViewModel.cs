using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantsuvõistlusMVC.Models
{
    public class KeskmineHinneViewModel
    {
        public int Id { get; set; }
        [StringLength(64)]
        [Required]
        [Display(Name = "Tantsupaar")]
        public string Tantsupaari_Nimi { get; set; }
        [Display(Name = "I Voor")]
        public int Voor1 { get; set; }
        [Display(Name = "II Voor")]
        public int Voor2 { get; set; }
        [Display(Name = "III Voor")]
        public int Voor3 { get; set; }
        [Display(Name = "Keskmine hinne")]
        public double KeskmineHinne { get; set; }
    }
}
