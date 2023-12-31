﻿using System.IO.Pipes;
using System.Xml.Schema;

namespace InheritanceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("employees.txt");
            List<Employee> employees = new List<Employee>();
            List<Salaried> salariedEmployees = new List<Salaried>();
            List<Wages> wagesEmployees = new List<Wages>();
            List<PartTime> partTimeEmployees = new List<PartTime>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(":");
                string id = columns[0];
                string name = columns[1];
                string address = columns[2];
                string phone = columns[3];
                string sinString = columns[4];
                long sin = Convert.ToInt64(sinString);
                string dob = columns[5];
                string dept = columns[6];
                char firstDigitOfId = id[0];
                if (firstDigitOfId == '0' || firstDigitOfId == '1' || firstDigitOfId == '2' || firstDigitOfId == '3' || firstDigitOfId == '4') 
                { 
                    // Salaried Employee
                    string salaryString = columns[7];
                    double salary = Convert.ToDouble(salaryString);
                    Salaried employee = new Salaried(id, name, address, phone, sin, dob, dept, salary);
                    employees.Add(employee);
                    salariedEmployees.Add(employee);
                }
                else if (firstDigitOfId == '5' || firstDigitOfId == '6' || firstDigitOfId == '7')
                {
                    // Wage Employee
                    string rateString = columns[7];
                    string hoursString = columns[8];
                    double rate = Convert.ToDouble(rateString);
                    double hours = Convert.ToDouble(hoursString);
                    Wages employee = new Wages(id, name, address, phone, sin, dob, dept, rate, hours);
                    employees.Add(employee);
                    wagesEmployees.Add(employee);
                }
                else if (firstDigitOfId == '8' || firstDigitOfId== '9')
                {
                    // PartTime Employee
                    string rateString = columns[7];
                    string hoursString = columns[8];
                    double rate = Convert.ToDouble(rateString);
                    double hours = Convert.ToDouble(hoursString);
                    PartTime employee = new PartTime(id, name, address, phone, sin, dob, dept, rate, hours);
                    employees.Add(employee);
                    partTimeEmployees.Add(employee);
                }
            }

            // Average Weekly Pay for All Employees
            double totalPay = 0;
            Console.WriteLine("Average Weekly Pay for Each Salary Employee:");
            foreach (Salaried employee in salariedEmployees)
            {
                Console.WriteLine($"{employee.Name}: {employee.GetPay(employee.Salary):c}");
                double pay = employee.GetPay(employee.Salary);
                totalPay += pay;
            }
            Console.WriteLine("\nAverage Weekly Pay for Each Wage Employee:");
            foreach (Wages employee in wagesEmployees)
            {
                Console.WriteLine($"{employee.Name}: {employee.GetPay(employee.Rate, employee.Hours):c}");
                double pay = employee.GetPay(employee.Rate, employee.Hours);
                totalPay += pay;
            }
            Console.WriteLine("\nAverage Weekly Pay for Each Part Time Employee:");
            foreach (PartTime employee in partTimeEmployees)
            { 
                Console.WriteLine($"{employee.Name}: {employee.GetPay(employee.Rate, employee.Hours):c}");
                double pay = employee.GetPay(employee.Rate, employee.Hours);
                totalPay += pay;
            }
            double avgPay = totalPay / employees.Count;
            Console.WriteLine($"\nThe average weekly pay of all employees is: {avgPay:c}\n");

            // Highest Weekly Pay for Wage Employees
            double highestPay = 0;
            Employee paidEmployee = wagesEmployees[0];
            foreach (Wages employee in wagesEmployees)
            {
                double pay = employee.GetPay(employee.Rate, employee.Hours);
                if (pay > highestPay)
                {
                    highestPay = pay;
                    paidEmployee = employee;
                }
            }
            Console.WriteLine($"Highest Weekly Paid Wage Employee: {paidEmployee.Name}");
            Console.WriteLine(paidEmployee.ToString());
            Console.WriteLine($"{paidEmployee.Name}'s weekly pay: {highestPay:c}\n");

            // Lowest Salary Pay
            double lowestPay = 999999;
            Employee lowestPaidSalary = wagesEmployees[0];
            foreach (Salaried employee in salariedEmployees)
            {
                double pay = employee.GetPay(employee.Salary);
                if (pay < lowestPay) 
                {
                    lowestPay = pay;
                    lowestPaidSalary = employee;
                }
            }
            Console.WriteLine($"Lowest Weekly Paid Salary Employee: {lowestPaidSalary.Name}");
            Console.WriteLine(lowestPaidSalary.ToString());
            Console.WriteLine($"{lowestPaidSalary.Name}'s weekly pay: {lowestPay:c}\n");

            // Calculating Percentages
            double employeeCount = employees.Count;
            double salaryPercentage = salariedEmployees.Count / employeeCount * 100;
            Console.WriteLine($"Salaried Employee Percentage: {salaryPercentage:f}%");
            double wagePercentage = wagesEmployees.Count / employeeCount * 100;
            Console.WriteLine($"Waged Employee Percentage: {wagePercentage:f}%");
            double partTimePercentage = partTimeEmployees.Count / employeeCount * 100;
            Console.WriteLine($"Part Time Employee Percentage: {partTimePercentage:f}%");
        }
    }
}