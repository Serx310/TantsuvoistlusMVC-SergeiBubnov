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
        public string Voor1 { get; set; }
        [Display(Name = "II Voor")]
        public string Voor2 { get; set; }
        [Display(Name = "III Voor")]
        public string Voor3 { get; set; }
        [Display(Name = "Keskmine hinne")]
        public int KeskmineHinne { get; set; }
    }
}
