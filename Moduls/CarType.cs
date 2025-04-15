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
        public string Name { get; set; }
        public float Cofficient { get; set; }
        public CarTypeEnum TypeOfCar { get; set; }
        public CarType(int id, string name, float cofficient)
        {
            Id = id;
            Name = name;
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
