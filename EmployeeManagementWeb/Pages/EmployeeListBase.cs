using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManagementModels;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementWeb.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees() {
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Sam",
                LastName = "Huy",
                Email = "samhe@gmail.com",
                DateOfBirth = new DateTime(1990, 09, 21),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 2, DepartmentName = "Science" },
                PhotoPath = "image/john.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Joe",
                LastName = "Wayne",
                Email = "joehe@gmail.com",
                DateOfBirth = new DateTime(1992, 09, 21),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 3, DepartmentName = "Technology" },
                PhotoPath = "image/john.png"
            };
            Employees = new List<Employee> { e1, e2 };
        }
    }
}
