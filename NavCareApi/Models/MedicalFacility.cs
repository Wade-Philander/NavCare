using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NavCareApi.Models
{
    public class MedicalFacility
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  Id { get; set; }

        public string FacilityName { get; set; }
        public string Description { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
    }
}
