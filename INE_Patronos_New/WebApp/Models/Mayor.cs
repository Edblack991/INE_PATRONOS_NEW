using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Mayor
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("PoliticalParty")]
        [Required(ErrorMessage = "The field CveEnt is required")]
        public int PoliticalPartyId { get; set; }
        public PoliticalParty PoliticalParty { get; set; }

        [ForeignKey("City")]
        [Required(ErrorMessage = "The field CveEnt is required")]
        public int CityId { get; set; }
        public City City { get; set; }
        
        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(50, ErrorMessage = "The field Name must have max length of 15 characters")]
        public String Name { get; set; }
        
        [Required(ErrorMessage = "The field LastName is required")]
        [StringLength(30, ErrorMessage = "The field LastName must have max length of 30 characters")]
        public String LastName { get; set; }
        
        [Required(ErrorMessage = "The field Age is required")]
        [StringLength(10, ErrorMessage = "The field Age must have max length of 10 characters")]
        public String Age { get; set; }

        public virtual ICollection<VoteMayor> VoteMayors { get; set; }
    }
}