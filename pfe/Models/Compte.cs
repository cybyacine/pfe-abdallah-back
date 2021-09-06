using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class Compte
    {
        [Key]
        public int CompteId { get; set; }

        [Column]
        public string CO { get; set; }

        [Column]
        public string Lib { get; set; }

        [Column]
        public bool DB { get; set; }

        [Column]
        public bool CR { get; set; }

        [Column]
        public string TypeCompte { get; set; }

        [Column]
        public string CompteDB { get; set; }

        [Column]
        public string OuvertDB { get; set; }

        [Column]
        public string OuvertCR { get; set; }
    }
}
