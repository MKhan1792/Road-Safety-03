using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Reflection;
using Road_Safety.Controllers;

namespace Road_Safety.Controllers
{
    public class NoOfCasualitiesController : Controller
    {
        private IConfiguration Configuration;

        public NoOfCasualitiesController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public ActionResult NoOfCasualities()
        {
            string connectionString = this.Configuration.GetConnectionString("SQL_Road_Safety");
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString); 
            
            conn.Open();
            SqlCommand objCmd = conn.CreateCommand();
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.CommandText = "pr_selectall";
            
            SqlDataReader objSDR = objCmd.ExecuteReader();
            dt.Load(objSDR);
            conn.Close();

            return View("NoOfCasualities",dt);
        }
    }

}