using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Worker
    {
        public int Id { get; set; }
        string _name { get; set; }

        public string Name { 
            get {
                return _name;      
            }
            set { 
                if(value.Length <= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Minimum Lenght must be 2");
                    Console.ForegroundColor= ConsoleColor.White;
                }
                else if (value.Contains(" "))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Name Error");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    _name = value;
                }
            }
        }
    }
}
