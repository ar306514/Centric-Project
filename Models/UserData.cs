using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricProject.Models
{
    public class UserData
    {
        public Guid ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get
            {
                return firstName + lastName;
            }
        }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string officeLocation { get; set; }
        public string position { get; set; }
        public DateTime startDate { get; set; }
    }
}