using System;
using System.Collections;
using System.Collections.Generic;

namespace ISuperCollection
{
    class SuperCollection<T> : ICollection<T> where T : class
    {
        private static int _collectionSize = 20;
        public bool IsReadOnly { get; } = false;

        private T[] _inCollection = new T[_collectionSize];

        public T this[int index]
        {
            get => _inCollection[index];
            set => _inCollection[index] = value;
        }

        public void Add(T item)
        {
            for (int i = 0; i < _collectionSize; i++)
            {
                if (_inCollection[i] == null)
                {
                    _inCollection[i] = item;
                    break;
                }

                if (i == _collectionSize - 1)
                {
                    _collectionSize += 20;
                    Array.Resize(ref _inCollection, _collectionSize);
                    _inCollection[i + 1] = item;
                    break;
                }
            }
        }

        public void Clear() => Array.Clear(_inCollection, 0, _collectionSize);

        public bool Contains(T item)
        {
            for (int i = 0; i < _collectionSize; i++)
            {
                if (_inCollection[i] == item)
                    return true;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex) => Array.Copy(_inCollection, array, _inCollection.Length - arrayIndex);

        public bool Remove(T item)
        {
            int startIndex = 1;

            for (int i = 0; i < _inCollection.Length; i++)
            {
                if (_inCollection[i] == item)
                {
                    startIndex = i;
                    break;
                }

                if (i == _inCollection.Length - 1)
                    return false;
            }

            for (int i = startIndex; i < _inCollection.Length - 1; i++)
            {
                _inCollection[i] = _inCollection[i + 1];

            }
            return true;
        }

        public int Count
        {
            get
            {
                for (int i = 0; i < _inCollection.Length; i++)
                    if (_inCollection[i] == null)
                        return i;
                return 0;
            }

        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < _inCollection.Length; i++)
            {
                if (_inCollection[i] == null)
                    yield break;

                yield return _inCollection[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _inCollection.Length; i++)
            {
                if (_inCollection[i] == null)
                    yield break;

                yield return _inCollection[i];
            }
        }
    }
}
