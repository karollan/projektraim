using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROJEKT.FormModels
{
    public class HistoryModel
    {
        public int Id { get; set; }
        [Required]
        public string HPV { get; set; }
        [Required]
        public string Flu { get; set; }
        [Required]
        public string Chickenpox { get; set; }

        public int UserId { get; set; }
    }
}
