using Blood_Donation_Management_System.Models;
using Blood_Donation_Management_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blood_Donation_Management_System.Controllers
{
    public class DonorController : Controller
    {
        private ApplicationDbContext _context;

        public DonorController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var donor = _context.donors.ToList();

            return View(donor);

        }

 
        public ActionResult New()
        {
            var genders = _context.genders.ToList();
            var viewModel = new DonorNewViewmodel
            {
               Genders = genders
            };
            return View("DonorForm",viewModel);
        }


        [HttpPost]
        public ActionResult Save(DonorModel donor)    
        {
            if (donor.Id == 0)
                _context.donors.Add(donor);
            else
            {
                var donorInDb = _context.donors.Single(d => d.Id == donor.Id);
                donorInDb.DonorName = donor.DonorName;
                donorInDb.DonorAddress = donor.DonorAddress;
                donorInDb.Email = donor.Email; 
                donorInDb.MobileNo = donor.MobileNo;
                donorInDb.TelephoneNo = donor.TelephoneNo;
                donorInDb.PreviouslyDonatedDate = donor.PreviouslyDonatedDate;
                donorInDb.GenderId = donor.GenderId;
                donorInDb.DateOfBirth = donor.DateOfBirth;
                donorInDb.BloodGroup = donor.BloodGroup;
                donorInDb.CreatedBy = donor.CreatedBy;
                donorInDb.CreatedDate = donor.CreatedDate;
            }
   
           _context.SaveChanges();    
            
           return RedirectToAction("Index", "Donor");
        }


        public ActionResult Details(int id)
        {
            var donor = _context.donors.SingleOrDefault(d => d.Id == id);
            if (donor == null)
                return HttpNotFound();

            return View(donor);

        }

        public ActionResult Edit(int id)
        {
            var donor = _context.donors.SingleOrDefault(d => d.Id == id);

            if (donor == null)
                return HttpNotFound();

            var viewModel = new DonorNewViewmodel
            {
                donor = donor,
                Genders = _context.genders.ToList() 
            };

            return View("DonorForm", viewModel);
        }


        


    }   
}