using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.DAL {
    public interface IKategori
    {
        IEnumerable<Kategori> GetAll();
        Kategori GetById(string KategoriID);
        void Insert(Kategori kat);
        void Update(Kategori kat );
        void Delete(string KategoriID);
        IEnumerable<Kategori> GetKategoriById(string KategoriID);
        IEnumerable<Kategori> GetKategoriByName(string nama);
        
    }
}