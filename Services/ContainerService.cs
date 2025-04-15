using LogysticSystemService.Abstractions.Interfaces;
using System.ComponentModel;
namespace LogistycSystem2.Services
{
    public class ContainerService : IRepository<Container>
    {
        List<Container> _containers = new List<Container>();

        public void Add(Container item)
        {
            _containers.Add(item);
        }

        public void Delete(Container item)
        {
            _containers.Remove(item);
        }

        public List<Container> GetAll()
        {
            return _containers;
        }

        public Container GetItem(Func<Container, bool> predicate)
        {
            return _containers.FirstOrDefault(predicate);
        }

        public void Update(Container oldentity, Container newentity)
        {
            _containers.ForEach(x =>
            {
                if (x.Equals(oldentity))
                {
                    x = newentity;
                }
            });
        }
    }
}
