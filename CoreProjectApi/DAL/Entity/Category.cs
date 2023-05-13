using System.ComponentModel.DataAnnotations;

namespace CoreProjectApi.DAL.Entity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
