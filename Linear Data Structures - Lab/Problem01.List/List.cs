namespace Problem01.List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class List<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] _items;

        public List() : this(DEFAULT_CAPACITY)
        {
            _items = new T[DEFAULT_CAPACITY];
            Count = 0;
        }

        public List(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot create list with negative capacity");
            }

            _items = new T[capacity];
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);

                return _items[index];
            }
            set
            {
                ValidateIndex(index);

                _items[index] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            GrowIfNecessary();

            _items[Count++] = item;
        }

        public bool Contains(T item)
        {
            bool result = false;

            foreach (T currentItem in _items)
            {
                if (currentItem.ToString() == item.ToString())
                {
                    result = true;

                    break;
                }
            }

            return result;
        }


        public int IndexOf(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].ToString() == item.ToString())
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            ValidateIndex(index);
            GrowIfNecessary();

            for (int i = Count; i > index; i--)
            {
                _items[i] = _items[i - 1];
            }

            _items[index] = item;
            Count++;
        }

        public bool Remove(T item)
        {
            if (_items.Contains(item))
            {
                for (int i = 0; i < _items.Length; i++)
                {
                    if (_items[i].ToString() == item.ToString())
                    {
                        for (int j = i; j < Count; j++)
                        {
                            _items[j] = _items[j + 1];
                        }
                    }
                }

                Count--;

                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);

            for (int i = index; i < Count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[Count - 1] = default;
            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void ValidateIndex(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        private void GrowIfNecessary()
        {
            if (Count >= _items.Length)
            {
                _items = Grow();
            }
        }

        private T[] Grow()
        {
            T[] result = new T[Count * 2];
            Array.Copy(_items, result, _items.Length);
            return result;
        }
    }
}