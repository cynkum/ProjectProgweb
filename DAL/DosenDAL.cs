using System.Collections.Generic;
using System.Data.SqlClient;
using SampleASPCore.Models;
using Microsoft.Extensions.Configuration;
using Dapper;
using System;

namespace SampleASPCore.DAL { 
    public class DosenDAL : IDosen {
        private IConfiguration _config;
        public DosenDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Dosen> GetAll(){
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                string strSql = @"select * from Dosen order by Nama";
                return conn.Query<Dosen>(strSql);
                
                
                /* SqlCommand cmd = new SqlCommand(strSql,conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows){
                    while(dr.Read()){
                        var mhs = new Mahasiswa {
                            Nim = dr["Nim"].ToString(),
                            Nama = dr["Nama"].ToString(),
                            Email = dr["Email"].ToString(),
                            Telp = dr["Telp"].ToString()
                        };
                        lstMahasiswa.Add(mhs);
                    }
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();

                return lstMahasiswa;*/
            }
        }

        public void Delete(string nik){
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"delete from Dosen where Nik=@Nik";
                try{
                    var param = new{nik=nik};
                    conn.Execute(strSql,param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public Dosen GetById(string nik)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Dosen where NIK=@NIK";
                var param = new {nik=nik};
                var data = conn.QuerySingleOrDefault<Dosen>(strSql,param);
                if(data!=null)
                    return data;
                else
                    throw new Exception("Data could not found!");
            }
        }

        public IEnumerable<Dosen> GetDosenByNama(string nama){
                using(SqlConnection conn=new SqlConnection(GetConnStr())){
                string strSql = @"select * from Dosen where Nama like @Nama";
                var param = new {Nama="%"+nama+"%"};
                return conn.Query<Dosen>(strSql,param);
 
        }
    }

        public void Insert(Dosen dos)
        {
            using(SqlConnection conn=new SqlConnection(GetConnStr())){
                var strSql=@"insert into Dosen(Nik,Nama,Alamat,Jurusan) values(@Nik,@Nama,@Alamat,@Jurusan)";
                try{
                    var param  = new{Nik=dos.Nik,Nama=dos.Nama,Alamat=dos.Alamat,Jurusan=dos.Jurusan};
                    conn.Execute(strSql, param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Dosen dos)
        {
            using(SqlConnection conn=new SqlConnection(GetConnStr())){
                var strSql = @"update Dosen set Nama=@Nama, Alamat=@Alamat, Jurusan=@Jurusan
                where Nik=@Nik";
                try{
                    var param = new{Nama=dos.Nama, Alamat=dos.Alamat, Jurusan=dos.Jurusan, Nik=dos.Nik};
                    conn.Execute(strSql, param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
        }
    }

        public IEnumerable<Dosen> GetDosenByNik(string nik)
        {
             using(SqlConnection conn=new SqlConnection(GetConnStr())){
                string strSql = @"select * from Dosen where Nik=@NIK order by Nama";
                var param = new {nik=nik};
                return conn.Query<Dosen>(strSql,param);
        }
        }
    }
}