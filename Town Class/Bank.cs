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

        public double SquareFootage { get; } // read only

        public int NumberOfFloors { get; set; }

        public int NumberOfBathrooms { get; set; }

        public double Volume { get; } // read only

        public string FullAddress { get; } // read only

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        private int _currentOccupants;

        public int CurrentOccupants { get; } // read only

        public int IncrementOccupants ()
        {
            return this._currentOccupants++;
        }

        public int DecreaseOccupants()
        {
            return this._currentOccupants--;
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

        public Bank()
        {
            this.BuildingType = "Bank";
        }
    }
}
