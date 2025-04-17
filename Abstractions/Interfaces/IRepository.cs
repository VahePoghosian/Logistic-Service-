namespace LogysticSystemService.Abstractions.Interfaces
{
     interface IRepository<T>
    {
        void Add(T item);
        void Delete(T item);
        void Update(T oldentity, T newentity);
        T GetItem(Func<T, bool> predicate);
        List<T> GetAll();
    }
}
