using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.Models;
using WebLibrary.Models;
using WebLibrary.Repository;
namespace Project_Group3.Controllers
{

    public class LessonController : Controller
    {

        ILessonRepository lessonRepository = null;
        IChapterRepository chapterRepository = null;
        ICourseRepository courseRepository = null;
        public LessonController()
        {
            lessonRepository = new LessonRepository();
            chapterRepository = new ChapterRepository();
            courseRepository = new CourseRepository();
        }


        public ActionResult Index(int chapterId, int courseId, string search = "")
        {

            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);
            ViewBag.CourseId = courseId;
            ViewBag.ChapterId = chapterId;

            ViewBag.ChapterName = chapter.ChapterName;
            ViewBag.CourseName = course.CourseName;

            var lessonList = lessonRepository.GetLessons();

            // Tìm tất cả các chương có CourseId trùng khớp với courseId
            var lessonsToDisplay = lessonList.Where(l => l.ChapterId == chapterId && l.CourseId == courseId).ToList();

            if (!string.IsNullOrEmpty(search))
            {
                lessonsToDisplay = lessonsToDisplay.Where(l => l.LessonName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
            ViewBag.Search = search;

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
            var course = courseRepository.GetCourseByID(courseId);
            ViewBag.ChapterId = chapterId;
            ViewBag.CourseId = courseId;

            ViewBag.ChapterName = chapter.ChapterName;
            ViewBag.CourseName = course.CourseName;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Lesson lesson, int chapterId, int courseId, IFormFile video)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Kiểm tra điều kiện cho thuộc tính LessonName
                    if (!string.IsNullOrEmpty(lesson.LessonName))
                    {
                        // Kiểm tra điều kiện cho thuộc tính Description
                        if (!string.IsNullOrEmpty(lesson.Description))
                        {
                            // Kiểm tra điều kiện cho thuộc tính Index
                            if (lesson.Index.HasValue && lesson.Index.Value > 0)
                            {
                                if (video == null || video.Length == 0)
                                {
                                    ModelState.AddModelError("Video", "Video is required.");
                                }

                                if (ModelState.IsValid)
                                {
                                    // Handle the video file
                                    var urlRelative = "/video/";
                                    var urlAbsolute = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "video");
                                    var fileName = Guid.NewGuid() + Path.GetExtension(video.FileName);
                                    var filePath = Path.Combine(urlAbsolute, fileName);

                                    using (var stream = new FileStream(filePath, FileMode.Create))
                                    {
                                        video.CopyTo(stream);
                                    }

                                    lesson.Content = Path.Combine(urlRelative, fileName);
                                    lessonRepository.InsertLesson(lesson);

                                    return RedirectToAction("Index", new { chapterId = chapterId, courseId = courseId });
                                }
                            }
                            else
                            {
                                ModelState.AddModelError("Index", "Index must be a positive value.");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Description", "Description is required.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("LessonName", "LessonName is required.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                ViewBag.Message = ex.Message;
            }
            var chapter = chapterRepository.GetChapterByID(chapterId);
            ViewBag.ChapterId = chapterId;
            ViewBag.CourseId = courseId;
            ViewBag.ChapterName = chapter.ChapterName;
            return View(lesson);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var Lesson = lessonRepository.GetLessonByID(id.Value);

            if (Lesson == null) return NotFound();

            return View(new ModelsView { Lesson = Lesson });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModelsView modelsView, IFormFile video)
        {
            try
            {
                var lesson = lessonRepository.GetLessonByID(modelsView.Lesson.LessonId);
                if (lesson != null)
                {
                    if (video != null && video.Length > 0)
                    {
                        // Handle the video file
                        var urlRelative = "/video/";
                        var urlAbsolute = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "video");
                        var fileName = Guid.NewGuid() + Path.GetExtension(video.FileName);
                        var filePath = Path.Combine(urlAbsolute, fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            video.CopyTo(stream);
                        }

                        lesson.Content = Path.Combine(urlRelative, fileName);
                    }

                    // Update other properties of the lesson
                    lesson.LessonName = modelsView.Lesson.LessonName;
                    lesson.Description = modelsView.Lesson.Description;
                    lesson.Content = modelsView.Lesson.Content;
                    lesson.Index = modelsView.Lesson.Index;

                    lessonRepository.UpdateLesson(lesson);
                    return RedirectToAction("Index", new { chapterId = lesson.ChapterId, courseId = lesson.CourseId });
                }

                return View(modelsView);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(modelsView);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var Lesson = lessonRepository.GetLessonByID(id.Value);

            if (Lesson == null) return NotFound();

            return View(new ModelsView { Lesson = Lesson });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ModelsView modelsView)
        {
            try
            {
                var lesson = lessonRepository.GetLessonByID(modelsView.Lesson.LessonId);
                if (lesson != null)
                {
                    lessonRepository.DeleteLesson(lesson.LessonId);
                    return RedirectToAction("Index", new { chapterId = lesson.ChapterId, courseId = lesson.CourseId });
                }
                return View(modelsView);
            }
            catch (Exception ex)

            {
                ViewBag.Message = ex.Message;
                return View(modelsView);
            }

        }
    }
}