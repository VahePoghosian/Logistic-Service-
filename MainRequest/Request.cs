using LogysticSystemService.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogysticSystemService.Moduls.Container;

namespace LogysticSystemService.MainRequest
{
    public class Request
    {
        public string From {  get; set; }
        public string To { get; set; }
        public IsOpened IsOpen { get; set; }

        public string CarModel {  get; set; }
        public string CarMark { get; set; }
        public Operable Operable { get; set; }

        public Request(string from,string to,IsOpened isOpened,string carModel,string carMark, Operable iSOperable)
        {
            From = from;
            To = to;
            IsOpen = isOpened;
            CarModel = carModel;
            CarMark = carMark;
            Operable = iSOperable;

           
        }
    }
}
