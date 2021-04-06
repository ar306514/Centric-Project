using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricProject.Models
{
    public class CoreValue
    {
        public int coreValueID { get; set; }
        public Value award { get; set; }
        public string recognizer { get; set; }
        public string recognized { get; set; }
        public DateTime recognitionDate { get; set; }
        public enum Value
        {
            Culture = 1,
            Innovation = 2,
            Integrity_and_Openness = 3,
            Responsible_Stewardship = 4,
            Greater_Good = 5,
            Delivery_Excellence = 6
        }
    }
}