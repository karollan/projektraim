using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public string Student_eti { get; set; }

        public string Education { get; set; }

        public DateTime Started_at { get; set; }

        public DateTime Completed_at { get; set; }

        public virtual Result Result { get; set; }

        public virtual Opinion Opinion { get; set; }

        public virtual History History { get; set; }

        public virtual KnowledgeSource KnowledgeSource { get; set; }
    }

}
