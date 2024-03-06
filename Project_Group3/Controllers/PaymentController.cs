using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        public IActionResult PaymentSuccess()
        {
            // TODO: Your code here
            return View();
        }




        // [Authorize]

        public IActionResult PaymentCallback()
        {
            var response = _vnpayService.PaymentExcute(Request.Query);
          
            if (response.VnPayResponseCode != "00" && response == null)
            {
               System.Console.WriteLine("faillllllllllllllll ");;
                return RedirectToAction("PaymentFail");
            }
            // luu don hang vao database

           System.Console.WriteLine("succceessssssssssss");
            return RedirectToAction("PaymentSuccess");
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

            PaymentViewModel paymentViewModel = new PaymentViewModel
            {
                courseId = c.CourseId,
                LeanrerId = l.LearnerId,
                courseName = c.CourseName,
                learnerName = l.FirstName + " " + l.LastName,
                Price = c.Price

            };
            return View(paymentViewModel);
        }




        [HttpPost]
        public IActionResult CheckOut(PaymentViewModel paymentViewModel)
        {
            System.Console.WriteLine(paymentViewModel.learnerName);
            // Course course = coureseRepository.GetCourseByID(courseId);
            // Learner learner = learnerRepository.GetLearnerByID(learnId);
            // if (course == null || learner == null)
            // {
            //     return NotFound(); // Trả về lỗi 404 hoặc xử lý lỗi tương ứng khi không tìm thấy khóa học hoặc người học
            // }
            // var Amount = course.Price;
            // var Description = $"{learner.FirstName + learner.LastName}{learner.PhoneNumber}";
            // var Fullname = $"{learner.FirstName + learner.LastName}";
            var VnpayModel = new VnPaymentRequestModel
            {
                Amount = (int)paymentViewModel.Price * 23000,
                CreateDate = DateTime.Now,
                Description = paymentViewModel.courseName,
                Fullname = paymentViewModel.learnerName,
                OrderId = new Random().Next(1000, 100000)


                // Amount = Amount,
                // CreateDate = DateTime.Now,
                // Description = Description,
                // Fullname = Fullname,
                // OrderId = new Random().Next(1000, 100000)

            };
            System.Console.WriteLine(VnpayModel.Description);
            System.Console.WriteLine(VnpayModel.Amount);
            System.Console.WriteLine(VnpayModel.CreateDate);
            System.Console.WriteLine(VnpayModel.Fullname);
            System.Console.WriteLine(VnpayModel.OrderId);




            return Redirect(_vnpayService.CreatePaymentUrl(HttpContext, VnpayModel));
        }
    }



}
