using Indexer.Models;
using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("No1",23,2);
            Hotel hotel1 = new Hotel("Absheron Mariot", 12);
            
            Console.WriteLine(room1.ToString());
            hotel1.AddRoom(room1);
                
        }
    }
}
