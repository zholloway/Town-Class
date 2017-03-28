using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Class
{
    class Town
    {
        public List<House> AllTheHouses { get; set; }

        public List<Bank> AllTheBanks { get; set; }

        public List<School> AllTheSchools { get; set; }

        public List<Townsperson> TourGroup { get; set; }

        public void MoveTourGroupToHouse (string houseName)
        {
            Console.WriteLine($"The tour group is starting at {houseName}.");
            foreach (var house in AllTheHouses)
            {
                if (house.Name == houseName)
                {
                    house.IncrementOccupants(this.TourGroup);
                }
            }
        }

        public void MoveTourGroupFromHouseToBank(string houseName, string bankName)
        {
            Console.WriteLine($"The tour group is moving from {houseName} to {bankName}.");
            foreach (var house in AllTheHouses)
            {
                if (house.Name == houseName)
                {
                    house.DecreaseOccupants(this.TourGroup);
                }
            }

            foreach (var bank in AllTheBanks)
            {
                if (bank.Name == bankName)
                {
                    bank.IncrementOccupants(this.TourGroup);
                }
            }
        }
    }
}
