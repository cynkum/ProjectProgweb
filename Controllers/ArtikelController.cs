using SampleASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.DAL;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace SampleASPCore.Controllers {
    public class ArtikelController : Controller{
        private IArtikel _art;
        public ArtikelController(IArtikel art){
            _art = art;
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
            var data = _art.GetAll();
            return View(data);
        }
         [HttpPost]
         public IActionResult Search(string keyword, string pilih){
             IEnumerable<Artikel> data;
             if(pilih=="ArtikelID"){
                 data = _art.GetArtikelById(keyword);
             }
             else if(pilih=="Judul"){
                 data = _art.GetArtikelByName(keyword);
             }
             else if(pilih=="Username"){
                 data = _art.GetArtikelByPenulis(keyword);
             }
             else{
                 data = _art.GetAll();
             }
             return View("Index", data);
         }

        public IActionResult Details(string id){
            var data = _art.GetById(id);
            return View(data);
        }
        
        [HttpPost]
         public IActionResult Edit(Artikel art){
             try{
                 _art.Update(art);
                 ViewData["pesan"]="<span class='alert alert-success'>Data Updated</span>";
                 return View("Details",art);
             }
             catch(Exception ex){
                 return Content($"Error : {ex.Message}");
             }
         }
        [HttpPost]
         public IActionResult CreatePost(Artikel art){
             try{
                _art.Insert(art);
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
                 _art.Delete(id);
                 ViewData["pesan"]="<span class='alert alert-success'>Data Deleted</span>";
                 return View("Index",_art.GetAll());
             }
             catch(Exception ex){
                 return Content($"Error : {ex.Message}");
             }
         }
       
    }
}