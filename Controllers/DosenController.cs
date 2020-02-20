using SampleASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace SampleASPCore.Controllers {
    public class DosenController : Controller{
        private IDosen _dos;
        public DosenController(IDosen dos){
            _dos = dos;
        }
        private bool IsLogin()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CekAturan(string aturan)
        {
            if (HttpContext.Session.GetString("aturan") != null &&
            HttpContext.Session.GetString("aturan") == aturan)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IActionResult Create()
        {
            if (!IsLogin())
            {

                TempData["pesan"] = "<span class='alert alert-danger'>Silahkan Login terlebih dahulu untuk mengakses halaman dosen.</span>";
                return RedirectToAction("Login", "Pengguna");
            }
            else
            {
                if (!CekAturan("admin"))
                {
                    TempData["pesan"] = "<span class='alert alert-danger'>Silahkan login sebagai admin untuk menambahkan data dosen</span>";
                    return RedirectToAction("Login", "Pengguna");
                }

            }

            return View();
        }
        public IActionResult Index(){
            if (!IsLogin())
            {
                TempData["pesan"] = "<span class='alert alert-danger'>Silahkan Login terlebih dahulu untuk mengakses halaman mahasiswa.</span>";
                return RedirectToAction("Login", "Pengguna");
            }
            var data = _dos.GetAll();
            return View(data);
        }
         [HttpPost]
         public IActionResult Search(string keyword, string pilih){
             IEnumerable<Dosen> data;
             if(pilih=="Nik"){
                 data = _dos.GetDosenByNik(keyword);
             }
             else if(pilih=="Nama"){
                 data = _dos.GetDosenByNama(keyword);
             }
             else{
                 data = _dos.GetAll();
             }
             return View("Index", data);
         }

        public IActionResult Details(string id){
            var data = _dos.GetById(id);
            return View(data);
        }
        
        [HttpPost]
         public IActionResult Edit(Dosen dos){
             try{
                 _dos.Update(dos);
                 ViewData["pesan"]="<span class='alert alert-success'>Data Updated</span>";
                 return View("Details");
             }
             catch(Exception ex){
                 return Content($"Error : {ex.Message}");
             }
         }
        [HttpPost]
         public IActionResult CreatePost(Dosen dos){
             try{
                _dos.Insert(dos);
                ViewData["pesan"]="<span class='alert alert-success'>Data Added</span>";
                return View("Create");
             }
             catch(Exception ex){
                 ViewData["pesan"]=$"<span class='alert alert-danger'>Data Not Added, {ex.Message}</span>";
                return View("Create");
             }
         }
        
         public IActionResult Delete(string id){
             try{
                 _dos.Delete(id);
                 ViewData["pesan"]="<span class='alert alert-success'>Data Deleted</span>";
                 return View("Index",_dos.GetAll());
             }
             catch(Exception ex){
                 return Content($"Error : {ex.Message}");
             }
         }
       
    }
}