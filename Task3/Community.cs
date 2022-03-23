using System;
using System.Collections;

namespace Task3
{
    class Community : IList
    {
        private Citizen[] array;
        private int numberOfRetiree;
        public object this[int index] 
        { 
            get => array[index]; 
            set => array[index] = value as Citizen; 
        }

        public bool IsFixedSize => false;

        public bool IsReadOnly => false;

        public int Count => array.Length;

        public bool IsSynchronized => false;

        public object SyncRoot => new object();

        public Community()
        {
            this.array = new Citizen[0];
            this.numberOfRetiree = 0;
        }

        public int Add(object value)
        {
            int index;
            var val = value as Citizen;

            if (val != null)
            {
                for (int i = 0; i < array.Length; i++)
                    if (array[i].Equals(val))
                        throw new Exception($"This citizen already on the list at index {i}.");

                var tempArray = new Citizen[array.Length + 1];

                if (val is Retiree)
                {
                    for (int i = 0; i < numberOfRetiree; i++)
                        tempArray[i] = array[i];

                    index = numberOfRetiree;
                    tempArray[index] = val;

                    for (int i = numberOfRetiree; i < array.Length; i++)
                        tempArray[i + 1] = array[i];

                    ++numberOfRetiree;
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                        tempArray[i] = array[i];

                    index = array.Length;
                    tempArray[index] = val;
                }
                this.array = tempArray;
                return index;
            }
            else
                return -1;
        }

        public void Clear()
        {
            array = new Citizen[0];
        }

        public bool Contains(object value)
        {
            var val = value as Citizen;

            if (val != null)
            {
                foreach (Citizen el in array)
                    if (el.Equals(val))
                        return true;
            }
            return false;
        }
        public bool Contains(object value, out int index)
        {
            var val = value as Citizen;
            index = -1;

            if (val != null)
            {
                for (int i = 0; i < array.Length; i++)
                    if (array[i].Equals(val))
                    {
                        index = i;
                        return true;
                    }
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            var arr = array as object[];

            if (arr.Length - index >= this.array.Length && arr != null)
                for (int i = 0; i < this.array.Length; i++)
                    arr[index++] = this.array[i];
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            var val = value as Citizen;

            if (val != null)
            {
                for (int i = 0; i < this.array.Length; i++)
                    if (array[i].Equals(val))
                        return i;
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            int index = this.IndexOf(value);
            this.RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                var tempArray = new Citizen[array.Length - 1];
                for (int i = 0; i < index; i++)
                    tempArray[i] = array[i];
                for (int i = index + 1; i < array.Length; i++)
                    tempArray[index++] = array[i];
                array = tempArray;

                if (index < numberOfRetiree)
                    --numberOfRetiree;
            }
        }

        public object ReturnLast(out int index)
        {
            index = -1;
            if (array.Length > 0)
            {
                index = array.Length - 1;
                return array[index];
            }
            return null;
        }
    }
}
