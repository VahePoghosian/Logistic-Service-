namespace LogysticSystemService.Abstractions.Interfaces
{
     interface IDirectionService<T>
    {
        void Add(T item);
        void Remove(T item);
        void Show();
        void Update(int id);
    }
}
