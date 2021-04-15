using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROJEKT.FormModels
{
    public class OpinionModel
    {
        public int Id { get; set; }
        [Required]
        public string CompulsoryVaccination { get; set; }
        [Required]
        public string OptionalVaccination { get; set; }
        [Required]
        public string CovidVaccination { get; set; }
        [Required]
        public string CovidVacSafety { get; set; }
        [Required]
        public string DiseaseOrVaccine { get; set; }
        [Required]
        public string InformationTrust { get; set; }
        public int UserId { get; set; }
    }
}