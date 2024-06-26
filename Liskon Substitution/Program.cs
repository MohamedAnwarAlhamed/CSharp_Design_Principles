﻿
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "Ahmed"));
            employees.Add(new TempEmployee(2, "Mohamed"));
            //employees.Add(new ContractEmployee(3, "Salah"));

            foreach (var emp in employees)
            {
                Console.WriteLine("Name: {0}, Bouns: {1}, Min: {2} ",
                    emp.ToString(),
                    emp.CalculateBonus(100000).ToString(),
                    emp.GetMinimumSalary().ToString());
            }


            Console.WriteLine("============================================");

            List<IEmployee> emps = new List<IEmployee>();
            emps.Add(new PermanentEmployee(1, "Ahmed"));
            emps.Add(new TempEmployee(2, "Mohamed"));
            emps.Add(new ContractEmployee(3, "Salah"));

            foreach (var emp in emps)
            {
                Console.WriteLine("Name: {0}, Min: {1} ",
                    emp.ToString(),
                    emp.GetMinimumSalary().ToString());
            }

            Console.ReadKey(true);

        }
    }

