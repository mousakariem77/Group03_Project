using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebLibrary.Models;
using WebLibrary.Repository;
namespace Project_Group3.Controllers
{

    public class ChapterController : Controller
    {
        private CourseRepository courseRepository;
        private ChapterRepository chapterRepository;

        public ChapterController()
        {
            courseRepository = new CourseRepository();
            chapterRepository = new ChapterRepository();
        }
        //Get LearnerController
        public ActionResult Index(int courseId)
        {
            ViewBag.CourseId = courseId;
            // Lấy danh sách tất cả các chương từ repository
            var chapterList = chapterRepository.GetChapters();

            // Tìm tất cả các chương có CourseId trùng khớp với courseId
            var chaptersToDisplay = chapterList.Where(c => c.CourseId == courseId).ToList();

            // Trả về view, truyền danh sách chương để hiển thị
            return View(chaptersToDisplay);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Chapter = chapterRepository.GetChapterByID(id.Value);
            if (Chapter == null)
            {
                return NotFound();

            }
            return View(Chapter);
        }



        public ActionResult Create(int courseId)
        {
            var course = courseRepository.GetCourseByID(courseId);
            ViewBag.CourseId = courseId;
            if (course == null)
            {
                // Xử lý khi không tìm thấy khóa học
                ViewBag.CourseId = courseId;
                ViewBag.CourseName = "Unknown Course";
                // Hoặc xử lý lỗi theo ý muốn của bạn
            }
            else
            {
                ViewBag.CourseId = courseId;
                if (string.IsNullOrEmpty(course.CourseName))
                {
                    // Xử lý khi tên khóa học là null hoặc trống
                    ViewBag.CourseName = "Unknown Course";
                    // Hoặc xử lý lỗi theo ý muốn của bạn
                }
                else
                {
                    ViewBag.CourseName = course.CourseName;
                }
            }

            return View();
        }
        //Post: Learnercontroller/ Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chapter chapter, bool redirectToCreateLesson)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    chapterRepository.InsertChapter(chapter);

                    if (redirectToCreateLesson)
                    {
                        return RedirectToAction("Create", "Lesson", new { chapterId = chapter.ChapterId, courseId = chapter.CourseId });
                    }
                    else
                    {

                        return RedirectToAction("Index", new { courseId = chapter.CourseId });
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return View(chapter);
        }
        //Get CoureseController/Edit/5

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Chapter = chapterRepository.GetChapterByID(id.Value);
            if (Chapter == null)
            {
                return NotFound();
            }
            return View(Chapter);
        }
        //Post  Learnercontroller/edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Chapter Chapter)
        {
            try
            {
                if (id != Chapter.ChapterId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    chapterRepository.UpdateChapter(Chapter);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();

            }
        }

        public ActionResult ViewCourseChapters(int courseId)
        {
            var course = courseRepository.GetCourseByID(courseId);

            return View();
        }
        //Get LearnerController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Chapter = chapterRepository.GetChapterByID(id.Value);
            if (Chapter == null)
            {
                return NotFound();
            }
            return View(Chapter);
        }
        //Post Learnercontroller/delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                chapterRepository.DeleteChapter(id);
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