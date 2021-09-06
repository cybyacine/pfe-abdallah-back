using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class DepBancaire
    {
        [Key]
        public int DepBanId { get; set; }

        [Column]
        public string Date { get; set; }

        [Column]
        public string NCH { get; set; }

        [Column]
        public string CO { get; set; }

        [Column]
        public string Tiers { get; set; }

        [Column]
        public string Montant { get; set; }

        [Column]
        public string Libelle { get; set; }

        [Column]
        public string MVT { get; set; }
    }
}
