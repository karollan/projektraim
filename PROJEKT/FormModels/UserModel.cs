using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PROJEKT.FormModels
{
    public class UserModel
    {
        [Required]
        public string Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Student_eti { get; set; }

        [Required]
        public string Education { get; set; }

        public DateTime Started_at { get; set; }

    }
}
