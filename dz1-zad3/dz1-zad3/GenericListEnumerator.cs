using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_zad3
{
    class GenericListEnumerator<T> : IEnumerator<T>
    {
        private GenericList<T> _gList;
        private int currentIndex;
        private T current;

        public GenericListEnumerator(GenericList<T> list)
        {
            _gList = list;
            currentIndex = -1;
            current = default(T);
        }

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= _gList.Count)
            {
                return false;
            }
            else
            {
                current = _gList.GetElement(currentIndex);
            }
            return true;
        }

        public void Reset() { currentIndex = -1; }

        void IDisposable.Dispose() { }

        public T Current
        {
            get { return current; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
