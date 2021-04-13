using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared.Models
{
    public class KnowledgeSource
    {
        public int Id { get; set; }

        public string Source { get; set; }

        public int UserId { get; set; }

    }
}
