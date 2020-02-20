using System.Collections.Generic;
using System.Data.SqlClient;
using SampleASPCore.Models;
using Microsoft.Extensions.Configuration;
using Dapper;
using System;

namespace SampleASPCore.DAL { 
    public class ArtikelDAL : IArtikel  {
        private IConfiguration _config;
        public ArtikelDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Artikel> GetAll(){
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                string strSql = @"select * from Artikel order by ArtikelID";
                return conn.Query<Artikel>(strSql); 
               
            }
        }

        public void Delete(string ArtikelID){
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"delete from Artikel where ArtikelID=@ArtikelID";
                try{
                    var param = new{ArtikelID=ArtikelID};
                    conn.Execute(strSql,param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public Artikel GetById(string ArtikelID)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Artikel where ArtikelID=@ArtikelID";
                var param = new {ArtikelID=ArtikelID};
                var data = conn.QuerySingleOrDefault<Artikel>(strSql,param);
                if(data!=null)
                    return data;
                else
                    throw new Exception("Data could not found!");
            }
        }

        public IEnumerable<Artikel> GetArtikelByName(string Judul){
                using(SqlConnection conn=new SqlConnection(GetConnStr())){
                string strSql = @"select * from Artikel where Judul like @Judul";
                var param = new {Judul="%"+Judul+"%"};
                return conn.Query<Artikel>(strSql,param);
 
        }
        }
        public IEnumerable<Artikel> GetArtikelByPenulis(string Username){
                using(SqlConnection conn=new SqlConnection(GetConnStr())){
                string strSql = @"select * from Artikel where Username like @Username";
                var param = new {Username="%"+Username+"%"};
                return conn.Query<Artikel>(strSql,param);
 
        }
        
    }

        public void Insert(Artikel art)
        {
            using(SqlConnection conn=new SqlConnection(GetConnStr())){
                var strSql=@"insert into Artikel(ArtikelID, KategoriID, Judul, Berita, Tanggal, Gambar, Username) values(@ArtikelID, @KategoriID, @Judul, @Berita, @Tanggal, @Gambar, @Username)";
                try{
                    var param  = new{ArtikelID=art.ArtikelID, KategoriID=art.KategoriID, Judul=art.Judul, Berita=art.Berita, Tanggal=art.Tanggal, Gambar=art.Gambar, Username=art.Username};
                    conn.Execute(strSql, param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Artikel art)
        {
            using(SqlConnection conn=new SqlConnection(GetConnStr())){
                var strSql = @"update Artikel set  KategoriID=@KategoriID, Judul=@Judul, Berita=@Berita, Tanggal=@Tanggal, Gambar=@Gambar, Username=@Username
                where ArtikelID=@ArtikelID";
                try{
                    var param = new{ArtikelID=art.ArtikelID, KategoriID=art.KategoriID, Judul=art.Judul, Berita=art.Berita, Tanggal=art.Tanggal, Gambar=art.Gambar, Username=art.Username};
                    conn.Execute(strSql, param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
        }
    }

        public IEnumerable<Artikel> GetArtikelById(string ArtikelID)
        {
             using(SqlConnection conn=new SqlConnection(GetConnStr())){
                string strSql = @"select * from Artikel where ArtikelID=@ArtikelID order by Judul";
                var param = new {ArtikelID=ArtikelID};
                return conn.Query<Artikel>(strSql,param);
        }
        }

        
    }
}