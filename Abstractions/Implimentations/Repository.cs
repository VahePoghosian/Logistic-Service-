using LogysticSystemService.Abstractions.Interfaces;

namespace LogysticSystemService.Abstractions.Implimentations
{
    internal class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly List<T> _list;
        public void Add(T entity)
        {
            _list.Add(entity);
        }

        public List<T> GetAll()
        {
            return _list;
        }

        public void Delete(T Entity)
        {
            _list.Remove(Entity);
        }

        public T GetItem(Func<T, bool> predicate)
        {
            T item = new T();
            _list.ForEach(X =>
            {
                if (predicate(X))
                {
                    item = X;
                }
            });
            return item;
        }

        public void Update(T OldEntity, T NewEntity)
        {
            _list.ForEach(x =>
            {
                if (x.Equals(OldEntity))
                {
                    x = NewEntity;
                }
            });
        }
    }
}
