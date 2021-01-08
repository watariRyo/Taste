using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Taste.Models
{
    public class FoodType
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name="Name")]
        public String Name { get; set; }
    }
}
