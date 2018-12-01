using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class VotePresident
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "The field datatime is required")]
        public DateTime DataTime { get; set; }

        [ForeignKey ("President")]
        [Required(ErrorMessage = "The field CveEnt is required")]
        public int IdPresident { get; set; }
        public President President { get; set; }
    }
}