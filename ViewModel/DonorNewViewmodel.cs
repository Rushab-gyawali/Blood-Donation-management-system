using Blood_Donation_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blood_Donation_Management_System.ViewModel
{
    public class DonorNewViewmodel
    {
       public IEnumerable<Gender_Model> Genders { get; set; }
       public DonorModel donor { get; set; }
    }
}