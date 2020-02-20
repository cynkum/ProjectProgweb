using System.Collections.Generic;
using System.Data.SqlClient;
using SampleASPCore.Models;
using Microsoft.Extensions.Configuration;
using Dapper;
using System;

namespace SampleASPCore.DAL { 
    public class KategoriDAL : IKategori {
        private IConfiguration _config;
        public KategoriDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Kategori> GetAll(){
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                string strSql = @"select * from Kategori order by KategoriID";
                return conn.Query<Kategori>(strSql); 
               
            }
        }

        public void Delete(string KategoriID){
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"delete from Kategori where KategoriID=@KategoriID";
                try{
                    var param = new{KategoriID=KategoriID};
                    conn.Execute(strSql,param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public Kategori GetById(string KategoriID)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Kategori where KategoriID=@KategoriID";
                var param = new {KategoriID=KategoriID};
                var data = conn.QuerySingleOrDefault<Kategori>(strSql,param);
                if(data!=null)
                    return data;
                else
                    throw new Exception("Data could not found!");
            }
        }

        public IEnumerable<Kategori> GetKategoriByName(string KategoriName){
                using(SqlConnection conn=new SqlConnection(GetConnStr())){
                string strSql = @"select * from Kategori where KategoriName like @KategoriName";
                var param = new {KategoriName="%"+KategoriName+"%"};
                return conn.Query<Kategori>(strSql,param);
 
        }
    }

        public void Insert(Kategori kat)
        {
            using(SqlConnection conn=new SqlConnection(GetConnStr())){
                var strSql=@"insert into Kategori(KategoriID, KategoriName) values(@KategoriID,@KategoriName)";
                try{
                    var param  = new{KategoriID=kat.KategoriID, KategoriName=kat.KategoriName};
                    conn.Execute(strSql, param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Kategori kat)
        {
            using(SqlConnection conn=new SqlConnection(GetConnStr())){
                var strSql = @"update Kategori set KategoriName=@KategoriName
                where KategoriID=@KategoriID";
                try{
                    var param = new{KategoriName=kat.KategoriName, KategoriID=kat.KategoriID};
                    conn.Execute(strSql, param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
        }
    }

        public IEnumerable<Kategori> GetKategoriById(string KategoriID)
        {
             using(SqlConnection conn=new SqlConnection(GetConnStr())){
                string strSql = @"select * from Kategori where KategoriID=@KategoriID order by KategoriName";
                var param = new {KategoriID=KategoriID};
                return conn.Query<Kategori>(strSql,param);
        }
        }


    }
}