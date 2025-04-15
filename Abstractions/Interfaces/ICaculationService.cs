using LogysticSystemService.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.Abstractions.Interfaces
{
     interface ICaculationService
    {
        float Calculate(CalculationModel calculationModel);

    }
}
