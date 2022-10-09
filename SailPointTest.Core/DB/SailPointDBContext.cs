using Microsoft.EntityFrameworkCore;
using SailPointTest.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SailPointTest.Core.DB
{
    public class SailPointDBContext :DbContext
    {
        public SailPointDBContext()
        {

        }
        public SailPointDBContext(DbContextOptions<SailPointDBContext> options) : base(options)
        {
        }
        public virtual DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer( // This for NUnit testing, a default connection string.
                "Server=DESKTOP-OFU2P4A\\SQLEXPRESS01;Database=SailPoint;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

    }
}
