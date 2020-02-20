
using System.ComponentModel.DataAnnotations;

namespace SampleASPCore.Models{
    public class Dosen{
        [Required(ErrorMessage="Field NIK harus diisi!")]
        
        public string Nik { get; set; }
        [Required]
        public string Nama { get; set; }
        [Required]
        public string Alamat { get; set; }
        [Required]
        public string Jurusan { get; set; }
    }
}