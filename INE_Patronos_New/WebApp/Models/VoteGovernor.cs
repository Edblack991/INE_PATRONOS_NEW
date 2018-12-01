using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class VoteGovernor
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "The field datatime is required")]
        public DateTime DataTime { get; set; }

        [ForeignKey("Governor")]
        [Required(ErrorMessage = "The field CveEnt is required")]
        public int IdGovernor { get; set; }
        public Governor Governor { get; set; }

    }
}