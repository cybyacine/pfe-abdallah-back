using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Column]
        public string CardOwnerName { get; set; }

        [Column]
        public string CardNumber { get; set; }

        [Column]
        public string Email { get; set; }

        [Column]
        public string Phone { get; set; }
    }
}
