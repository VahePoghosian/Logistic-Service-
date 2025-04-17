using LogysticSystemService.Abstractions.Interfaces;
using LogysticSystemService.Moduls;
using static LogysticSystemService.Moduls.CarType;
using static LogysticSystemService.Moduls.Container;

namespace LogistycSystem2.Services
{
    class DataBaseService : IDataBaseService
    {

        private readonly IRepository<CarType> _carTypeRepository;
        private readonly IRepository<CarCrushed> _carOperableRepository;
        private readonly IRepository<Direction> _carDirectionRepository;
        private readonly IRepository<Container> _carContainer;



        public DataBaseService(IRepository<CarType> carTypeRepository,
            IRepository<CarCrushed> carOperableRepository,
            IRepository<Direction> _carDirectionRepository,
            IRepository<Container> _carContainer)
        {
            
        }

        public CalculationModel CalculationModel(string from, string to, System.ComponentModel.Container container, CarMark carMark, CarModels carModel)
        {
            var carType = _carTypeRepository.GetItem(x => x.TypeOfCar == CarTypeEnum.Sedan);
            var carCrushed = _carOperableRepository.GetItem(x => x.Status == Operable.Yes);
            var carDirection = _carDirectionRepository.GetItem(x => x.PointA == from && x.PointB == to);
            var carContainer = _carContainer.GetItem(x => x.IsOpenedC == IsOpened.Yes);
            return new CalculationModel(carType, carDirection, carContainer, carCrushed);

        }
    }
}
