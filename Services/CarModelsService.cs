using LogysticSystemService.Abstractions.Interfaces;
using LogysticSystemService.Moduls;

namespace LogistycSystem2.Services
{
    public class CarModelSservice : IRepository<CarModels>
    {
        List<CarModels> models=new List<CarModels>();
        public void Add(CarModels item)
        {
            models.Add(item);
        }

        public void Delete(CarModels item)
        {
            models.Remove(item);
        }

        public List<CarModels> GetAll() {

            return models;

        }

        public CarModels GetItem(Func<CarModels, bool> predicate)
        {
            return models.FirstOrDefault(predicate);
        }

        public void Update(CarModels oldentity, CarModels newentity)
        {
            models.ForEach(x =>
            {
                if (x.Equals(oldentity))
                {
                    x = newentity;
                }
            });
        }
    }
}