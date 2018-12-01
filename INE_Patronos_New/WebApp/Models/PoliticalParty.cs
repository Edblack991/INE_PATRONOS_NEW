using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PoliticalParty
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(50, ErrorMessage = "The field Name must have max length of 30 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Name must be a string")]
        public String Name { get; set; }
        
        [Required(ErrorMessage = "The field Description is required")]
        [StringLength(100, ErrorMessage = "The field Description must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Description must be a string")]
        public String Description { get; set; }
        
        [Required(ErrorMessage = "The field Foundation is required")]
        [StringLength(100, ErrorMessage = "The field Foundation must have max length of 100 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Foundation must be a string")]
        public String Foundation { get; set; }

        public virtual ICollection<President> Presidents { get; set; }
        public virtual ICollection<Governor> Governors { get; set; }
        public virtual ICollection<Mayor> Mayors { get; set; }
    }
}