using System;
using System.Collections.Generic;
using System.Text;

namespace File_Directory_Serialization.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public string ShowInfo()
        {
            return $"ID: {Id} - Name: {Name} - Salary: {Salary}";
        }
    }

    

    
}
