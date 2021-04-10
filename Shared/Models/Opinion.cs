using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared.Models
{
    public class Opinion
    {
        public int Id { get; set; }

        public string CompulsoryVaccination { get; set; }

        public string OptionalVaccination { get; set; }

        public string CovidVaccination { get; set; }

        public string CovidVacSafety { get; set; }

        public string DiseaseOrVaccine { get; set; }

        public string InformationTrust { get; set; }

        public int UserId { get; set; }
    }
}