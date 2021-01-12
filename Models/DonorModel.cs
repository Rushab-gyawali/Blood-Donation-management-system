using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blood_Donation_Management_System.Models
{
    public class DonorModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength (255)]
        public string DonorName { get; set; }

        public string DonorAddress { get; set; }

        public string Email { get; set; }

        [Required]
        public string MobileNo { get; set; }

        public string TelephoneNo { get; set; }

        [Required]
        public DateTime? PreviouslyDonatedDate { get; set; }



        public Gender_Model Genders { get; set; }

        [Display(Name = "Gender ")]
        public byte GenderId { get; set; }

       


        [Required]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string BloodGroup { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}