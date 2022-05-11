using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Purodhika Sharma
 * Student ID: 301223212
 * Subject: COMP 123 (Programming 2 Sec. 013)
 */

class Car
{
    private int year;
    private string manufacturer;
    private string model;
    private bool isDrivable;
    private double price;
    public Car(int year, string manufacturer, string model, double price, bool isDrivable = true)
    {
        this.year = year;
        this.manufacturer = manufacturer;
        this.model = model;
        this.price = price;
        this.isDrivable = isDrivable;
    }
    public override string ToString()
    {

        return $"Year: {year}, Manufacturer: {manufacturer}, Model: {model}, Price: {price}, Drivable: {isDrivable}";
    }
    static void Main(String[] args)
    {
        Car Hyundai = new Car(2010, "Hyundai", "Hyundai Verna", 18000, true);
        Console.WriteLine(Hyundai.ToString());

        Car Audi = new Car(2002, "Audi Autos", "Audi Q5", 50000, true);
        Console.WriteLine(Audi.ToString());

        Car Ford = new Car(1998, "Ford Autos", "Endeavour", 15000, true);
        Console.WriteLine(Ford.ToString());

        Car Jeep = new Car(2021, "Jeep", "Wrangler", 50000, true);
        Console.WriteLine(Jeep.ToString());

    }

}

