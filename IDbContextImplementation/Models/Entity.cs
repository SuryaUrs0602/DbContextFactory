using System.ComponentModel.DataAnnotations;

namespace IDbContextImplementation.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
