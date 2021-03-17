using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricProject.Models
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int positionID { get; set; }
        public Position position { get; set; }
        public int locationID { get; set; }
        public Location location { get; set; } 

    }
}