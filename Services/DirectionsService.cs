using LogistycSystem2.Abstractions.Interfaces;
using LogistycSystem2.Moduls;
using System;
using System.Collections.Generic;

namespace LogistycSystem2.Services
{
    public class DirectionsService : IDirectionService<Direction>
    {
        List<Direction> _directions=new List<Direction>();

        public void Add(Direction item)
        {
            _directions.Add(item);

        }

        public void Remove(Direction direction)
        {
           _directions.Remove(direction);
        }


        public void Show()
        {
            foreach(Direction item in _directions)
            {
                Console.WriteLine($"ID{item.Id} To take from{item.PointA} | To Take to {item.PointB} | Distance {item.Distance}");
            }
        }

        public void Update(int id)
        {
            foreach( Direction item in _directions)
            {
                if(item.Id == id)
                {
                    Console.WriteLine("Enter the point to take from");
                    item.PointA = Console.ReadLine();
                    Console.WriteLine("Enter the point to take to");
                    item.PointB = Console.ReadLine();
                    Console.WriteLine("Enter the distance");
                    item.Distance=int.Parse(Console.ReadLine());

                }
            }
        }
    }
}
