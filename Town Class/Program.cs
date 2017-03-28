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
            //create houses
            var allTheHouses = new List<House>();

            var house1 = House.CreateHouse1();
            var house2 = House.CreateHouse2();
            var house3 = House.CreateHouse3();

            allTheHouses.Add(house1);
            allTheHouses.Add(house2);
            allTheHouses.Add(house3);

            //house examples

            //create banks
            var allTheBanks = new List<Bank>();

            var bank1 = Bank.CreateBank1(250000);
            var bank2 = Bank.CreateBank2(1000000);

            allTheBanks.Add(bank1);
            allTheBanks.Add(bank2);

            //bank examples

            //create schools
            var allTheSchools = new List<School>();

            var school1 = School.CreateSchool1(10, 100);
            var school2 = School.CreateSchool2(3, 42);

            allTheSchools.Add(school1);
            allTheSchools.Add(school2);

            //school examples

            //create town
            var town = new Town();
            town.AllTheHouses = allTheHouses;
            town.AllTheBanks = allTheBanks;
            town.AllTheSchools = allTheSchools;

            //create TourGroup
            var tourGroup = new List<Townsperson>();

            var person1 = new Townsperson("Zack", "Brown", "Green");
            var person2 = new Townsperson("JonLuke", "Brown", "Brown");
            var person3 = new Townsperson("Ashley", "Blonde", "Blue");
            var person4 = new Townsperson("Caroline", "Black", "Grey");

            tourGroup.Add(person1);
            tourGroup.Add(person2);
            tourGroup.Add(person3);
            tourGroup.Add(person4);

            town.TourGroup = tourGroup;

            town.MoveTourGroupToHouse(house2.Name);
            Console.WriteLine($"The occupants of {house2.Name} are {house2.CurrentOccupants}.");

            town.MoveTourGroupFromHouseToBank(house2.Name, bank1.Name);
            Console.WriteLine($"The occupants of {bank1.Name} are {bank1.CurrentOccupants}.");

            Console.ReadLine();
        }
    }
}
