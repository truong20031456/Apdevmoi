using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Customer.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerController
        [Area("Customer")]
        public IActionResult Index()
        {
            var jobListings = _context.JobListingModel.ToList();
            return View(jobListings);
        }

        public IActionResult JobDetails(int id)
        {
            var job = _context.JobListingModel.FirstOrDefault(j => j.JobListingId == id);
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
