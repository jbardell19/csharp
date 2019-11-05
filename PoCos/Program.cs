using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            DriverLicense firstLicense = new DriverLicense("Jared", "Bardell", "Male", 71990583);
            Console.WriteLine("Hello, my name is {0} {1}, and I am a {2}. My driver's license number is: {3}",
            firstLicense.firstName, firstLicense.lastName, firstLicense.gender, firstLicense.licenseNumber);
            firstLicense.GetFullName();
            Console.ReadKey();
        }
    }
    class DriverLicense
    {
        public String firstName;
        public String lastName;
        public String gender;
        public int licenseNumber;
        public DriverLicense(string fName, string lName, string Agender, int lNumber)
        {
            firstName = fName;
            lastName = lName;
            gender = Agender;
            licenseNumber = lNumber;
        }
        public DriverLicense(string fName)
        {
            firstName = fName;
        }
        public DriverLicense(string fName, string lName)
        {
            firstName = lName;
        }
        public String GetFullName()
        {
            string FullName = firstName + lastName;
            return FullName;
        }
    }
    class Book //list//
    {
        public string title;
        public string[] authors; 
        public int numberOfPages;
        public int sku;
        public string publisher;
        public double price;
    }
    class Airplane
    {
        public string manufacturer;
        public string model;
        public string variant;
        public int capacity;
        public int engines;
    }
}
