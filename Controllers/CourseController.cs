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
        private CourseRepository courseRepository;
        private CategoryRepository categoryRepository;
        private ChapterRepository chapterRepository;
        public CourseController()
        {
            courseRepository = new CourseRepository();
            categoryRepository = new CategoryRepository();
            chapterRepository = new ChapterRepository();
        }
        public IActionResult CourseList()
        {
            var courseList = courseRepository.GetCourses();
            return View(courseList);
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
        if (picture != null && picture.Length > 0)
        {
            // Xử lý tệp tin hình ảnh
            var urlTuongDoi = "/img/courseImg/";
            var urlTuyetDoi = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", "courseImg");
            var fileName = Guid.NewGuid() + Path.GetExtension(picture.FileName);
            var filePath = Path.Combine(urlTuyetDoi, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                picture.CopyTo(stream);
            }
            // Cập nhật đường dẫn hình ảnh mới vào thuộc tính tương ứng trong đối tượng Course
            course.Picture = Path.Combine(urlTuongDoi, fileName);
        }
        
        if (ModelState.IsValid)
        {
            // Kiểm tra các điều kiện khác
            if (course.StartDate > course.EndDate)
            {
                ModelState.AddModelError("EndDate", "End date must be later than start date.");
                return View(course);
            }
            
            courseRepository.InsertCourse(course);
            return RedirectToAction("Create", "Chapter", new { courseId = course.CourseId });
        }

        return View(course);
    }
    catch (Exception ex)
    {
        ViewBag.Message = ex.Message;
        return View(course);
    }
}



        public ActionResult Detail(int? id)
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
            return RedirectToAction("ViewChapters", "Chapter", new { courseId = course.CourseId });
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Course = courseRepository.GetCourseByID(id.Value);
            if (Course == null)
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
                return RedirectToAction(nameof(CourseList));
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
            var course = courseRepository.GetCourseByID(id.Value);
            if (course == null)
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