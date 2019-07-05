using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace GenericPopulator
{
   public partial class _Default : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!this.IsPostBack)
         {
            using (var conn = new SqlConnection(@WebConfigurationManager.ConnectionStrings["northwind"].ConnectionString))
            {
               conn.Open();
               var query = "select * from Employees order by LastName, FirstName";
               var cmd = new SqlCommand(query, conn);
               using (var reader = cmd.ExecuteReader())
               {
                  //var employeeList = new Classes.EmployeePopulator().CreateList(reader);  
                  //var employeeList = new Classes.GenericPopulator<Models.Employee>().CreateList(reader);
                  var employeeList = new Classes.ReflectionPopulator<Models.Employee>().CreateList(reader);
                  rptEmployees.DataSource = employeeList;
                  rptEmployees.DataBind();

                  reader.Close();
               }
               conn.Close();
            }
         }
      }
   }
}