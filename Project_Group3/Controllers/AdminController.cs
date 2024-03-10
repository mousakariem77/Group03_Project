using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.Models;
using WebLibrary.DAO;
using WebLibrary.Models;
using WebLibrary.Repository;

namespace Project_Group3.Controllers
{
    public class AdminController : Controller
    {
      
        AdminRepository adminRepository = null;
        IInstructorRepository instructorRepository = null;
        ICourseRepository courseRepository = null;
        ICategoryRepository categoryRepository = null;
        IInstructRepository instructRepository = null;
        ILearnerRepository learnerRepository = null;
        public AdminController() {
            adminRepository = new AdminRepository();
            courseRepository = new CourseRepository();
            categoryRepository = new CategoryRepository();
            instructorRepository = new InstructorRepository();
            instructRepository = new InstructRepository();
            learnerRepository = new LearnerRepository();
        } 

        public ActionResult Index()
        {
            var Adminlist = adminRepository.GetAdmins();
            var learner = learnerRepository.GetLearners();
            var instructor = instructorRepository.GetInstructors();
            var course = courseRepository.GetCourses();
            return View(Tuple.Create(Adminlist, learner, instructor, course));
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Admin= adminRepository.GetAdminByID(id.Value);
            if (Admin== null)
            {
                return NotFound();

            }
            return View(Admin);
        }

        public ActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admin Admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    adminRepository.InsertAdmin(Admin);

                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(Admin);
            }

        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Admin= adminRepository.GetAdminByID(id.Value);
            if (Admin== null)
            {
                return NotFound();
            }
            return View(Admin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Admin Admin)
        {
            try
            {
                if (id != Admin.AdminId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    adminRepository.UpdateAdmin(Admin);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();

            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Admin= adminRepository.GetAdminByID(id.Value);
            if (Admin== null)
            {
                return NotFound();
            }
            return View(Admin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                adminRepository.DeleteAdmin(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)

            {
                ViewBag.Message = ex.Message;
                return View();
            }

        }

        public IActionResult Login()
        {
            if(HttpContext.Session.GetString("admin") !=null) return RedirectToAction("Index", "Home");
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            try
            {
                var admin = adminRepository.GetAdminByUsername(Username);
                System.Console.WriteLine(Password);
                if (admin != null && admin.Password == Password)
                {
                    HttpContext.Session.SetString("admin", Username);
                    ViewBag.Message = "Login successful";
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.Message = "Login failed. Please check your credentials.";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "An error occurred during login.";
                return View();
            }
        }

        public IActionResult Instructor()
        {
            var instructorList = instructorRepository.GetInstructors();
            return View(instructorList);
        }   
        
        public IActionResult Learner()
        {
            var learnerList = learnerRepository.GetLearners();
            return View(learnerList);
        }

        public IActionResult Course()
        {
            var course = courseRepository.GetCourses();
            var category = categoryRepository.GetCategorys();
            var instruct = instructRepository.GetInstructs();
            var instructor = instructorRepository.GetInstructors();
            var courseList = course.ToList();
            var categoryList = category.ToList();
            var instructList = instruct.ToList();
            var instructorList = instructor.ToList();
            return View(Tuple.Create(courseList, categoryList, instructList, instructorList));
        }

        public IActionResult UserDetail(int? id, string role)
        {
            if(id == null){
                return NotFound();
            }
            var instructor = instructorRepository.GetInstructorByID(id.Value);
            var learner = learnerRepository.GetLearnerByID(id.Value);
            if(role.Equals("instructor")){
                if(instructor == null){
                    return NotFound();
                }
                ViewBag.Role = role;
            }else if(role.Equals("learner")){
                if(learner == null){
                    return NotFound();
                }
                ViewBag.Role = role;
            }
            
            return View(Tuple.Create(instructor, learner));
        }  

        [HttpPost]
        public IActionResult Next(int id, string role)
        {
            if (role.Equals("instructor"))
            {
                var currentInstructor = instructorRepository.GetInstructorByID(id);
                var nextInstructor = instructorRepository.GetInstructors().FirstOrDefault(i => i.InstructorId > id);

                if (nextInstructor != null)
                {
                    return RedirectToAction("UserDetail", new { id = nextInstructor.InstructorId, role = role });
                }
                else
                {
                    var firstInstructor = instructorRepository.GetInstructors().FirstOrDefault();
                    return RedirectToAction("UserDetail", new { id = firstInstructor.InstructorId, role = role });
                }
            }
            else if (role.Equals("learner"))
            {
                var currentLearner = learnerRepository.GetLearnerByID(id);
                var nextLearner = learnerRepository.GetLearners().FirstOrDefault(l => l.LearnerId > id);

                if (nextLearner != null)
                {
                    return RedirectToAction("UserDetail", new { id = nextLearner.LearnerId, role = role });
                }
                else
                {
                    var firstLearner = learnerRepository.GetLearners().FirstOrDefault();
                    return RedirectToAction("UserDetail", new { id = firstLearner.LearnerId, role = role });
                }
            }

            return NotFound();
        }
        
        [HttpPost]
        public IActionResult Previous(int id, string role)
        {
            if (role.Equals("instructor"))
            {
                var currentInstructor = instructorRepository.GetInstructorByID(id);
                var previousInstructor = instructorRepository.GetInstructors().LastOrDefault(i => i.InstructorId < id);

                if (previousInstructor != null)
                {
                    return RedirectToAction("UserDetail", new { id = previousInstructor.InstructorId, role = role });
                }
                else
                {
                    var lastInstructor = instructorRepository.GetInstructors().LastOrDefault();
                    return RedirectToAction("UserDetail", new { id = lastInstructor.InstructorId, role = role });
                }
            }
            else if (role.Equals("learner"))
            {
                var currentLearner = learnerRepository.GetLearnerByID(id);
                var previousLearner = learnerRepository.GetLearners().LastOrDefault(l => l.LearnerId < id);

                if (previousLearner != null)
                {
                    return RedirectToAction("UserDetail", new { id = previousLearner.LearnerId, role = role });
                }
                else
                {
                    var lastLearner = learnerRepository.GetLearners().LastOrDefault();
                    return RedirectToAction("UserDetail", new { id = lastLearner.LearnerId, role = role });
                }
            }

            return NotFound();
        } 

        public IActionResult Logout()
        {
            // Xóa cookie
            foreach (var cookie in HttpContext.Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }

            // Xóa session
            HttpContext.Session.Clear(); // Hoặc HttpContext.Session.Remove("UserId");

            // Chuyển hướng đến trang login hoặc trang chính
            return RedirectToAction("Login", "Admin");
        }
    }
}