using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }
        public string ExperienceTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
    }
}
