using System;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Category
    {
        [Key] //Primary key
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayOrder { get; set; }
    }
}
