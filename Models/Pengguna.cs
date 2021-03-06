using System.ComponentModel.DataAnnotations;

namespace SampleASPCore.Models {
    public class Pengguna{
        [Required]
        public string Username {get;set;}
        [Required]
        public string Password {get;set;}
        [Compare("Password")]
        public string Repassword{get;set;}
        [Required]
        public string Aturan {get;set;}
        [Required]
        public string Nama {get;set;}
        [Required]
        public string Telp {get;set;}
    }
}