using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.DAL {
    public interface IDosen
    {
        IEnumerable<Dosen> GetAll();
        Dosen GetById(string Nik);
        void Insert(Dosen dos);
        void Update(Dosen dos);
        void Delete(string Nik);
        IEnumerable<Dosen> GetDosenByNik(string nik);
        IEnumerable<Dosen> GetDosenByNama(string nama);
        
    }
}