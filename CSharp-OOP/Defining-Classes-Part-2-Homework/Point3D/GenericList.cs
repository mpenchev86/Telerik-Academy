using System;
using System.Collections.Generic;

namespace Point3D
{
    class GenericList<T> where T : IComparable
    {
        private T[] list;
        private int currentIndex = 0;

        public GenericList(int capacity)
        {
            this.List = new T[capacity];
        }

        public T[] List
        {
            get
            {
                return this.list;
            }
            private set
            {
                this.list = value;
            }
        }

        public int CurrentIndex
        {
            get
            {
                return this.currentIndex;
            }
            set
            {
                this.currentIndex = value;
            }
        }

        public void AddElement(T element)
        {
            if (CurrentIndex < this.List.Length)
            {
                this.List[this.CurrentIndex] = element;
                this.CurrentIndex++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void RemoveElement(int index)
        {
            if (index <= CurrentIndex)
            {
                for (int i = index + 1; i < CurrentIndex; i++)
                {
                    this.List[i - 1] = this.List[i];
                }
                this.List[CurrentIndex] = default(T);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public T AccessElement(int index)
        {
            if (index <= CurrentIndex)
            {
                return this.List[index];
            }
            
            throw new IndexOutOfRangeException();
        }

        public void InsertElement(int index, T element)
        {
            if (CurrentIndex < this.List.Length - 1 && index <= CurrentIndex)
            {
                for (int i = CurrentIndex; i >= index; i--)
                {
                    this.List[i + 1] = this.List[i];
                }
                this.List[index] = element;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void ClearList()
        {
            for (int i = 0; i < this.List.Length; i++)
            {
                this.List[i] = default(T);
            }
        }

        public int FindElement(T element)
        {
            for (int i = 0; i < this.List.Length; i++)
            {
                if (this.List[i].Equals(element))
                {
                    return i;
                }
            }

            throw new ArgumentException();
        }

        public T Min()
        {
            T min = this.List[0];

            for (int i = 0; i < CurrentIndex; i++)
            {
                if (this.List[i].CompareTo(min) < 0)
                {
                    min = this.List[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.List[0];

            for (int i = 0; i < CurrentIndex; i++)
            {
                if (this.List[i].CompareTo(max) > 0)
                {
                    max = this.List[i];
                }
            }
            return max;
        }

    }
}
