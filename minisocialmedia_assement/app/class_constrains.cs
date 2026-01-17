// using System;
// using System.Collections.Generic;
// namespace MiniSocialMedia{
// public class Repository<T> where T : class
// {
//     private readonly List<T> _items = new();

//     public void Add(T item) => _items.Add(item);

//     public IReadOnlyList<T> GetAll() => _items.AsReadOnly();

//     public T? Find(Predicate<T> match)
//     {
//         foreach (var item in _items)
//         {
//             if (match(item))
//                 return item;
//         }
//         return null;
//     }
// }
// }


using System;
using System.Collections.Generic;

namespace MiniSocialMedia
{
    public class Repository<T> where T : class
    {
        private readonly List<T> _items = new();

        public void Add(T item) => _items.Add(item);

        public IReadOnlyList<T> GetAll() => _items.AsReadOnly();

        // Added to allow loading data from JSON
        public void LoadRange(IEnumerable<T> items)
        {
            _items.Clear();
            _items.AddRange(items);
        }

        public T? Find(Predicate<T> match)
        {
            foreach (var item in _items)
            {
                if (match(item))
                    return item;
            }
            return null;
        }
    }
}