using LogistycSystem2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.Moduls
{
    public class CarType
    {

        public int Id { get; set; }
        public float Cofficient { get; set; }
        public CarTypeEnum TypeOfCar { get; set; }
        public CarType(float cofficient,CarTypeEnum carTypeEnum)
        {
            Id = new Random().Next(100, 300);
            TypeOfCar = carTypeEnum;

            Cofficient = cofficient;
        }
        public enum CarTypeEnum
        {
            Sedan,
            SUV,
            Hatchback,
            Coupe,
        }
    }
}
