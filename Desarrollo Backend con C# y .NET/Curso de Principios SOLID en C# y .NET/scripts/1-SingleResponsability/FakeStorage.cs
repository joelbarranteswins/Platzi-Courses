using System.Collections.ObjectModel;

namespace SingleResponsability
{
    public class FakeStorage<T>
    {
        private readonly ObservableCollection<T> collection;

        public FakeStorage()
        {
            collection = new ObservableCollection<T>();
        }

        public T Add(T item)
        {
            collection.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            collection.Remove(item);
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return collection;
        }
    }
}