
using System.ComponentModel.DataAnnotations;

namespace SampleASPCore.Models{
    public class Artikel{
        [Required(ErrorMessage="Field ID Artikel harus diisi!")]
        
        public string ArtikelID { get; set; }
        [Required]
        public string KategoriID { get; set; }
        [Required]
        public string Judul { get; set; }
        [Required]
        public string Berita { get; set; }

        [Required]
        public string Tanggal { get; set; }
        [Required]
        public string Gambar { get; set; }
        [Required]
        public string Username { get; set; }
    }
}