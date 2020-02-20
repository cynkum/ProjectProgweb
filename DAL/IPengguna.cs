using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.DAL {
    public interface IPengguna{
        IEnumerable<Pengguna> GetAll();
        Pengguna GetById(string Username);
        void Insert(Pengguna pengguna);
        void Registrasi(Pengguna pengguna);
        Pengguna CekLogin(string username, string password);
    }
}