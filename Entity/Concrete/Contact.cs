using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
