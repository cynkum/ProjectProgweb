using SampleASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace SampleASPCore.Controllers {
    public class KategoriController : Controller{
        private IKategori _kat;
        public KategoriController(IKategori kat){
            _kat = kat;
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
            var data = _kat.GetAll();
            return View(data);
        }
         [HttpPost]
         public IActionResult Search(string keyword, string pilih){
             IEnumerable<Kategori> data;
             if(pilih=="KategoriID"){
                 data = _kat.GetKategoriById(keyword);
             }
             else if(pilih=="KategoriName"){
                 data = _kat.GetKategoriByName(keyword);
             }
             else{
                 data = _kat.GetAll();
             }
             return View("Index", data);
         }

        public IActionResult Details(string id){
            var data = _kat.GetById(id);
            return View(data);
        }
        
        [HttpPost]
         public IActionResult Edit(Kategori kat){
             try{
                 _kat.Update(kat);
                 ViewData["pesan"]="<span class='alert alert-success'>Data Updated</span>";
                 return View("Details",kat);
             }
             catch(Exception ex){
                 return Content($"Error : {ex.Message}");
             }
         }
        [HttpPost]
         public IActionResult CreatePost(Kategori kat){
             try{
                _kat.Insert(kat);
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
                 _kat.Delete(id);
                 ViewData["pesan"]="<span class='alert alert-success'>Data Deleted</span>";
                 return View("Index",_kat.GetAll());
             }
             catch(Exception ex){
                 return Content($"Error : {ex.Message}");
             }
         }
       
    }
}