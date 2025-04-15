using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.Moduls
{
    public class Direction
    {
        public int Id { get; set; }
        public string PointA { get; set; }
        public string PointB { get; set; }
        public int Distance { get; set; }
        public float Price { get; set; }

        public Direction(int id, string pointA, string pointB, int distance, int price)
        {
            PointA = pointA;
            PointB = pointB;
            Id = id;
            Distance = distance;
            Price = price;
        }
    }
}
