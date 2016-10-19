using System;
using System.Collections;
using System.Collections.Generic;

namespace dz1_zad3
{
    class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;

        private int stLength { get { return _internalStorage.Length; } }

        public int Count
        {
            get
            {
                int i = stLength - 1;
                while (_internalStorage[i] == null)
                {
                    i--;
                    if (i < 0) break;
                }
                return i + 1;
            }
        }

        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
        }

        public void Add(X item)
        {
            if (_internalStorage[stLength - 1] == null)
            {
                for (int i = 0; i < stLength; i++)
                {
                    if (_internalStorage[i] == null)
                    {
                        _internalStorage[i] = item;
                        return;
                    }
                }
            }
            else
            {
                int l = stLength;
                X[] tempStorage = new X[2 * l];
                for (int i = 0; i < l; i++) tempStorage[i] = _internalStorage[i];
                _internalStorage = tempStorage;
                _internalStorage[l] = item;
            }
        }

        public bool Remove(X item)
        {
            int index = IndexOf(item);
            if (index != -1) return RemoveAt(index);
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || stLength <= index) return false;
            //apply bit-shift left 
            for (int i = index; i < stLength - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            //set last element to 0
            _internalStorage[stLength - 1] = default(X);
            return true;
        }

        public X GetElement(int index)
        {
            if (0 <= index && index < stLength) return _internalStorage[index];
            else throw new IndexOutOfRangeException();
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < stLength; i++)
            {
                if (_internalStorage[i].Equals(item)) return i;
            }
            return -1;
        }

        public void Clear()
        {
            for (int i = 0; i < stLength; i++) _internalStorage[i] = default(X);
        }

        public bool Contains(X item)
        {
            if (IndexOf(item) != -1) return true;
            return false;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }    }
}
