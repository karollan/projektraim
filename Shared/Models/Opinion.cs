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

        public string Text { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

    }
}