using LogysticSystemService.Abstractions.Interfaces;
using LogysticSystemService.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogysticSystemService.Services
{
    public class CalculationService : ICaculationService
    {
        private readonly IDataBaseService _databaseService;
        public float Calculate(CalculationModel calculationModel)
        {
            return
                calculationModel.CarType.Cofficient *
                calculationModel.Container.Cofficient *
                calculationModel.Container.Cofficient *
                calculationModel.Direction.Price;
        }
        public CalculationService(IDataBaseService databaseService)
        {
            _databaseService = databaseService;
        }

    }
}
