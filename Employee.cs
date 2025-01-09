using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    // HireDate Class
    public class HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Day:00}/{Month:00}/{Year}";
        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityPrivilege SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public string Gender { get; set; } // Restricted to "M" or "F"

        public Employee(int id, string name, SecurityPrivilege securityLevel, decimal salary, HireDate hireDate, string gender)
        {
            if (gender != "M" && gender != "F")
                throw new ArgumentException("Gender must be 'M' or 'F'.");

            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSecurity Level: {SecurityLevel}\nSalary: {Salary.ToString("C", CultureInfo.CurrentCulture)}\nHire Date: {HireDate}\nGender: {Gender}";
        }
    }

    // Person Struct
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}


