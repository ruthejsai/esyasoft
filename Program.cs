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


/*    QUESTION 4
class SmartMeter
{
    public int MeterId;
    public string CustomerName;

    public SmartMeter(int meterId, string customerName)
    {
        MeterId = meterId;
        CustomerName = customerName;
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Meter -> ID: {MeterId}, Name: {CustomerName}");
    }
}

class ResidentialMeter : SmartMeter
{
    public string HouseType;

    public ResidentialMeter(int meterId, string customerName, string houseType)
        : base(meterId, customerName)
    {
        HouseType = houseType;
    }

    public override void PrintDetails()
    {
        Console.WriteLine($"Residential Meter -> ID: {MeterId}, Name: {CustomerName}, HouseType: {HouseType}");
    }
}

class CommercialMeter : SmartMeter
{
    public string BusinessType;

    public CommercialMeter(int meterId, string customerName, string businessType)
        : base(meterId, customerName)
    {
        BusinessType = businessType;
    }

    public override void PrintDetails()
    {
        Console.WriteLine($"Commercial Meter -> ID: {MeterId}, Name: {CustomerName}, BusinessType: {BusinessType}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SmartMeter resMeter = new ResidentialMeter(201, "Alice", "Apartment");
        SmartMeter comMeter = new CommercialMeter(301, "Bob", "Shop");

        resMeter.PrintDetails();  
        comMeter.PrintDetails();  
        Console.ReadLine();
    }
}

*/



/*    QUESTION 5
using System;

class SmartMeterAccount
{
    private decimal balance; 

    public void Recharge(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Balance after recharge: {balance}");
    }

    public void Consume(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Balance after consumption: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SmartMeterAccount account = new SmartMeterAccount();

        account.Recharge(500);   
        account.Consume(200);    
        account.Consume(400);    
        Console.ReadLine();
    }
}

*/




/*   QUESTION 6

using System;

abstract class MeterReading
{
    public int Units { get; set; }

    public MeterReading(int units)
    {
        Units = units;
    }

    public abstract void CalculateBill();
}

class ResidentialReading : MeterReading
{
    public ResidentialReading(int units) : base(units) { }

    public override void CalculateBill()
    {
        int bill = Units * 5;
        Console.WriteLine($"Residential Bill = {bill}");
    }
}

class CommercialReading : MeterReading
{
    public CommercialReading(int units) : base(units) { }

    public override void CalculateBill()
    {
        int bill = Units * 8;
        Console.WriteLine($"Commercial Bill = {bill}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MeterReading res = new ResidentialReading(100);
        MeterReading com = new CommercialReading(100);

        res.CalculateBill();  
        com.CalculateBill();  
        Console.ReadLine();
    }
}
*/



/*   QUESTION 7
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<List<int>> meterReadings = new List<List<int>>()
        {
            new List<int>{10, 15, 20},  
            new List<int>{12, 18, 22},  
            new List<int>{14, 19, 25},  
            new List<int>{11, 16, 21},  
            new List<int>{13, 20, 24},  
            new List<int>{15, 22, 28},  
            new List<int>{17, 25, 30}   
        };

        Dictionary<string, Dictionary<string, List<int>>> areaData =
            new Dictionary<string, Dictionary<string, List<int>>>()
        {
            {
                "Area1", new Dictionary<string, List<int>>()
                {
                    { "House101", new List<int>{10, 12, 14, 11, 13, 15, 17} },
                    { "House102", new List<int>{8, 9, 10, 11, 12, 13, 14} }
                }
            },
            {
                "Area2", new Dictionary<string, List<int>>()
                {
                    { "House201", new List<int>{20, 22, 25, 21, 23, 26, 28} },
                    { "House202", new List<int>{15, 18, 20, 22, 25, 27, 30} }
                }
            }
        };

        Dictionary<string, List<string>> metersInArea = new Dictionary<string, List<string>>()
        {
            { "Area1", new List<string>{ "MeterA1", "MeterA2", "MeterA3" } },
            { "Area2", new List<string>{ "MeterB1", "MeterB2" } }
        };

        List<Dictionary<string, string>> complaints = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                { "HouseNum", "House101" },
                { "MeterNum", "MeterA1" },
                { "Issue", "Low Voltage" },
                { "Date", "2025-08-25" }
            },
            new Dictionary<string, string>()
            {
                { "HouseNum", "House202" },
                { "MeterNum", "MeterB2" },
                { "Issue", "Meter Not Working" },
                { "Date", "2025-08-26" }
            },
            new Dictionary<string, string>()
            {
                { "HouseNum", "House102" },
                { "MeterNum", "MeterA2" },
                { "Issue", "High Bill" },
                { "Date", "2025-08-27" }
            }
        };


        Console.WriteLine("Night reading of Day 3: " + meterReadings[2][2]);

        string house = "House201";
        Console.WriteLine($"Readings of {house}: " + string.Join(", ", areaData["Area2"][house]));

        string area = "Area1";
        Console.WriteLine($"Meters in {area}: " + string.Join(", ", metersInArea[area]));

        Console.WriteLine("\nComplaints List:");
        foreach (var c in complaints)
        {
            Console.WriteLine($"House: {c["HouseNum"]}, Meter: {c["MeterNum"]}, Issue: {c["Issue"]}, Date: {c["Date"]}");
        }
    }
}
*/




