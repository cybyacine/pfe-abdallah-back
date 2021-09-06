using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class GestContext : DbContext
    {

        public GestContext(DbContextOptions<GestContext> options) : base(options)
        {

        }


        public DbSet<Compte> Comptes { get; set; }
        public DbSet<DepBancaire> DepBancaires { get; set; }
        public DbSet<DepCaisse> DepCaisses { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<RecBancaire> RecBancaires { get; set; }
        public DbSet<RecCaisse> RecCaisses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
