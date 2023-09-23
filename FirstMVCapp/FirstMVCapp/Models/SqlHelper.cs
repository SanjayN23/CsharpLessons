/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;*/

using Microsoft.Data.SqlClient;

namespace FirstMVCApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection() //Factory Method
        {
            var connString = @"server= 200411LTP2848\SQLEXPRESS ;database=TestDb;
                                integrated security=true;Encrypt=false;";
            SqlConnection sqlcn=new SqlConnection(connString);
            return sqlcn;
        } 
        }
    }

