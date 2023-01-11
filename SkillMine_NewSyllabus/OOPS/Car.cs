using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.OOPS
{
    class Car
    {
            int CarmodelNumber;
            string CarName;
            string CarColor;
            string CarPrice;
            public void AcceptDetails(int CarmodelNumber, String CarName, string CarColor, string CarPrice)
            {
                this.CarmodelNumber = CarmodelNumber;
                this.CarName = CarName;
                this.CarColor = CarColor;
                this.CarPrice = CarPrice;
            }
            public void ShowDetails()
            {
                Console.WriteLine("Car Model Number is: " + CarmodelNumber);
                Console.WriteLine("Car Name is: " + CarName);
                Console.WriteLine("Car color is: " + CarColor);
                Console.WriteLine("Car price is: " + CarPrice);
            }
            static void Main(string[] args)
            {
                Car c1 = new Car();
                c1.AcceptDetails(1234, "TaTa harrier", "Red", "20 lack");
                c1.ShowDetails();
                Console.WriteLine("--------------------------------");
                Car c2 = new Car();
                c2.AcceptDetails(4352, "Maruti Swift", "green", "15.70 lack");
                c2.ShowDetails();
                Console.WriteLine("--------------------------------");
                Car c3 = new Car();
                c3.AcceptDetails(3453, "Hondai", "white", "10 lack");
                c3.ShowDetails();
            }
        }
    }

