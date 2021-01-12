using Blood_Donation_Management_System.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blood_Donation_Management_System.ViewModel;

namespace Blood_Donation_Management_System.Controllers
{
    public class StaffController : Controller
    {
      


        private ApplicationDbContext _context;

        public StaffController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            
            return View("StaffForm");
        }

        public ViewResult Index()
        {
            var staff = _context.staffs.ToList();
            return View(staff);
        }

        [HttpPost]
        public ActionResult Save(StaffModel staff)
        {
            if (staff.Id == 0)
                _context.staffs.Add(staff);
            else
            {
                var staffInDb = _context.staffs.Single(s => s.Id == staff.Id);
                staffInDb.StaffName = staff.StaffName;
                staffInDb.StaffAddress = staff.StaffAddress;
                staffInDb.Email = staff.Email;
                staffInDb.MobileNo = staff.MobileNo;
                staffInDb.DesignationId = staff.DesignationId;
                staffInDb.Username = staff.Username;
                staffInDb.Password = staff.Password;

            }
                _context.SaveChanges();

                return RedirectToAction("Index", "Staff");
            
        }

            public ActionResult Details(int id)
        {
            var staff = _context.staffs.SingleOrDefault(s => s.Id == id);
            if (staff == null)
                return HttpNotFound();

            return View(staff);
        }

        public ActionResult Edit(int id)
        {
            var staff = _context.staffs.SingleOrDefault(s => s.Id == id);

            if (staff == null)
                return HttpNotFound();

            var viewModel = new StaffNewViewModel
            {
                staff = staff
           
            };

            return View("StaffForm", viewModel);
        }

    }
}