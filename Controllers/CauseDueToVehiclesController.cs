using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Reflection;
using Road_Safety.Controllers;

namespace Road_Safety.Controllers
{
    public class CauseDueToVehiclesController : Controller
    {
        private IConfiguration Configuration;

        public CauseDueToVehiclesController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public ActionResult CauseDueToVehicles()
        {
            string connectionString = this.Configuration.GetConnectionString("SQL_Road_Safety");
            DataTable dt1 = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString); 
            
            conn.Open();
            SqlCommand objCmd = conn.CreateCommand();
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = "Vehicle_selectall";
            
            SqlDataReader objSDR = objCmd.ExecuteReader();
            dt1.Load(objSDR);
            conn.Close();

            return View("CauseDueToVehicles",dt1);
        }
    }

}