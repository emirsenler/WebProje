using Person.Models;
using Person.Services.İnterfaces;
using System;
using System.Data.SqlClient;
using System.Net;

namespace Person.Services
{
    public class PersonService : IPerson
    {
        SqlConnection con;
        public PersonService()
        {
            con = new SqlConnection("11;");
        }
        public PersonModel.Return login(PersonModel.request personobj)
        {
            PersonModel.Return result = new PersonModel.Return()
            {
                data = null,
                status = false,
                StatusCode = HttpStatusCode.OK,
            };
            con.Open();

            SqlCommand cmd = new SqlCommand("select UserName,Password from t_Person where UserName=@username and Password=@password", con);
            cmd.Parameters.AddWithValue("@username", personobj.UserName);
            cmd.Parameters.AddWithValue("@password", personobj.Password);

            var dr = cmd.ExecuteReader();
            PersonModel.ReturnData data = new PersonModel.ReturnData();
            if (dr.Read())
            {
                data.UserName = dr["UserName"].ToString();
                data.Password = dr["Password"].ToString();
            }


            con.Close();

            if (personobj.UserName == data.UserName && personobj.Password == data.Password)
            {
                result.status = true;
                
            }
            return result;
        }
    }
}
