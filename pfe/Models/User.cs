using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column]
        public string UserName { get; set; }

        [Column]
        public string Email { get; set; }

        [Column]
        public string FullName { get; set; }

        [Column]
        public string Password { get; set; }

    }
}
