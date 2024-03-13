using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebLibrary.Models;
using WebLibrary.Repository;
namespace Project_Group3.Controllers
{
    
    public class CourseController : Controller
    {
    
        ICourseRepository courseRepository = null;
        ICategoryRepository categoryRepository = null;
        IChapterRepository chapterRepository = null;
        ILessonRepository lessonRepository = null;
        IInstructorRepository instructorRepository = null;
        IInstructRepository instructRepository = null;
        public CourseController()
        {
            courseRepository = new CourseRepository();
            categoryRepository = new CategoryRepository();
            chapterRepository = new ChapterRepository();
            lessonRepository = new LessonRepository();
            instructorRepository = new InstructorRepository();
            instructRepository = new InstructRepository();
        }

        public IActionResult Index(int id, string search = "", int page = 1, int pageSize = 10)
        {
            var courseList = courseRepository.GetCourses();
            var chapterList = chapterRepository.GetChapters();
            var categoryList = categoryRepository.GetCategorys();
            var instruct = instructRepository.GetInstructs();

            var instructor = instructorRepository.GetInstructorByID(id);
            if (instructor == null) 
            {
                return NotFound(); 

            }

            if (!string.IsNullOrEmpty(search))
            {
                courseList = courseList.Where(i => i.CourseName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            ViewBag.Search = search;
            var totalCount = courseList.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            // courseList = courseList.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.PageSize = pageSize;
            ViewBag.TotalPages = totalPages;
            ViewBag.Quantity = totalCount;
            ViewBag.CurrentPage = page;
            return View(Tuple.Create(courseList, chapterList, categoryList, instructor, instruct));
        }


        
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var course= courseRepository.GetCourseByID(id.Value);
            var chapterList = chapterRepository.GetChapters();
            var lessonList = lessonRepository.GetLessons();
            var categoryList = categoryRepository.GetCategorys();
            var instruct = instructRepository.GetInstructs();
            if (course== null)
            {
                return NotFound();

            }
            return View(Tuple.Create(course, chapterList, categoryList, instruct, lessonList));
        }
  
        public ActionResult Create()
        {
            var categoryList = categoryRepository.GetCategorys();
            ViewBag.CategoryList = new SelectList(categoryList, "CategoryId", "CategoryName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Course course, IFormFile picture)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Check other conditions
                    if (course.StartDate > course.EndDate)
                    {
                        ModelState.AddModelError("StartDate", "Start date must be earlier than end date.");
                        ModelState.AddModelError("EndDate", "End date must be later than start date.");
                    }

                    // Add conditions for additional properties
                    if (string.IsNullOrEmpty(course.CourseName))
                    {
                        ModelState.AddModelError("CourseName", "Course name is required.");
                    }

                    if (string.IsNullOrEmpty(course.Description))
                    {
                        ModelState.AddModelError("Description", "Description is required.");
                    }

                    if (picture == null || picture.Length == 0)
                    {
                        ModelState.AddModelError("Picture", "Picture is required.");
                    }

                    if (course.TotalTime == null)
                    {
                        ModelState.AddModelError("TotalTime", "Total time is required.");
                    }

                    if (course.Price == null)
                    {
                        ModelState.AddModelError("Price", "Price is required.");
                    }

                    if (string.IsNullOrEmpty(course.Status))
                    {
                        ModelState.AddModelError("Status", "Status is required.");
                    }

                    if (ModelState.IsValid)
                    {
                        // Handle the image file
                        var urlRelative = "/img/courseImg/";
                        var urlAbsolute = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "courseImg");
                        var fileName = Guid.NewGuid() + Path.GetExtension(picture.FileName);
                        var filePath = Path.Combine(urlAbsolute, fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            picture.CopyTo(stream);
                        }

                        // Update the course object with the new image path
                        course.Picture = Path.Combine(urlRelative, fileName);

                        courseRepository.InsertCourse(course);
                        return RedirectToAction("Create", "Chapter", new { courseId = course.CourseId });
                    }
                }

                ViewBag.CategoryId = course.CategoryId; // Truyền CategoryId vào ViewBag
                var categoryList = categoryRepository.GetCategorys();
                ViewBag.CategoryList = new SelectList(categoryList, "CategoryId", "CategoryName");
                return View(course);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(course);
            }
        }

        
        // public IActionResult Edit(int id)
        // {
        //   System.Console.WriteLine(id);
        //     return View();
        // }
        
        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Course= courseRepository.GetCourseByID(id.Value);
            if (Course== null)
            {
                return NotFound();
            }
            return View(Course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                if (id != course.CourseId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    courseRepository.UpdateCourse(course);
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
            var course= courseRepository.GetCourseByID(id.Value);
            if (course== null)
            {
                return NotFound();
            }
            return View(course);
        }
        //Post Learnercontroller/delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                courseRepository.DeleteCourse(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)

            {
                ViewBag.Message = ex.Message;
                return View();
            }

        }
    }
}