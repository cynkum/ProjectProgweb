using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleASPCore.Models;

namespace SampleASPCore.Controllers {
    public class RegistrasiController : Controller{
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllAnggota(){
            List<Anggota> lstAnggota = new List<Anggota>();
            lstAnggota.Add(new Anggota {
                Firstname = "Budi",
                Lastname = "Sutejo",
                Address = "Jl Belimbing 11",
                Telp = "55667788"
            });
             lstAnggota.Add(new Anggota {
                Firstname = "Argo",
                Lastname = "Lawu",
                Address = "Jl Mangga 12",
                Telp = "55667799"
            });
            lstAnggota.Add(new Anggota {
                Firstname = "Argo",
                Lastname = "Bromo",
                Address = "Jl Apel 12",
                Telp = "55667711"
            });

            return View(lstAnggota);
        }

        public IActionResult Tampil(Anggota anggota)
        {
            //return Content($"Nama : {anggota.Firstname} {anggota.Lastname}, {anggota.Address}, {anggota.Telp}");
            return View(anggota);
        }
    }
}