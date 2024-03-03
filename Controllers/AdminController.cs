using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebLibrary.Models;
using WebLibrary.Repository;

namespace Project_Group3.Controllers
{
    
    public class AdminController : Controller
    {
      
         AdminRepository adminRepository = null;
        public AdminController() => adminRepository = new AdminRepository();
        //Get LearnerController
        public ActionResult Index()
        {
            var Adminlist = adminRepository.GetAdmins();
            return View(Adminlist);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Admin= adminRepository.GetAdminByID(id.Value);
            if (Admin== null)
            {
                return NotFound();

            }
            return View(Admin);
        }
        //Get Learnercontroller/Create  
        public ActionResult Create() => View();
        //Post: Learnercontroller/ Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admin Admin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    adminRepository.InsertAdmin(Admin);

                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(Admin);
            }

        }
        //Get CoureseController/Edit/5

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Admin= adminRepository.GetAdminByID(id.Value);
            if (Admin== null)
            {
                return NotFound();
            }
            return View(Admin);
        }
        //Post  Learnercontroller/edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Admin Admin)
        {
            try
            {
                if (id != Admin.AdminId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    adminRepository.UpdateAdmin(Admin);
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
            var Admin= adminRepository.GetAdminByID(id.Value);
            if (Admin== null)
            {
                return NotFound();
            }
            return View(Admin);
        }
        //Post Learnercontroller/delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                adminRepository.DeleteAdmin(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)

            {
                ViewBag.Message = ex.Message;
                return View();
            }

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string pass)
        {
            try
            {
                if (LoginCheck(username, pass))
                {
                    ViewBag.Message = "Login successful";
                    return RedirectToAction("Index","Instructor"); 
                }else{
                    ViewBag.Message = "Login failed. Please check your credentials.";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "An error occurred during login.";
                return View();
            }
        }

        public bool LoginCheck(string username, string pass)
        {
            try
            {
                var admin = adminRepository.GetAdminByUsername(username);
                if (admin != null && adminRepository.CheckLogin(admin.Password, pass))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred during login check.", ex);
            }
        }
    }
}