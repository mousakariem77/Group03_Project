using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.Models;
using Project_Group3.Service;
using WebLibrary.DAO;
using WebLibrary.Models;
using WebLibrary.Repository;
namespace Project_Group3.Controllers
{
    // [Authorize]

    public class PaymentController : Controller
    {
        private readonly IVnpayService _vnpayService;
        ICourseRepository coureseRepository = null;
        ILearnerRepository learnerRepository = null;
        PaymentViewModel paymentViewModel = null;
        // ILearnerRepository ilearner = null;

        public PaymentController(IVnpayService vnpayService)
        {
            _vnpayService = vnpayService;
            coureseRepository = new CourseRepository();
            learnerRepository = new LearnerRepository();
        }



        // [Authorize]
        public IActionResult PaymentFail()
        {
            // TODO: Your code here
            return View();
        }
        // [Authorize]
     



        // [Authorize]

        public IActionResult PaymentCallback()
        {

             int? learnerId = HttpContext.Session.GetInt32("learnerId");
    int? courseId = HttpContext.Session.GetInt32("courseId");
         
            var response = _vnpayService.PaymentExcute(Request.Query);
            if (response == null)
            {
                System.Console.WriteLine("faillllllllllllllll do null"); ;
                return RedirectToAction("PaymentFail");

            }
            enrollmentDAO en = new enrollmentDAO();
              en.AddNew((int)learnerId, (int)courseId);
            System.Console.WriteLine("succceessssssssssss");
            return RedirectToAction("CourseDetail","Home",new{id = courseId});
        }
        public IActionResult saveBill(PaymentViewModel paymentViewModel)
        {


            return View();
        }


        [HttpGet]
        public IActionResult Index(int learnerId, int courseId)
        {
            Course c = coureseRepository.GetCourseByID(courseId);
            Learner l = learnerRepository.GetLearnerByID(learnerId);
            Console.WriteLine("Learner" + learnerId + " Course" + courseId);
            if (l == null || c == null)
            {
                return NotFound(); // Trả về lỗi 404 nếu không tìm thấy người học hoặc khóa học
            }


            HttpContext.Session.SetInt32("learnerId", learnerId);
            HttpContext.Session.SetInt32("courseId", courseId);

            paymentViewModel = new PaymentViewModel
            {
                courseId = c.CourseId,
                LeanrerId = l.LearnerId,
                courseName = c.CourseName,
                learnerName = l.FirstName + " " + l.LastName,
                Price = c.Price,
                Email = l.Email,
                enrollmentDate = DateTime.Now,
                status = "false"
            };

            return View(paymentViewModel);
        }

        [HttpPost]
        public IActionResult CheckOut(PaymentViewModel paymentViewModel)
        {
            var VnpayModel = new VnPaymentRequestModel
            {
                Amount = (int)paymentViewModel.Price * 23000,
                CreateDate = DateTime.Now,
                Description = paymentViewModel.courseName,
                Fullname = paymentViewModel.learnerName,
                OrderId = new Random().Next(1000, 100000)
            };
            System.Console.WriteLine(paymentViewModel.learnerName);
            System.Console.WriteLine(VnpayModel.Description);
            System.Console.WriteLine(VnpayModel.Amount);
            System.Console.WriteLine(VnpayModel.CreateDate);
            System.Console.WriteLine(VnpayModel.Fullname);
            System.Console.WriteLine(VnpayModel.OrderId);
            return Redirect(_vnpayService.CreatePaymentUrl(HttpContext, VnpayModel));
        }
    }


}