/*   QUESTION 8
using System;
using System.Collections.Generic;

enum MeterStatus { Active, Inactive, Fault }

struct Reading
{
    public DateTime Date;
    public int Units;

    public Reading(DateTime date, int units)
    {
        Date = date;
        Units = units;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Units} units";
    }
}

abstract class Notifier
{
    public abstract void SendMessage(string msg);
}

class SmsNotifier : Notifier
{
    private string phone;
    public SmsNotifier(string phone) { this.phone = phone; }
    public override void SendMessage(string msg)
    {
        Console.WriteLine($"[SMS to {phone}] {msg}");
    }
}

class EmailNotifier : Notifier
{
    private string email;
    public EmailNotifier(string email) { this.email = email; }
    public override void SendMessage(string msg)
    {
        Console.WriteLine($"[Email to {email}] {msg}");
    }
}

static class Tariff
{
    public static double RatePerUnit = 5.0; // ₹5 per unit
}

sealed class BillCalculator
{
    public double GenerateBill(List<Reading> readings)
    {
        int totalUnits = 0;
        foreach (var r in readings)
            totalUnits += r.Units;

        return totalUnits * Tariff.RatePerUnit;
    }
}

partial class Customer
{
    public string Name { get; set; }
    public string? Email { get; set; } 
}

partial class Customer
{
    public string? Phone { get; set; }

    public Notifier GetNotifier()
    {
        if (!string.IsNullOrEmpty(Email))
            return new EmailNotifier(Email!);
        else
            return new SmsNotifier(Phone ?? "Unknown");
    }
}

class Meter
{
    public int MeterId { get; set; }
    public MeterStatus Status { get; set; }

    public event Action<Reading>? OnReadingAdded;

    public ReadingHistory History { get; private set; }

    public Meter(int meterId)
    {
        MeterId = meterId;
        Status = MeterStatus.Active;
        History = new ReadingHistory();
    }

    public void AddReading(Reading r)
    {
        History.Readings.Add(r);
        OnReadingAdded?.Invoke(r);
    }

    public class ReadingHistory
    {
        public List<Reading> Readings { get; set; } = new List<Reading>();
    }
}

class Program
{
    static void Main()
    {
        Customer cust1 = new Customer { Name = "Ravi", Phone = "9876543210", Email = null };
        Notifier notifier = cust1.GetNotifier();

        Meter meter = new Meter(101);

        meter.OnReadingAdded += (reading) =>
        {
            notifier.SendMessage($"New Reading Added: {reading.Units} units on {reading.Date.ToShortDateString()}");
        };

        meter.AddReading(new Reading(DateTime.Now.AddDays(-2), 50));
        meter.AddReading(new Reading(DateTime.Now.AddDays(-1), 60));
        meter.AddReading(new Reading(DateTime.Now, 70));

        BillCalculator billCalc = new BillCalculator();
        double billAmount = billCalc.GenerateBill(meter.History.Readings);

        Console.WriteLine($"\nBill for Customer {cust1.Name}: {billAmount}");
    }
}
*/


/*    QUESTION 9
using System;
using System.IO;

class FileHandlingExample
{
    static void Main()
    {
        string fileName = "favorites.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            Console.WriteLine("Enter 5 favorite colors:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Color {i}: ");
                string color = Console.ReadLine();
                writer.WriteLine(color);
            }
        }

        Console.WriteLine("\nColors saved successfully!");

        Console.WriteLine("\nReading colors from file:");
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
*/


/*   QUESTION 10
using System;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFileAsync()
    {
        Console.WriteLine("Downloading file...");
        await Task.Delay(5000); 
        Console.WriteLine("Download complete!");
    }

    static async Task Main(string[] args)
    {
        await DownloadFileAsync();
    }
}
*/

