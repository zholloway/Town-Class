using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Class
{
    class House
    {
        public string Name { get; set; }

        public string BuildingType { get; set; } // to be set in the constructor

        public int NumberOfRooms { get; set; }

        public string ConstructionMaterial { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public int NumberOfFloors { get; set; }

        public int NumberOfBathrooms { get; set; }

        public int NumberOfBedrooms { get; set; }

        private double _squareFootage;

            public double SquareFootage { get { return _squareFootage; } } // read only

            public void CalculateSquareFootage (double Width, double Length, int NumberOfFloors)
        {
            this._squareFootage = Width * Length * NumberOfFloors;
        }

        private double _volume;

            public double Volume { get { return _volume; } } // read only

            public void CalculateVolume(double Height, double Width, double Length)
            {
                this._volume = Height * Width * Length;
            }

        private string _fullAddress;

            public string FullAddress { get { return _fullAddress; } } // read only

            public string Address1 { get; set; }

            public string Address2 { get; set; }

            public string City { get; set; }

            public string State { get; set; }

            public string Zip { get; set; }

            public void AssembleFullAddress (string Address1, string Address2, string City, string State, string Zip)
            {
                this._fullAddress = Address1 + " " + Address2 + " " + City + ", " + State + " " + Zip;
            }

        private List<Townsperson> _currentOccupants = new List<Townsperson>();

                public string CurrentOccupants {
                    get
                    {
                        var nameList = "";
                        foreach (var person in _currentOccupants)
                        {
                            nameList += (person.Name + " ");
                        }
                        return nameList;
                    }
                
                } // read only

                public void IncrementOccupants(List<Townsperson>tourGroup)
                {
                    foreach (var person in tourGroup)
                    {
                        this._currentOccupants.Add(person);
                    }
                }

                public void DecreaseOccupants(List<Townsperson>tourGroup)
                {
                    foreach (var person in tourGroup)
                    {
                        this._currentOccupants.Remove(person);
                    }
                }

        /*
        public void SetNumberOfOccupants (int number)
        {
            for (int i = 0; i < number; i++)
            {
                this._currentOccupants++;
            }
        }
        */



        public House()
        {
            this.BuildingType = "House";
        }

        public static House CreateHouse1()
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
            //house1.SetNumberOfOccupants(3);
            house1.AssembleFullAddress(house1.Address1, house1.Address2, house1.City, house1.State, house1.Zip);

            return house1;
        }

        public static House CreateHouse2()
        {
            var house2 = new House
            {
                Name = "Blue House",
                NumberOfRooms = 10,
                ConstructionMaterial = "Concrete",
                Height = 30,
                Width = 700,
                Length = 1000,
                NumberOfBathrooms = 4,
                NumberOfBedrooms = 5,
                NumberOfFloors = 2,
                Address1 = "123 Easy Street",
                Address2 = "",
                City = "Tampa",
                State = "Florida",
                Zip = "32987"
            };

            house2.CalculateSquareFootage(house2.Width, house2.Length, house2.NumberOfFloors);
            house2.CalculateVolume(house2.Height, house2.Width, house2.Length);
            //house2.SetNumberOfOccupants(5);
            house2.AssembleFullAddress(house2.Address1, house2.Address2, house2.City, house2.State, house2.Zip);

            return house2;
        }

        public static House CreateHouse3()
        {
            var house3 = new House
            {
                Name = "Red House",
                NumberOfRooms = 2,
                ConstructionMaterial = "Wood",
                Height = 15,
                Width = 100,
                Length = 400,
                NumberOfBathrooms = 1,
                NumberOfBedrooms = 1,
                NumberOfFloors = 1,
                Address1 = "321 Someone Help Me Way",
                Address2 = "Apartment 306",
                City = "St. Petersburg",
                State = "Florida",
                Zip = "21908"
            };

            house3.CalculateSquareFootage(house3.Width, house3.Length, house3.NumberOfFloors);
            house3.CalculateVolume(house3.Height, house3.Width, house3.Length);
            //house3.SetNumberOfOccupants(1);
            house3.AssembleFullAddress(house3.Address1, house3.Address2, house3.City, house3.State, house3.Zip);

            return house3;
        }
    }
}
