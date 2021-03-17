using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricProject.Models
{
    public class Position
    {
        public int positionID { get; set; }
        public string position { get; set; }
        public ICollection<Employee> employee { get; set; }
    }
}