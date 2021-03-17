using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01_CompanyRoster
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfEmployees = int.Parse(Console.ReadLine());
			List<Department> departments = new List<Department>();

			for (int i = 0; i < countOfEmployees; i++)
			{
				string[] tokens = Console.ReadLine().Split();
				string currentDepartmentName = tokens[2];

				if (!departments.Any(x => x.DepartmentName == currentDepartmentName))
				{
					Employee employee = new Employee(tokens);

					Department department = new Department(currentDepartmentName, employee);
					department.TotalSalaries += double.Parse(tokens[1]);
					departments.Add(department);
					continue;
				}

				Department currentDepartment = departments.First(x => x.DepartmentName == currentDepartmentName);

				currentDepartment.EmployeesList.Add(new Employee(tokens));
				currentDepartment.TotalSalaries += double.Parse(tokens[1]);
			}

			Department departmentWithBestSalary = departments
				.OrderByDescending(x => x.TotalSalaries / x.EmployeesList.Count())
				.First();

			Console.WriteLine($"Highest Average Salary: {departmentWithBestSalary.DepartmentName}");

			foreach (var employee in departmentWithBestSalary
				.EmployeesList.OrderByDescending(x => x.EmployeeSalary))
			{
				Console.WriteLine($"{employee.EmployeeName} {employee.EmployeeSalary:f2}");
			}
		}
	}
	class Employee
	{
		public string EmployeeName { get; set; }
		public double EmployeeSalary { get; set; }

		public Employee(string[] employeeInfo)
		{
			EmployeeName = employeeInfo[0];
			EmployeeSalary = double.Parse(employeeInfo[1]);
		}
	}
	class Department
	{
		public string DepartmentName { get; set; }
		public List<Employee> EmployeesList = new List<Employee>();
		public double TotalSalaries { get; set; }

		public Department(string name, Employee employee)
		{
			DepartmentName = name;
			EmployeesList.Add(employee);
		}
	}
}

	


