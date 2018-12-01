using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.ViewModels
{
    public class CitizenViewModels
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field ElectroKey is required")]
        [DataType(DataType.Text, ErrorMessage = "The field ElectroKey must be a string")]
        public String ElectroKey { get; set; }

        [Required(ErrorMessage = "The field CIC is required")]
        [DataType(DataType.Text, ErrorMessage = "The field CIC must be a string")]
        public String CIC { get; set; }
    }
}