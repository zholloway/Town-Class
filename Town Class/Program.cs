using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var house1 = new House
            {
                Name = "Home",
                NumberOfRooms = 7,
                ConstructionMaterial = "Wood",
                Height = 15,
                Width = 400,
                Length = 800,
                NumberOfBathrooms = 2,
                NumberOfBedrooms = 3,
                NumberOfFloors = 1,
                Address1 = "7514 Lake Josephine Lane",
                Address2 = "",
                City = "Odessa",
                State = "Florida",
                Zip = "33556"
            };

            house1.CalculateSquareFootage(house1.Width, house1.Length, house1.NumberOfFloors);
            house1.CalculateVolume(house1.Height, house1.Width, house1.Length);
            house1.SetNumberOfOccupants(3);
            house1.AssembleFullAddress(house1.Address1, house1.Address2, house1.City, house1.State, house1.Zip);

            Console.WriteLine($"The name of the {house1.BuildingType} is {house1.Name}.");
            Console.WriteLine($"The square footage of the house is {house1.SquareFootage}.");
            Console.WriteLine($"The volume of the house is {house1.Volume}");
            Console.WriteLine($"There are {house1.CurrentOccupants} people living there.");
            Console.WriteLine($"The address of the house is: {house1.FullAddress}");

            Console.ReadLine();
        }
    }
}
