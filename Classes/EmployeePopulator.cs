using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace GenericPopulator.Classes
{
   public class EmployeePopulator
   {
      public List<Models.Employee> CreateList(SqlDataReader reader)
      {
         List<Models.Employee> result = new List<Models.Employee>();
         while (reader.Read())
         {
            Models.Employee item = new Models.Employee()
            {
               EmployeeID = (int)reader["EmployeeID"],
               FirstName = reader["FirstName"].ToString(),
               LastName = reader["LastName"].ToString(),
               Title = reader["Title"].ToString(),
               BirthDate = (reader["BirthDate"] == DBNull.Value ? (DateTime?)null : (DateTime?)reader["BirthDate"]),
               HireDate = (reader["HireDate"] == DBNull.Value ? (DateTime?)null : (DateTime?)reader["HireDate"]),
               City = reader["City"].ToString()
            };
            result.Add(item);
         }

         return result;
      }
   }
}