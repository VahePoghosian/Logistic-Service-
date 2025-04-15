using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.Moduls
{
    public class CarCrushed
    {

        public bool IsCrushed { get; set; }
        public float Cofficient { get; set; }
        public Operable Status { get; set; }

        public CarCrushed(bool isCrushed, float cofficient)
        {
            IsCrushed = isCrushed;
            Cofficient = cofficient;

        }
    }
    public enum Operable
    {
        Yes = 1,
        No = 0,
    }
}
