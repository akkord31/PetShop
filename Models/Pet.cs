using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Pet name")]
        public string Name { get; set; }
    }
}
