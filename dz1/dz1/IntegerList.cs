using System;

namespace dz1
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;

        private int stLength { get { return _internalStorage.Length; } }

        public int Count
        {
            get
            {
                int i = stLength-1;
                while (_internalStorage[i] == 0) {
                    i--;
                    if (i < 0) break;
                }
                return i + 1;
            }
        }

        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
        }

        public void Add(int item)
        {
            if(_internalStorage[stLength-1] == 0)
            {
                for (int i = 0; i < stLength; i++)
                {
                    if (_internalStorage[i] == 0)
                    {
                        _internalStorage[i] = item;
                        return;
                    }
                }
            }
            else
            {
                int l = stLength;
                int[] tempStorage = new int[2 * l];
                for (int i = 0; i < l; i++) tempStorage[i] = _internalStorage[i];
                _internalStorage = tempStorage;
                _internalStorage[l] = item;
            }
        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);
            if (index != -1) return RemoveAt(index);
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || stLength <= index) return false;
            //apply bit-shift left 
            for(int i = index; i<stLength - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            //set last element to 0
            _internalStorage[stLength - 1] = 0;
            return true;
        }

        public int GetElement(int index)
        {
            if (0 <= index && index < stLength) return _internalStorage[index];
            else throw new IndexOutOfRangeException();
        }

        public int IndexOf(int item)
        {
            for(int i=0; i<stLength; i++)
            {
                if (_internalStorage[i] == item) return i;
            }
            return -1;
        }

        public void Clear()
        {
            for (int i = 0; i < stLength; i++) _internalStorage[i] = 0;
        }

        public bool Contains(int item)
        {
            if (IndexOf(item) != -1) return true;
            return false;
        }
    }
}
