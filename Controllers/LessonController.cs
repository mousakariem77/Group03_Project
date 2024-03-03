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

    public class LessonController : Controller
    {

        private LessonRepository lessonRepository;
        private ChapterRepository chapterRepository;

        public LessonController()
        {
            lessonRepository = new LessonRepository();
            chapterRepository = new ChapterRepository();
        }

        public ActionResult Index(int chapterId, int? courseId)
        {
            ViewBag.CourseId = courseId;
            ViewBag.ChapterId = chapterId;

            // Lấy danh sách tất cả các chương từ repository
            var lessonList = lessonRepository.GetLessons();

            // Tìm tất cả các chương có CourseId trùng khớp với courseId
            var lessonsToDisplay = lessonList.Where(l => l.ChapterId == chapterId && l.CourseId == courseId).ToList();

            // Trả về view, truyền danh sách chương để hiển thị
            return View(lessonsToDisplay);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Lesson = lessonRepository.GetLessonByID(id.Value);
            if (Lesson == null)
            {
                return NotFound();

            }
            return View(Lesson);
        }
        //Get Learnercontroller/Create  
        public ActionResult Create(int chapterId, int courseId)
        {
            var chapter = chapterRepository.GetChapterByID(chapterId);
            ViewBag.ChapterId = chapterId;
            ViewBag.CourseId = courseId;
            if (chapter == null)
            {
                ViewBag.ChapterName = "Unknown chapter";
                ViewBag.err = "1";
                return View();
            }
            else
            {
                if (string.IsNullOrEmpty(chapter.ChapterName))
                {
                    ViewBag.ChapterName = "Unknown chapter";
                    ViewBag.err = "1";
                    return View();
                }
                else
                {
                    ViewBag.ChapterName = chapter.ChapterName;
                }
            }

            return View();
        }
        //Post: Learnercontroller/ Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Lesson lesson)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    lessonRepository.InsertLesson(lesson);
                    return RedirectToAction("Index", new { chapterId = lesson.ChapterId, courseId = lesson.CourseId });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                ViewBag.Message = ex.Message;
            }

            return View();
        }
        //Get CoureseController/Edit/5

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Lesson = lessonRepository.GetLessonByID(id.Value);
            if (Lesson == null)
            {
                return NotFound();
            }
            return View(Lesson);
        }
        //Post  Learnercontroller/edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Lesson Lesson)
        {
            try
            {
                if (id != Lesson.LessonId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    lessonRepository.UpdateLesson(Lesson);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();

            }
        }
        //Get LearnerController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Lesson = lessonRepository.GetLessonByID(id.Value);
            if (Lesson == null)
            {
                return NotFound();
            }
            return View(Lesson);
        }
        //Post Learnercontroller/delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                lessonRepository.DeleteLesson(id);
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