using BookShop.Data;
using BookShop.Models;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Customer")]
        public IActionResult Index()
        {
            var jobListings = _context.JobListingModel.ToList();
            return View(jobListings);
        }
        [Area("Customer")]
        [Authorize(Roles = "Customer")]
        public IActionResult JobDetails(int id)
        {
            var job = _context.JobListingModel.FirstOrDefault(j => j.JobListingId == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }
        [Area("Customer")]
        [Authorize(Roles = "Customer")]
        [HttpPost]
        public IActionResult Apply(JobListingModel model)
        {
            if (ModelState.IsValid)
            {
                // Logic to handle job application submission and file upload to the database
                // For simplicity, assume the file upload is successful

                // Set the flag to indicate that the image has been uploaded
                model.ImageUploaded = true;

                // You can set ViewBag.ApplySuccess to true if the submission is successful
                ViewBag.ApplySuccess = true;

                return RedirectToAction("Index");
            }
            else
            {
                // If model validation fails, return to the same view with the model to display validation errors
                return View("JobDetails", model);
            }
        }
    }
}
