using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.Moduls
{
    public class CarModels
    {
        public CarModels(string name, float cofficient, int year, CarType carType)
        {
            Id  = new Random().Next(100, 300);

            Name = name;
            Cofficient = cofficient;
            Year = year;
            CarType = carType;


        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public float Cofficient { get; set; }
        public CarType CarType { get; set; }
    }
}
