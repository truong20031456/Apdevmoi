using BookShop.Data;
using BookShop.Models;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
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
<<<<<<< HEAD
        [Authorize(Roles = "Customer")]
=======
>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
        public IActionResult Index()
        {
            var jobListings = _context.JobListingModel.ToList();
            return View(jobListings);
        }
<<<<<<< HEAD
        [Area("Customer")]
        [Authorize(Roles = "Customer")]
=======

>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
        public IActionResult JobDetails(int id)
        {
            var job = _context.JobListingModel.FirstOrDefault(j => j.JobListingId == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }
<<<<<<< HEAD
        [Area("Customer")]
        [Authorize(Roles = "Customer")]
=======


>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
        [HttpPost]
        public IActionResult Apply(JobListingModel model)
        {
            if (ModelState.IsValid)
            {
<<<<<<< HEAD
                // Logic to handle job application submission and file upload to the database
                // For simplicity, assume the file upload is successful

                // Set the flag to indicate that the image has been uploaded
                model.ImageUploaded = true;

                // You can set ViewBag.ApplySuccess to true if the submission is successful
                ViewBag.ApplySuccess = true;

=======
                // Logic to handle job application submission
                // You can access model.JobId and model.Resume here
>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
                return RedirectToAction("Index");
            }
            else
            {
<<<<<<< HEAD
                // If model validation fails, return to the same view with the model to display validation errors
                return View("JobDetails", model);
            }
        }
=======
                // If model validation fails, return to the JobDetails view with the model to display validation errors
                return View("JobDetails", model);
            }
        }

>>>>>>> a5d40dac69ad7c2a6688862db1c94f0182431905
    }
}
