using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer.Models
{
    class Room
    {
        public readonly int Id;
        private string _name;
        private float _price;
        private int _personCapacity;
        private bool _isAvailable=true;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public float Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }

        public int PersonCapacity
        {
            get => _personCapacity;
            set
            {
                if (value > 0)
                    _personCapacity = value;
            }
        }





      


        public Room(string Name, float Price, int PersonCapacity)
        {
            Id++;
            this.Name = Name;
            this.Price = Price;
            this.PersonCapacity = PersonCapacity;
        }

        




        public override string ToString()
        {
            return  "Name:"+Name+ "Price:" +  Price +"Person capacity:" +  PersonCapacity +"Available"+  _isAvailable+"ID:" + Id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} \nPrice: {Price} \nPerson capacity: {PersonCapacity} \nAvailable: {_isAvailable} \nID: {Id}");
        }
    }
}

