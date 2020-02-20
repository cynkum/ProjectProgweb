
using System.ComponentModel.DataAnnotations;

namespace SampleASPCore.Models{
    public class Kategori{
        [Required(ErrorMessage="Field Kategori ID harus diisi!")]
        
        public string KategoriID { get; set; }
        [Required]
        public string KategoriName { get; set; }
    }
}