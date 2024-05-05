using BookShop.Data;
using BookShop.Models;
using BookShop.Repository;
using BookShop.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: UserController
        public IActionResult Index()
        {
            // Retrieve all users
            IEnumerable<ApplicationUser> users = _unitOfWork.ApplicationUsers.GetAll();
            return View(users);
        }

        // GET: UserController
        

        // GET: UserController/Details/5
        public IActionResult Details(int id)
        {
            // Your logic to retrieve user details should be here
            return View();
        }

        // GET: UserController/Create
        public IActionResult Create()
        {
            // Redirect to the registration page
            return Redirect("~/Identity/Account/Register");
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // Your logic to create a new user should be here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            // Your logic to retrieve user for editing should be here
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // Your logic to update user details should be here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            // Your logic to retrieve user for deletion should be here
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // Your logic to delete user should be here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
