﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCSharp.CSharpImplementations
{
    public class CommonObjects
    {
        public class Company
        {
            public string CompanyName { get; set; }
            public IEnumerable<Employee> Employees { get; set; }
        }

        public class Employee
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public IEnumerable<Phone> Phones { get; set; }
        }

        public class Phone
        {
            private string? _number;

            public string Number {
                get { return _number; }
                set { _number = value; }
            }
           
        }

        public class Name
        {
            public string CompanyName { get; set; }
            public string EmployeeName { get; set; }
        }

        public static List<Employee> CreateEmployees()
        {
            Employee emp11 = new Employee()
            {
                Name = "Misho",
                Position = "HR",
                Phones = new List<Phone>() { new Phone { Number = "088 1234567" }, new Phone { Number = "0000000000" } }
            };
            Employee emp12 = new Employee()
            {
                Name = "Stef",
                Position = "HR",
                Phones = new List<Phone>() { new Phone { Number = "088 77777777" }, new Phone { Number = "1111111111" } }
            };
            Employee emp21 = new Employee()
            {
                Name = "Tosho",
                Position = "IT",
                Phones = new List<Phone>() { new Phone { Number = "0899999999" } }
            };
            Employee emp22 = new Employee()
            {
                Name = "Qnko",
                Position = "IT",
                Phones = new List<Phone>() { new Phone { Number = "088 8888888888888" }, new Phone { Number = "22222222222" } }
            };



            return new List<Employee>() { emp11, emp12, emp21, emp22 };
        }
        public static List<Company> CreateCompanies()
        {

            var employees = CreateEmployees().ToArray();

            var companies = new List<Company> {
                new Company { CompanyName="Nestle", Employees = new List<Employee>{ employees[0], employees[2] }},
                new Company { CompanyName="Milka", Employees = new List<Employee>{employees[1], employees[3]}}
            };

            return companies;
        }
    }
}
