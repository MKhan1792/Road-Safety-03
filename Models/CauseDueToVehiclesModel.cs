using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road_Safety.Models
{
    public class CauseDueToVehiclesModel
    {
        public string States_UTs {get; set;}
        public int? Year {get; set;}
        public string CrimeHead {get; set;}
        public int Offenders_Driver_Pedestrian_Died_Male {get; set;}
        public int Offenders_Driver_Pedestrian_Died_Female {get; set;}
        public int Offenders_Driver_Pedestrian_Died_Transgender {get; set;}
        public int Offenders_Driver_Pedestrian_Died_Total {get; set;}
        public int Victims_Died_Male {get; set;}
        public int Victims_Died_Female {get; set;}
        public int Victims_Died_Transgender {get; set;}
        public int Victims_Died_Total {get; set;}
    }
}