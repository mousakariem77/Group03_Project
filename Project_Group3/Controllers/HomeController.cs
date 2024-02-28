using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.Models;
using WebLibrary.DAO;
using WebLibrary.Models;
using WebLibrary.Repository;

namespace Project_Group3.Controllers
{
    public class HomeController : Controller
    {
       IInstructorRepository instructorRepository = null;
        ICourseRepository courseRepository = null;
        ICategoryRepository categoryRepository = null;
        IInstructRepository instructRepository = null;
        ILearnerRepository learnerRepository = null;
        public HomeController() {
            courseRepository = new CourseRepository();
            categoryRepository = new CategoryRepository();
            instructorRepository = new InstructorRepository();
            instructRepository = new InstructRepository();
            learnerRepository = new LearnerRepository();
        }
            

        public IActionResult Index()
        {

            var category = categoryRepository.GetCategorys();
            var categoryList = category.Take(8).ToList();
            var instructor = instructorRepository.GetInstructors();
            var instructorList = instructor.Take(4).ToList();

            return View(Tuple.Create(categoryList, instructorList));
        }

        public IActionResult About()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult Course()
        {
            var course = courseRepository.GetCourses();
            var category = categoryRepository.GetCategorys();
            var courseList = course.ToList();
            var categoryList = category.ToList();
            return View(Tuple.Create(courseList, categoryList));
        }
        
        public IActionResult Contact()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult Infomation()
        {
            
            return View();
        }

        public IActionResult CourseDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var instruct = instructRepository.GetInstructByID(id.Value);
            if (instruct== null)
            {
                return NotFound();
            }
            var course = courseRepository.GetCourses();
            var instructor = instructorRepository.GetInstructors();
            
            var courseInfo = course.FirstOrDefault(c => c.CourseId == instruct.CourseId);
            var instructorInfo = instructor.FirstOrDefault(i => i.InstructorId == instruct.InstructorId);


            return View(Tuple.Create(courseInfo, instructorInfo));
        }
        
        
    }
}
