using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string ClientName { get; set; }
        public string ClientStatus { get; set; }
        public string CompanyName { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
