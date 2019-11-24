using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot LotA = new CarLot("JB Andrew Lot");
            CarLot LotB = new CarLot("Kelly Blue Book Lot");
            Vehicle car1 = new Car("GHY546", "Honda", "Civic", 24000.50, "hatchback", 4);
            Vehicle car2 = new Car("KHV848", "Kia", "Civic", 19000.80, "coupe", 4);
            Vehicle truck1 = new Truck("ghys564", "Ford", "F150", 40000.5, "short");
            Vehicle truck2 = new Truck("ghys564", "Toyota", "Tundra", 50000.5, "Standard");
            LotA.AddVehicle(car1);
            LotA.AddVehicle(car2);
            LotA.AddVehicle(truck1);
            LotB.AddVehicle(truck2);
            LotA.PrintInventory();
            LotB.PrintInventory();
            Console.ReadKey();
        }
    }
    public class CarLot
    {
        public string Name;
        List<Vehicle> ListOfVehicles;

        public CarLot(string name)
        {
            Name = name;
            ListOfVehicles = new List<Vehicle>();
        }
        public void AddVehicle(Vehicle automobile)
        {
            ListOfVehicles.Add(automobile);
        }
        public void PrintInventory()
        {
            Console.WriteLine(Name);
            foreach (Vehicle v in ListOfVehicles)
                v.GiveDescription();
        }
    }
}
public abstract class Vehicle
{
    public string LicenseNumber;
    public string Make;
    public string Model;
    public double Price;
    public Vehicle(string licnumber, string make, string model, double price)
    {
        LicenseNumber = licnumber;
        Make = make;
        Model = model;
        Price = price;

    }
    public virtual void GiveDescription()
    {
        Console.WriteLine("the license number is {0}, the make and model is {1} {2}, and the price of this car is $ {3}", LicenseNumber, Make, Model, Price);
    }

}
class Car : Vehicle
{
    public string Type;
    public int NumberOfDoors;
    public Car(string licnumber, string make, string model, double price, string type, int numbofdoors) : base(licnumber, make, model, price)
    {
        Type = type;
        NumberOfDoors = numbofdoors;
    }
    public override void GiveDescription()
    {
        Console.WriteLine("This is a car and the license number is {0}, the make and model is {1} {2}, and the price of this car is ${3}. It is a {4} and has {5} doors. ", LicenseNumber, Make, Model, Price, Type, NumberOfDoors);
    }
}
class Truck : Vehicle
{
    public string BedSize;

    public Truck(string licnumber, string make, string model, double price, string bedsize) : base(licnumber, make, model, price)
    {
        BedSize = bedsize;
    }
    public override void GiveDescription()
    {
        Console.WriteLine("This is a truck and the license number is {0}, the make and model is {1} {2}, and the price of this truck is {3}. The bedsize is {4}", LicenseNumber, Make, Model, Price, BedSize);
    }
}

