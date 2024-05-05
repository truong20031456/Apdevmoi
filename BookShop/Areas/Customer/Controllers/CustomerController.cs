using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BookShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = "Customer")]
    public class CustomerController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerController
    
        public IActionResult Index()
        {
            var jobListings = _context.JobListingModels.ToList();
            return View(jobListings);
        }
       
        public IActionResult JobDetails(int id)
        {
            var job = _context.JobListingModels.FirstOrDefault(j => j.JobListingId == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }
       
        [HttpPost]
        public IActionResult Apply(JobListingModel model)
        {
            if (ModelState.IsValid)
            {
                // Logic to handle job application submission
                // You can access model.JobId and model.Resume here

                // For simplicity, assuming the submission is successful
                return RedirectToAction("Index");
            }
            else
            {
                // If model validation fails, return to the JobDetails view with the model to display validation errors
                return View("JobDetails", model);
            }
        }
    }
}
