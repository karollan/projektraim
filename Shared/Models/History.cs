using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared.Models
{
    public class History
    {
        public string HPV { get; set; }
        public string Flu { get; set; }
        public string Chickenpox { get; set; }
    }
}
