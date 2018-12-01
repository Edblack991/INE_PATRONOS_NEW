using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Citizen
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(15, ErrorMessage = "The field Name must have max length of 15 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Name must be a string")]
        public String Name { get; set; }

        [Required(ErrorMessage = "The field LastNameFather is required")]
        [StringLength(30, ErrorMessage = "The field LastNameFather must have max length of 30 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field LastNameFather must be a string")]
        public String LastNameFather { get; set; }

        [Required(ErrorMessage = "The field LastNameMother is required")]
        [StringLength(30, ErrorMessage = "The field LastNameMother must have max length of 15 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field LastNameMother must be a string")]
        public String LastNameMother { get; set; }

        [Required(ErrorMessage = "The field Address is required")]
        [StringLength(100, ErrorMessage = "The field Address must have max length of 15 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Address must be a string")]
        public String Address { get; set; }

        [Required(ErrorMessage = "The field ElectroKey is required")]
        [StringLength(20, ErrorMessage = "The field ElectroKey must have max length of 20 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field ElectroKey must be a string")]
        public String ElectroKey { get; set; }

        [Required(ErrorMessage = "The field CURP is required")]
        [StringLength(25, ErrorMessage = "The field CURP must have max length of 25 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field CURP must be a string")]
        public String CURP { get; set; }

        [Required(ErrorMessage = "The field BirthDate is required")]
        [StringLength(25, ErrorMessage = "The field BIRTHDATE must have max length of 25 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field BIRTHDATE must be a string")]
        public String BirthDate { get; set; }

        [Required(ErrorMessage = "The field YearRegistration is required")]
        [StringLength(4, ErrorMessage = "The field YearRegistration must have max length of 4 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field YearRegistration must be a string")]
        public String YearRegistration { get; set; }

        [ForeignKey("StateProvince")]
        [Required(ErrorMessage = "The field StateProvinceId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field StateProvinceId must be a number.")]
        public int StateProvinceId { get; set; }
        public StateProvince StateProvince { get; set; }

        [ForeignKey("City")]
        [Required(ErrorMessage = "The field CityId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field CityId must be a number.")]
        public int CityId { get; set; }
        public City City { get; set; }

        [Required(ErrorMessage = "The field Section is required")]
        [StringLength(6, ErrorMessage = "The field Section must have max length of 6 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Section must be a string")]
        public String Section { get; set; }

        [Required(ErrorMessage = "The field Localization is required")]
        [StringLength(1, ErrorMessage = "The field Localization must have max length of 1 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Localization must be a string")]
        public String Localization { get; set; }

        [Required(ErrorMessage = "The field Issue is required")]
        [StringLength(4, ErrorMessage = "The field Issue must have max length of 4 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Issue must be a string")]
        public String Issue { get; set; }

        [Required(ErrorMessage = "The field Validiti is required")]
        [StringLength(4, ErrorMessage = "The field Validity must have max length of 4 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Validity must be a string")]
        public String Validity { get; set; }

        [Required(ErrorMessage = "The field Gender is required")]
        [StringLength(1, ErrorMessage = "The field Gender must have max length of 15 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Gender must be a string")]
        public String Gender { get; set; }

        [Required(ErrorMessage = "The field CIC is required")]
        [StringLength(15, ErrorMessage = "The field CIC must have max length of 15 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field CIC must be a string")]
        public String CIC { get; set; }
    }
}