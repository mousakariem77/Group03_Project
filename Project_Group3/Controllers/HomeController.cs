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
        IReviewRepository reviewRepository = null;
        ILessonRepository lessonRepository = null;
        IChapterRepository chapterRepository = null;
        IEnrollmentRepository enrollmentRepository = null;
        
        public HomeController()
        {
            courseRepository = new CourseRepository();
            categoryRepository = new CategoryRepository();
            instructorRepository = new InstructorRepository();
            instructRepository = new InstructRepository();
            learnerRepository = new LearnerRepository();
            reviewRepository = new ReviewRepository();
            lessonRepository = new LessonRepository();
            chapterRepository = new ChapterRepository();
            enrollmentRepository = new EnrollmentRepository();
        }


        public IActionResult Index()
        {
            var categoryList = categoryRepository.GetCategorys()
                .OrderByDescending(c => c.Courses.Count)
                .Take(8)
                .ToList();

            var instructorList = instructorRepository.GetInstructors()
                .Take(4)
                .ToList();

            return View(Tuple.Create(categoryList, instructorList));
        }

        public IActionResult About()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult Course(string search)
        {
            var course = courseRepository.GetCourses();
            var category = categoryRepository.GetCategorys();
            var instruct = instructRepository.GetInstructs();
            var instructor = instructorRepository.GetInstructors();
            var review = reviewRepository.GetReviews();
            var courseList = course.ToList();
            var categoryList = category.ToList();
            var instructList = instruct.ToList();
            var instructorList = instructor.ToList();
            var reviewList = review.ToList();

            if (!string.IsNullOrEmpty(search))
            {
                string lowercaseSearch = search.ToLower();
                courseList = courseList.Where(c => c.CourseName.ToLower().Contains(lowercaseSearch)).ToList();
                ViewBag.search = search;
            }

            return View(Tuple.Create(courseList, categoryList, instructList, instructorList, reviewList));
        }

        public IActionResult Contact()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult Profile(int? id)
        {
            var role = Request.Cookies["Role"];
            System.Console.WriteLine("role" + role);
            if (id == null)
            {
                return NotFound();
            }
            if (role == "0")
            {
                var learner = learnerRepository.GetLearnerByID(id.Value);
                var instructor = instructorRepository.GetInstructorByID(id.Value);
                if (instructor == null)
                {
                    return NotFound();
                }
                ViewBag.Role = "instructor";

                return View(Tuple.Create(instructor, learner));
            }
            else if (role == "1")
            {
                var learner = learnerRepository.GetLearnerByID(id.Value);
                var instructor = instructorRepository.GetInstructorByID(id.Value);
                var enrollment = enrollmentRepository.GetEnrollment();

                if (learner == null)
                {
                    return NotFound();
                }
                ViewBag.Role = "learner";

                return View(Tuple.Create(instructor, learner, enrollment));
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Profile(int id, Learner learner)
        {
            try
            {
                if (id != learner.LearnerId)
                {
                    System.Console.WriteLine(id + " " + learner.Username);
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    learnerRepository.UpdateLearner(learner);
                }
                return RedirectToAction("Profile", "Home", new { id = learner.LearnerId });
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        public IActionResult CourseDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var instruct = instructRepository.GetInstructByID(id.Value);
            if (instruct == null)
            {
                return NotFound();
            }
            var courseId = TempData["CourseId"] as string;
            var course = courseRepository.GetCourses();
            var instructor = instructorRepository.GetInstructors();
            var review = reviewRepository.GetReviews();
            var learner = learnerRepository.GetLearners();
            var chapter = chapterRepository.GetChapters();
            var lesson = lessonRepository.GetLessons();
            var enrollment = enrollmentRepository.GetEnrollment();

            var courseInfo = course.FirstOrDefault(c => c.CourseId == instruct.CourseId);
            var instructorInfo = instructor.FirstOrDefault(i => i.InstructorId == instruct.InstructorId);
            ViewBag.CourseID = id;
            return View(Tuple.Create(courseInfo, instructorInfo, review, learner, chapter, lesson, enrollment));
        }

        public IActionResult Learning(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var course = courseRepository.GetCourseByID(id.Value);
            if (course == null)
            {
                return NotFound();
            }

            var chapter = chapterRepository.GetChapters();
            var lesson = lessonRepository.GetLessons();
            return View(Tuple.Create(course, chapter, lesson));
        }

        public IActionResult CheckOut(int? id)
        {
            var learner = learnerRepository.GetLearnerByID(id.Value);

            return View(learner);
        }

    }
}
