using LogysticSystemService.Abstractions.Interfaces;
using LogysticSystemService.Moduls;

namespace LogistycSystem2.Services
{
    public class CarMarkService : IRepository<CarMark>
    {
        List<CarMark> _carmarks=new List<CarMark>();
        
        public void Add(CarMark item)
        {
            _carmarks.Add(item);
        }

        public void Delete(CarMark item)
        {
            _carmarks.Remove(item);
        }

        public List<CarMark> GetAll()
        {
            return _carmarks;
        }

        public CarMark GetItem(Func<CarMark, bool> predicate)
        {
            return _carmarks.FirstOrDefault(predicate); 
        }

        public void Update(CarMark oldentity, CarMark newentity)
        {
            _carmarks.ForEach(x =>
            {
                if (x.Equals(oldentity))
                {
                    x = newentity;
                }
            });
        }
    }

}