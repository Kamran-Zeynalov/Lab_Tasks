using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Company
    {
        string _name;
        public string Name { 
            get {
                return _name;     
            } 
            set {
                if (Char.IsLower(value[0]))
                {
                     char bigLetter = Char.ToUpper(value[0]);
                    value = value.Substring(1);
                    _name = bigLetter + value;
                }
                else { 
                _name = value;
                }
            }
        }
        public int WorkerCount { get; set; }
        public string Location { get; set; }
        public Worker[] Workers { get; set; }

        public Company(string name, string location, int capacity)
        {
            Name = name;
            Location = location;
            WorkerCount = 0;
            Workers = new Worker[capacity];
        }

        public void AddWorker(Worker worker)
        {
            if (WorkerCount < Workers.Length)
            {
                Workers[WorkerCount] = worker;
                WorkerCount++;
                Console.WriteLine(worker.Name + " added");
            }
            else
            {
                Console.WriteLine("Company workers is full");
            }
        }
        public void RemoveWorker(string name)
        {
            for (int i = 0; i < WorkerCount; i++)
            {
                if (Workers[i].Name == name)
                {
                    
                    for (int j = i; j < WorkerCount - 1; j++)
                    {
                        Workers[j] = Workers[j + 1];
                    }

                    Workers[WorkerCount - 1] = null;
                    WorkerCount--;

                    Console.WriteLine(name + " removed");
                    return;
                }
            }

            Console.WriteLine("Worker not found.");
        }

    }
}
