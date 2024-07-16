using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDemo.Models
{
    public class EmployeeDetails
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }

    }

    public class EmployeeDetailsVM
    {
        public string status { get; set; }
        public List<EmployeeDetails> data { get; set; }

        public string message { get; set; }
    }
}
