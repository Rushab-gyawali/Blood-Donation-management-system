using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Blood_Donation_Management_System.Models
{
    public class StaffModel
    {
        public int Id { get; set; }

        public string StaffName { get; set; }

        public string StaffAddress { get; set; }

        public string Email { get; set; }

        public string MobileNo { get; set; }

        public int DesignationId { get; set; } 

        public string Username { get; set; }

        public string Password { get; set; }

    }
}