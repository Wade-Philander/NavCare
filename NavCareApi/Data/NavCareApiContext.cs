using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NavCareApi.Models
{
    public class NavCareApiContext : DbContext
    {
        public NavCareApiContext (DbContextOptions<NavCareApiContext> options)
            : base(options)
        {
        }

        public DbSet<NavCareApi.Models.MedicalFacility> MedicalFacilities { get; set; }
    
    }
}
