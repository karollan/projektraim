using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PROJEKT.FormModels
{
    public class KnowledgeSourceModel
    {
        public int Id { get; set; }
        [Required]
        public string Source { get; set; }

        public int UserId { get; set; }

    }
}
