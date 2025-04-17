using LogysticSystemService.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.MainRequest
{
    public class Request
    {
        public string From {  get; set; }
        public string To { get; set; }
        public  Container Container { get; set; }

        public CarMark CarMark { get; set; }

        public CarModels CarModels { get; set; }
        public CarCrushed CarCrushed { get; set; }

        public Request(string from,string to,Container container,CarMark carMark,CarModels carModels,CarCrushed carCrushed)
        {
            From = from;
            To = to;
            Container = container;
            CarModels = carModels;
            CarCrushed = carCrushed;


        
        }

    }
}
