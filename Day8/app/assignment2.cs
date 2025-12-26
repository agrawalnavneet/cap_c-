using System;
using System.Collections.Generic;

// 1. Abstract Base Class
public abstract class EmployeeRecord
{
    public string EmployeeName { get; set; }
    public double[] WeeklyHours { get; set; }

    public abstract double GetMonthlyPay();
}

// 2. Full Time Employee
public class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    public double MonthlyBonus { get; set; }

    public override double GetMonthlyPay()
    {
        double totalHours = 0;
        foreach (double h in WeeklyHours)
        {
            totalHours += h;
        }
        return (totalHours * HourlyRate) + MonthlyBonus;
    }
}

// 3. Contract Employee
public class ContractEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }

    public override double GetMonthlyPay()
    {
        double totalHours = 0;
        foreach (double h in WeeklyHours)
        {
            totalHours += h;
        }
        return totalHours * HourlyRate;
    }
}

// 4. Payroll Class
public class PayRoll
{
    public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();

    public void RegisterEmployee(EmployeeRecord record)
    {
        PayrollBoard.Add(record);
    }

    public Dictionary<string, int> GetOvertimeWeekCounts(double hoursThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (EmployeeRecord emp in PayrollBoard)
        {
            int count = 0;
            foreach (double h in emp.WeeklyHours)
            {
                if (h >= hoursThreshold)
                    count++;
            }

            if (count > 0)
                result.Add(emp.EmployeeName, count);
        }

        return result;
    }

    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0)
            return 0;

        double total = 0;
        foreach (EmployeeRecord emp in PayrollBoard)
        {
            total += emp.GetMonthlyPay();
        }

        return total / PayrollBoard.Count;
    }
}

// 5. Program (Main)
class Abc
{
    public static void abc()
    {
        PayRoll payroll = new PayRoll();

        while (true)
        {
            Console.WriteLine("\n1. Register Employee");
            Console.WriteLine("2. Show Overtime Summary");
            Console.WriteLine("3. Calculate Average Monthly Pay");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Employee Type (1-FullTime, 2-Contract): ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hourly Rate: ");
                double rate = double.Parse(Console.ReadLine());

                double[] hours = new double[4];
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Week {i + 1} hours: ");
                    hours[i] = double.Parse(Console.ReadLine());
                }

                if (type == 1)
                {
                    Console.Write("Monthly Bonus: ");
                    double bonus = double.Parse(Console.ReadLine());

                    payroll.RegisterEmployee(new FullTimeEmployee
                    {
                        EmployeeName = name,
                        HourlyRate = rate,
                        MonthlyBonus = bonus,
                        WeeklyHours = hours
                    });
                }
                else
                {
                    payroll.RegisterEmployee(new ContractEmployee
                    {
                        EmployeeName = name,
                        HourlyRate = rate,
                        WeeklyHours = hours
                    });
                }

                Console.WriteLine("Employee registered successfully");
            }
            else if (choice == 2)
            {
                Console.Write("Enter overtime threshold: ");
                double threshold = double.Parse(Console.ReadLine());

                var data = payroll.GetOvertimeWeekCounts(threshold);
                if (data.Count == 0)
                    Console.WriteLine("No overtime recorded");

                foreach (var d in data)
                    Console.WriteLine($"{d.Key} - {d.Value} weeks");
            }
            else if (choice == 3)
            {
                Console.WriteLine($"Average Monthly Pay: {payroll.CalculateAverageMonthlyPay()}");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Logging off — Payroll processed successfully!");
                break;
            }
        }
    }
}
