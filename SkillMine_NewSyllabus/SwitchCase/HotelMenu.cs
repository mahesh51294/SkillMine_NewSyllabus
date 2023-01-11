using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.SwitchCase
{
    class HotelMenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Menu Card-----------------");
            Console.WriteLine("1. PavBhaj   70/-\n2. Misal   60/-\n3. Vadapav   20/-\n4. Pavwada  15/-\n5. Samosa  20/-");
            Console.WriteLine("seclect your order");
            int o = int.Parse(Console.ReadLine());
        Console.WriteLine("how many quatity ?...");
            int quantity = int.Parse(Console.ReadLine());
        float bill;
            switch (o)
            {
              case 1:Console.WriteLine("You ordered Pavbhaj....");
                       bill = quantity* 70;
                       Console.WriteLine("your total bill is: " + bill);
                       Console.WriteLine("Thanks for comming ..please visit again...");
                       break;
                case 2:
                    Console.WriteLine("You ordered Misal....");
                    bill = quantity* 60;
                    Console.WriteLine("your total bill is: " + bill);
                    Console.WriteLine("Thanks for comming ..please visit again...");
                    break;
                case 3:
                    Console.WriteLine("You ordered Vadapav....");
                    bill = quantity* 20;
                    Console.WriteLine("your total bill is: " + bill);
                    Console.WriteLine("Thanks for comming ..please visit again...");
                    break;
                case 4:
                    Console.WriteLine("You ordered Vadapav....");
                    bill = quantity* 15;
                    Console.WriteLine("your total bill is: " + bill);
                    Console.WriteLine("Thanks for comming ..please visit again...");
                    break;
                case 5:
                    Console.WriteLine("You ordered Samosa....");
                    bill = quantity* 20;
                    Console.WriteLine("your total bill is: " + bill);
                    Console.WriteLine("Thanks for comming ..please visit again...");
                    break;

            }


}
    }
}
