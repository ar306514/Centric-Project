using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricProject.Models
{
    public class Location
    {
        public int locationID { get; set; }
        public string location { get; set; }
        public ICollection<Employee> employee { get; set; }
        
    }
}