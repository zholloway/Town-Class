using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town_Class
{
    class School
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

        public int NumberOfClassrooms { get; set; }

        public int NumberOfStudents { get; set; }

        public bool InSession { get; set; }

        public int NumberOfTeachers { get; set; }

        public string TeacherToStudentRatio(int NumberOfTeachers, int NumberOfStudents)
        {
            /*
                Put calculations to reduce ratio to lowest numbers here
                For instance, 9:3 would reduce to 3:1
            */

            var highestCommonDenominator = 1;

            for (int i = 2; i <= NumberOfTeachers; i++)
            {
                if ((NumberOfStudents % i == 0) && (NumberOfTeachers % i == 0))
                {
                    highestCommonDenominator = i;
                }
            }

            NumberOfStudents /= highestCommonDenominator;
            NumberOfTeachers /= highestCommonDenominator;

            return $"{NumberOfTeachers}: {NumberOfStudents}";
        }

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

        private List<Townsperson> _currentOccupants = new List<Townsperson>();

            public string CurrentOccupants
            {
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

        public void IncrementOccupants(List<Townsperson> tourGroup)
            {
                foreach (var person in tourGroup)
                {
                    _currentOccupants.Add(person);
                }
            }

            public void DecreaseOccupants(List<Townsperson> tourGroup)
            {
                foreach (var person in tourGroup)
                {
                    _currentOccupants.Remove(person);
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

        public School(int numberOfTeachers, int numberOfStudents)
        {
            this.BuildingType = "School";
            this.NumberOfTeachers = numberOfTeachers;
            this.NumberOfStudents = numberOfStudents;
        }

        public static School CreateSchool1(int numberOfTeachers, int numberOfStudents)
        {
            var school = new School(numberOfTeachers, numberOfStudents)
            {
                Name = "Alonso High School",
                NumberOfRooms = 50,
                ConstructionMaterial = "Cardboard",
                Height = 30,
                Width = 10000,
                Length = 20000,
                NumberOfBathrooms = 10,
                NumberOfFloors = 3,
                Address1 = "1122 Education Blvd",
                Address2 = "",
                City = "Tampa",
                State = "Florida",
                Zip = "32323"
            };

            school.CalculateSquareFootage(school.Width, school.Length, school.NumberOfFloors);
            school.CalculateVolume(school.Height, school.Width, school.Length);
            //school.SetNumberOfOccupants(numberOfTeachers + numberOfStudents + 10);
            school.AssembleFullAddress(school.Address1, school.Address2, school.City, school.State, school.Zip);

            return school;
        }

        public static School CreateSchool2(int numberOfTeachers, int numberOfStudents)
        {
            var school = new School(numberOfTeachers, numberOfStudents)
            {
                Name = "The Iron Yard",
                NumberOfRooms = 6,
                ConstructionMaterial = "Wood",
                Height = 15,
                Width = 1000,
                Length = 2000,
                NumberOfBathrooms = 2,
                NumberOfFloors = 1,
                Address1 = "900 Programming Circle",
                Address2 = "",
                City = "St. Petersburg",
                State = "Florida",
                Zip = "12309"
            };

            school.CalculateSquareFootage(school.Width, school.Length, school.NumberOfFloors);
            school.CalculateVolume(school.Height, school.Width, school.Length);
            //school.SetNumberOfOccupants(numberOfTeachers + numberOfStudents + 3);
            school.AssembleFullAddress(school.Address1, school.Address2, school.City, school.State, school.Zip);

            return school;
        }
    }
}
