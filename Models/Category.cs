using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Category
    {
        [Key] //Primary key
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Display order")]  //в cshtml tag-helper (label asp-for = "name")
        public string DisplayOrder { get; set; }
    }
}
