using LogistycSystem2.Abstractions.Interfaces;
using LogistycSystem2.Moduls;
using static LogistycSystem2.Moduls.Container;

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

        public CaculationModel CalculationModel(string from, string to, Container container, CarMark carMark, CarModels carModel)
        {
            var carType = _carTypeRepository.GetItem(x => x.TypeOfCar == CarTypeEnum.Sedan);
            var carCrushed = _carOperableRepository.GetItem(x => x.Status == Operable.Yes);
            var carDirection = _carDirectionRepository.GetItem(x => x.PointA == from && x.PointB == to);
            var carContainer = _carContainer.GetItem(x => x.IsOpenedC == IsOpened.Yes);





            return new CaculationModel(carType, carDirection, carContainer, carCrushed);
        }
    }
}
