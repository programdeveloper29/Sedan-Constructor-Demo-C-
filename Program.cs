using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sedan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string brand;
            string color;
            char ch;
            Console.WriteLine("**********Sedan Category**********");
            
            do
            {
                //insert value 

                Console.Write("Brand is: ");
                brand = Console.ReadLine();
                Console.Write("Color is: ");
                color = Console.ReadLine();

                Program.PrintType(brand, color);
                Console.WriteLine("**************************");
                // To Repeate
                Console.Write("\nRepeate('y'|'n')?");
                ch = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("\n**************************");
            } while (ch.Equals('y'));
        }
        static void PrintType(string brand,string color)
        {
            Sedan sedan;
            Console.Write($"Constructor Type:\r\n1 => Brand only\r\n2 => Brand + Color\r\nOther number => Default constructor\r\nChoose(1 or 2)?");
            string n=Console.ReadLine();
            if (sbyte.TryParse(n, out sbyte input))
            {
                switch (input)
                {
                    case 1:
                        //object
                        sedan = new Sedan(brand);//use custom constructor1
                        sedan.Color = color;
                        break;
                        case 2:
                         sedan = new Sedan(brand, color);//use custom constructor2

                        
                        break;
                    default:
                         sedan = new Sedan();//use default constructor
                        sedan.Brand = brand;
                        sedan.Color = color;
                        break;
                }
                Console.WriteLine($"Sedan Brand: {sedan.Brand}");
                Console.WriteLine($"Sedan Color: {sedan.Color}");
            }
            else { Console.WriteLine("\nInvalid number, try again: "); }


        }
    }



    class Sedan
    {
        //fields
        private string _brand;
        private string _color;

        //properties
        internal string Brand { get => _brand; set => _brand = value; }
        internal string Color { get => _color; set => _color = value; }

        //Default Constructor
        internal Sedan() { Console.WriteLine("Default Constructor"); }
        // Custom Constructor1
        internal Sedan(string brand) 
        {
            Console.WriteLine("Custom Constructor1");
            _brand = brand; }
        // Custom Constructor2
        internal Sedan(string brand,string color) 
        {
            Console.WriteLine("Custom Constructor2");
            _brand = brand; _color = color; }
        ~Sedan() { Console.WriteLine("Default Destructor => object is died"); }
    
    
    
    
    
    
    
    }


}
