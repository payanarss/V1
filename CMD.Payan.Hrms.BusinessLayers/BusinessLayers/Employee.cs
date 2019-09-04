using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMD.Payan.Hrms.BusinessLayers
{
    public class Employee
    {
        public string Name { get; set; }
    }

    public class EmployeeCollection : List<Employee>
    {
        public Employee GetEmployeeBy(string uniqueId)
        {
            return null;
        }
    }

    public class EmployeeCollectionFactry
    {
        public static EmployeeCollectionFactry Instance { get; set; }

        public EmployeeCollection SingletonInstance { get { return null; } }
    }
}
