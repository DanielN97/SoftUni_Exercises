namespace Problem03.ReversedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ReversedList<T> : IAbstractList<T>
    {
        private const int DefaultCapacity = 4;

        private T[] _items;

        public ReversedList()
            : this(DefaultCapacity) { }

        public ReversedList(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            this._items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                EnsureIndexIsInRange(index);

                return _items[Count - index - 1];
            }
            set
            {
                EnsureIndexIsInRange(index);

                _items[index] = value;
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (Count == _items.Length)
            {
                T[] newArray = new T[Count * 2];

                Array.Copy(_items, newArray, Count);

                _items = newArray;
            }

            _items[Count++] = item;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T item)
        {
            //?
            for (int i = Count - 1; i >= 0; i--)
            {
                if (_items[i].Equals(item))
                {
                    return Count - i - 1;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            EnsureIndexIsInRange(index);

            GrowIfNeeded(_items, Count);

            for (int i = Count; i >= Count - index; i--)
            {
                _items[i] = _items[i - 1];
            }

            _items[Count - index] = item;

            Count++;
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(item))
                {
                    for (int j = i; j < Count; j++)
                    {
                        _items[j] = _items[j + 1];
                    }

                    _items[Count] = default(T);

                    Count--;

                    return true;
                }
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            EnsureIndexIsInRange(index);

            for (int j = Count - index - 1; j < Count; j++)
            {
                _items[j] = _items[j + 1];
            }

            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void EnsureIndexIsInRange(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        private void GrowIfNeeded(T[] _items, int Count)
        {
            if (Count == _items.Length)
            {
                T[] newArray = new T[Count * 2];

                Array.Copy(_items, newArray, Count);

                _items = newArray;
            }
        }
    }
}