using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.Moduls
{
    public class CarMark
    {

        public int Id { get; set; }
        public string Brand { get; set; }
        public List<CarModels> Models { get; set; }

        public CarMark(int id, string vrand, List<CarModels> models)
        {
            Id = id;
            Brand = vrand;
            Models = models;

        }
    }
}
