using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.DAL {
    public interface IArtikel
    {
        IEnumerable<Artikel> GetAll();
        Artikel GetById(string id);
        void Insert(Artikel art);
        void Update(Artikel art);
        void Delete(string ArtikelID);
        IEnumerable<Artikel> GetArtikelById(string ArtikelID);
        IEnumerable<Artikel> GetArtikelByName(string judul);
        IEnumerable<Artikel> GetArtikelByPenulis(string penulis);

        
    }
}