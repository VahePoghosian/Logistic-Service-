using LogysticSystemService.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.Abstractions.Interfaces
{
    internal interface IDataBaseService
    {
        CalculationModel CalculationModel(string from, string to, System.ComponentModel.Container container, CarMark carMark, CarModels carModel);

    }
}
