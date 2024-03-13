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
        ICourseRepository courseRepository = null;
        IChapterRepository chapterRepository = null;
        ILessonRepository lessonRepository = null;

        public ChapterController()
        {
            courseRepository = new CourseRepository();
            chapterRepository = new ChapterRepository();
            lessonRepository = new LessonRepository();
        }
        //Get LearnerController
       public ActionResult Index(int courseId)
{
    ViewBag.CourseId = courseId;
    var course = courseRepository.GetCourseByID(courseId);
    ViewBag.CourseName = course.CourseName;

    // Lấy danh sách tất cả các chương từ repository
    var chapterList = chapterRepository.GetChapters();

    // Tìm tất cả các chương có CourseId trùng khớp với courseId
    var chaptersToDisplay = chapterList.Where(c => c.CourseId == courseId);
    var lessonList = lessonRepository.GetLessons();
    
    // Trả về view, truyền danh sách chương và danh sách bài học để hiển thị
    return View(Tuple.Create(chaptersToDisplay, lessonList));
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
public ActionResult Create(Chapter chapter, bool redirectToCreateLesson, int courseId)
{
    try
    {
        if (ModelState.IsValid)
        {
            // Kiểm tra điều kiện cho thuộc tính ChapterName
            if (!string.IsNullOrEmpty(chapter.ChapterName))
            {
                // Kiểm tra điều kiện cho thuộc tính Index
                if (chapter.Index.HasValue && chapter.Index.Value > 0)
                {
                    // Kiểm tra điều kiện cho thuộc tính Description
                    if (!string.IsNullOrEmpty(chapter.Description))
                    {
                        // Kiểm tra điều kiện cho thuộc tính TotalTime
                        if (chapter.TotalTime.HasValue && chapter.TotalTime.Value > 0)
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
                        else
                        {
                            ModelState.AddModelError("TotalTime", "TotalTime must be a positive value.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Description", "Description is required.");
                    }
                }
                else
                {
                    ModelState.AddModelError("Index", "Index must be a positive value.");
                }
            }
            else
            {
                ModelState.AddModelError("ChapterName", "ChapterName is required.");
            }
        }
    }
    catch (Exception ex)
    {
        ViewBag.Message = ex.Message;
    }

    ViewBag.CourseId = courseId;
    var course = courseRepository.GetCourseByID(courseId);
    ViewBag.CourseName = course.CourseName;
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