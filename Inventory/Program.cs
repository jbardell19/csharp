using System;
using System.Collections.Generic;

namespace IRentable
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new Boat(25);
            Boat boat2 = new Boat(50);
            House house1 = new House(500);
            House house2 = new House(350);
            Car car1 = new Car(45);
            Car car2 = new Car(25);
            List<IRentable> RentItems = new List<IRentable>();
            RentItems.Add(boat1);
            RentItems.Add(boat2);
            RentItems.Add(house1);
            RentItems.Add(house2);
            RentItems.Add(car1);
            RentItems.Add(car2);
            foreach (IRentable Rent in RentItems)
            {
                Rent.GetDescription();
                Rent.GetDailyRate();
            }
            Console.ReadKey();
        }
    }
    public interface IRentable
    {
        void GetDailyRate();
        void GetDescription();
    }

    public class Boat : IRentable
    {
        public int HourlyRate { get; set; }
        public Boat(int hourlyrate)
        {
            HourlyRate = hourlyrate;
        }
        public void GetDailyRate()
        {
            Console.WriteLine("The cost to rent is {0} dollars per hour", HourlyRate);
        }
        public void GetDescription()
        {
            Console.Write("This is a boat available to rent. ");
        }
    }
    public class House : IRentable
    {
        public int WeeklyRate { get; set; }
        public House(int weeklyrate)
        {
            WeeklyRate = weeklyrate;
        }
        public void GetDailyRate()
        {
            Console.WriteLine("The cost to rent is {0} dollars per week", WeeklyRate);
        }
        public void GetDescription()
        {
            Console.Write("This is a house available to rent. ");
        }
    }
    public class Car : IRentable
    {
        public int DailyRate { get; set; }
        public Car(int dailyrate)
        {
            DailyRate = dailyrate;
        }
        public void GetDailyRate()
        {
            Console.WriteLine("The cost to rent is {0} dollars per day", DailyRate);
        }
        public void GetDescription()
        {
            Console.Write("This is a car available to rent. ");
        }
    }
}
