using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Municipality
{
    public class Municipality
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Tax { get; set; }

        public DateTime? CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

    }

    public class MunicipalityContext: DbContext
    {
        public DbSet<Municipality> Municipality { get; set; }

        public MunicipalityContext(DbContextOptions options) : base(options)
        {

        }
    }
}
