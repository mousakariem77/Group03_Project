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

    public class QuizController : Controller
    {
        IQuizRepository quizRepository = null;
        IAnswerRepository answerRepository = null;
        IChapterRepository chapterRepository = null;
        ICourseRepository courseRepository = null;


        public QuizController()
        {
            quizRepository = new QuizRepository();
            answerRepository = new AnswerRepository();
            chapterRepository = new ChapterRepository();
            courseRepository = new CourseRepository();
        }

        // GET: Quiz


        // GET: Quiz/Detail/5
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = quizRepository.GetQuizByID(id.Value);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }
        // GET: Quiz
        public ActionResult Index(int chapterId, int courseId)
        {
            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);
            ViewBag.CourseId = courseId;
            ViewBag.ChapterId = chapterId;
            ViewBag.ChapterName = chapter.ChapterName;
            ViewBag.CourseName = course.CourseName;
            var quizList = quizRepository.GetQuizzes();
            var answerList = answerRepository.GetAnswers();
            var model = Tuple.Create(quizList, answerList);
            return View(model);
        }
        // GET: Quiz/Create
        public ActionResult Create(int chapterId, int courseId)
        {
            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);

            if (chapter == null || course == null)
            {
                // Handle the case when either chapter or course is null
                // For example, you can return an error message or redirect to an error page
                return RedirectToAction("Error");
            }

            ViewBag.ChapterId = chapterId;
            ViewBag.CourseId = courseId;
            ViewBag.ChapterName = chapter.ChapterName;
            ViewBag.CourseName = course.CourseName;
            ViewBag.Answers = answerRepository.GetAnswers();
            return View();
        }

        // POST: Quiz/Create
     [HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(Quiz quiz, int chapterId, int courseId)
{
    try
    {
        if (ModelState.IsValid)
        {
            // Additional validation for properties
            if (string.IsNullOrEmpty(quiz.Quiz1))
            {
                ModelState.AddModelError("Quiz1", "Quiz1 is required.");
            }

            if (string.IsNullOrEmpty(quiz.DapAnA))
            {
                ModelState.AddModelError("DapAnA", "DapAnA is required.");
            }

            if (string.IsNullOrEmpty(quiz.DapAnB))
            {
                ModelState.AddModelError("DapAnB", "DapAnB is required.");
            }

            if (string.IsNullOrEmpty(quiz.DapAnC))
            {
                ModelState.AddModelError("DapAnC", "DapAnC is required.");
            }

            if (string.IsNullOrEmpty(quiz.DapAnD))
            {
                ModelState.AddModelError("DapAnD", "DapAnD is required.");
            }

            // Check the selected value of the dropdown "DapAn"
              if (quiz.AnswerId == 0)
            {
                ModelState.AddModelError("AnswerId", "Please select an answer.");
            }


            if (ModelState.IsValid)
            {
                quizRepository.InsertQuiz(quiz);
                return RedirectToAction("Index", new { chapterId = chapterId, courseId = courseId });
            }
        }

        var answerList = answerRepository.GetAnswers();
        ViewBag.Answers = new SelectList(answerList, "AnswerId", "Answer1");
        return View(quiz);
    }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                var chapter = chapterRepository.GetChapterByID(chapterId);
                var course = courseRepository.GetCourseByID(courseId);
                ViewBag.CourseId = courseId;
                ViewBag.ChapterId = chapterId;
                ViewBag.ChapterName = chapter.ChapterName;
                ViewBag.CourseName = course.CourseName;
                var answerList = answerRepository.GetAnswers();
                ViewBag.Answers = new SelectList(answerList, "AnswerId", "Answer1");
                return View(quiz);
            }
        }




        // GET: Quiz/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = quizRepository.GetQuizByID(id.Value);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        // POST: Quiz/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Quiz quiz)
        {
            try
            {
                if (id != quiz.QuizId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    quizRepository.UpdateQuiz(quiz);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: Quiz/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quiz = quizRepository.GetQuizByID(id.Value);
            if (quiz == null)
            {
                return NotFound();
            }

            return View(quiz);
        }

        // POST: Quiz/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                quizRepository.DeleteQuiz(id);
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
