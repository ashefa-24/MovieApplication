using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Emp_id { get; set; }
        public string Emp_Name { get; set; }
        public string Address { get; set; }
        public string Phone_Number { get; set; }
        public int Salary { get; set; }
    }
}