using LogistycSystem2.Abstractions.Interfaces;
using LogistycSystem2.Moduls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogistycSystem2.Services
{
    internal class CarTypeService : IRepository<CarType>
    {
       private List<CarType> _carTypes=new List<CarType>();

        public void Add(CarType item)
        {
            _carTypes.Add(item);
        }

        public void Delete(CarType item)
        {
            _carTypes.Remove(item);
        }

        public List<CarType> GetAll()
        {
            return _carTypes;
        }

        public CarType? GetItem(Func<CarType, bool> predicate)
        {
            return _carTypes.FirstOrDefault(predicate);
        }

        public void Update(CarType oldentity, CarType newentity)
        {
            _carTypes.ForEach(x =>
            {
                if (x.Equals(oldentity))
                {
                    x = newentity;
                }
            });
        }
    }
}
