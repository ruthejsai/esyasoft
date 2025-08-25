// See https://aka.ms/new-console-template for more information
/*    QUESTION 1
using System;

class SmartMeterBill
{
    static void Main()
    {
        Console.Write("Enter units consumed: ");

        string input = Console.ReadLine();
        int units = int.Parse(input);

        const int RATE_FIRST_100 = 5;
        const int RATE_NEXT_100 = 7;
        const int RATE_ABOVE_200 = 10;

        int totalBill = 0;

        if (units <= 100)
        {
            totalBill = units * RATE_FIRST_100;
        }
        else if (units <= 200)
        {
            totalBill = (100 * RATE_FIRST_100)
                      + ((units - 100) * RATE_NEXT_100);
        }
        else
        {
            totalBill = (100 * RATE_FIRST_100)
                      + (100 * RATE_NEXT_100)
                      + ((units - 200) * RATE_ABOVE_200);
        }

        totalBill = Math.Abs(totalBill);

        Console.WriteLine("Total electricity bill: " + totalBill);
    }
}
*/




/*   QUESTION 2

using System;

class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public int UnitsConsumed { get; set; }

    public Customer(int id, string name, int units)
    {
        CustomerID = id;
        Name = name;
        UnitsConsumed = units;
    }

    public void ShowBill()
    {
        int ratePerUnit = 5;
        int totalBill = UnitsConsumed * ratePerUnit;

        Console.WriteLine($"Customer: {Name} (ID: {CustomerID})");
        Console.WriteLine($"Units Consumed: {UnitsConsumed}");
        Console.WriteLine($"Total Bill: {totalBill}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Customer ID:");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Units Consumed:");
        int units = int.Parse(Console.ReadLine());

        Customer c1 = new Customer(id, name, units);

        c1.ShowBill();
    }
}
*/



/*     QUESTION 3
using System;

class SmartMeterStatistics
{
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    public void CalculateStatistics(int[] units)
    {
        int total = 0;
        int maxUnits = units[0];
        int maxIndex = 0;

        for (int i = 0; i < units.Length; i++)
        {
            total += units[i];

            if (units[i] > maxUnits)
            {
                maxUnits = units[i];
                maxIndex = i;
            }
        }

        double average = (double)total / units.Length;

        Console.WriteLine($"Total units: {total}");
        Console.WriteLine($"Average units/day: {average}");
        Console.WriteLine($"Highest consumption: {((Days)maxIndex)} ({maxUnits} units)");
    }

    static void Main()
    {
        int[] weeklyUnits = new int[7];

        Console.WriteLine("Enter units consumed for 7 days (Mon-Sun):");

        for (int i = 0; i < weeklyUnits.Length; i++)
        {
            weeklyUnits[i] = int.Parse(Console.ReadLine());
        }

        SmartMeterStatistics stats = new SmartMeterStatistics();
        stats.CalculateStatistics(weeklyUnits);
    }
}
*/







