using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Class
{
    class Bank
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

        private double _squareFootage;

            public double SquareFootage { get { return _squareFootage; } } // read only

            public void CalculateSquareFootage(double Width, double Length, int NumberOfFloors)
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

            public void AssembleFullAddress(string Address1, string Address2, string City, string State, string Zip)
            {
                this._fullAddress = Address1 + " " + Address2 + " " + City + ", " + State + " " + Zip;
            }

        private int _currentOccupants;

            public int CurrentOccupants { get { return _currentOccupants; } } // read only

            public int IncrementOccupants()
            {
                return this._currentOccupants++;
            }

            public int DecreaseOccupants()
            {
                return this._currentOccupants--;
            }

            public void SetNumberOfOccupants(int number)
            {
                for (int i = 0; i < number; i++)
                {
                    this._currentOccupants++;
                }
            }

        private double AmountOfMoney { get; set; }

        public void DepositMoney (double depositAmount)
        {
            this.AmountOfMoney += depositAmount;
        }

        public void WithdrawMoney(double withdrawAmount)
        {
            this.AmountOfMoney -= withdrawAmount;
        }

        public Bank(int money)
        {
            this.BuildingType = "Bank";
            this.AmountOfMoney = money;
        }

        public static Bank CreateBank1(int money)
        {
            var bank1 = new Bank(money)
            {
                Name = "5/3 Bank",
                NumberOfRooms = 15,
                ConstructionMaterial = "Plastic",
                Height = 15,
                Width = 2000,
                Length = 3000,
                NumberOfBathrooms = 3,
                NumberOfFloors = 1,
                Address1 = "425 Money Street",
                Address2 = "",
                City = "Tampa",
                State = "Florida",
                Zip = "33556"
            };

            bank1.CalculateSquareFootage(bank1.Width, bank1.Length, bank1.NumberOfFloors);
            bank1.CalculateVolume(bank1.Height, bank1.Width, bank1.Length);
            bank1.SetNumberOfOccupants(11);
            bank1.AssembleFullAddress(bank1.Address1, bank1.Address2, bank1.City, bank1.State, bank1.Zip);

            return bank1;
        }

        public static Bank CreateBank2(int money)
        {
            var bank1 = new Bank(money)
            {
                Name = "Bank Of America",
                NumberOfRooms = 10,
                ConstructionMaterial = "Cardboard",
                Height = 30,
                Width = 1000,
                Length = 2000,
                NumberOfBathrooms = 11,
                NumberOfFloors = 2,
                Address1 = "630 Banker Ave",
                Address2 = "",
                City = "Odessa",
                State = "Florida",
                Zip = "33556"
            };

            bank1.CalculateSquareFootage(bank1.Width, bank1.Length, bank1.NumberOfFloors);
            bank1.CalculateVolume(bank1.Height, bank1.Width, bank1.Length);
            bank1.SetNumberOfOccupants(30);
            bank1.AssembleFullAddress(bank1.Address1, bank1.Address2, bank1.City, bank1.State, bank1.Zip);

            return bank1;
        }
    }
}
