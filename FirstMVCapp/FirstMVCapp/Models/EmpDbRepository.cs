using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class EmpDbRepository
    {
        public static List<Emp> GetEmpList() {
            List<Emp> emplist = new List<Emp>();
            using(SqlConnection cn =SqlHelper.CreateConnection())//'using' is used to close the connection automatically
            {
                if(cn.State !=System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                string selectAllEmps = "Select * from emptb";
                selectempcmd.CommandText=selectAllEmps;
                SqlDataReader empdr =selectempcmd.ExecuteReader();//execute query
                while (empdr.Read())
                {
                    Emp emp =new Emp()
                    {
                        eno = empdr.GetInt32(0),
                        name =empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)  
                    };
                    emplist.Add(emp);
                }
            }
            return emplist;
        }
        public static Emp GetEmpById(int id) {
            Emp empFound = null;
            using(SqlConnection cn = SqlHelper.CreateConnection())
            {
                if(cn.State  !=ConnectionState.Open) { 
                cn.Open();
            }
                SqlCommand selectempcmd=cn.CreateCommand();
                string selectEmps = "Select * from emptb where eno=@id";//@id means parameter
                selectempcmd.Parameters .Add("@id",SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectEmps;
                SqlDataReader empdr=selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new Emp
                    {
                        eno = empdr.GetInt32(0),
                        name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)
                    };
                }
            }
            return empFound;
        }
        public static int AddNewEmp(Emp newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptb values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.eno;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.name;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.city;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.salary;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public  static int UpdateEmo(Emp modifiedEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptb set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.eno;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.name;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.city;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.salary;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
            
        }
        public static int DeleteEmp(int id) 
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptb where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
           
        }
    }
}
