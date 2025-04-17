using LogysticSystemService.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LogysticSystemService.Moduls.CarType;

namespace LogysticSystemService.Repository
{
    static  class RepositoryStock
    {
        public static void InitializationCarType(List<CarType> _carTypes)
        {
            _carTypes.Add(new CarType(1.1f, CarType.CarTypeEnum.Sedan));
            _carTypes.Add(new CarType(1.1f, CarTypeEnum.Sedan));
            _carTypes.Add(new CarType(1.3f, CarTypeEnum.SUV));
            _carTypes.Add(new CarType(1.6f, CarTypeEnum.Coupe));
            _carTypes.Add(new CarType(1.2f, CarTypeEnum.Hatchback));
            _carTypes.Add(new CarType(1.0f, CarTypeEnum.Sedan));
            _carTypes.Add(new CarType(1.55f, CarTypeEnum.SUV));
            _carTypes.Add(new CarType(1.3f, CarTypeEnum.Coupe));
            _carTypes.Add(new CarType(1.6f, CarTypeEnum.Hatchback));

        }

        public static void InitializeCarMark(List<CarMark> _carMarks)
        {


        }

        public static void CarModelsInitiakizatin(List<CarModels> _carModels)
        {
            _carModels.Add(new CarModels("S-class", 1.1f, 2003, new CarType(1.1f, CarType.CarTypeEnum.Sedan)));
            _carModels.Add(new CarModels("C-class", 1.1f, 2003, new CarType(1.1f, CarTypeEnum.Sedan)));
            _carModels.Add(new CarModels("3 series", 1.3f, 2010, new CarType(1.3f, CarTypeEnum.Coupe)));
            _carModels.Add(new CarModels("quatro", 1.5f, 2012, new CarType(1.5f, CarTypeEnum.SUV)));
            _carModels.Add(new CarModels("Corolla", 1.2f, 2015, new CarType(1.2f, CarTypeEnum.Hatchback)));
            _carModels.Add(new CarModels("Cruze", 1.7f, 2020, new CarType(1.7f, CarTypeEnum.SUV)));
            _carModels.Add(new CarModels("Sonata", 1.0f, 2017, new CarType(1.0f, CarTypeEnum.Sedan)));
            _carModels.Add(new CarModels("Forte", 1.25f, 2016, new CarType(1.25f, CarTypeEnum.Coupe)));
            _carModels.Add(new CarModels("Golf 3", 1.15f, 2011, new CarType(1.15f, CarTypeEnum.Sedan)));
            _carModels.Add(new CarModels("CX 6", 1.45f, 2019, new CarType(1.45f, CarTypeEnum.Hatchback)));
        }
    }
}
