using System;
using System.Collections;

namespace Task2
{
    class MonthCollection : IList
    {
        private Month[] array;

        private object syncRoot;
        public object this[int index] 
        { 
            get => array[index];
            set
            {
                if (value is Month)
                    array[index] = (Month)value;
            }
        }

        public bool IsFixedSize => true;

        public bool IsReadOnly => true;

        public int Count => array.Length;

        public bool IsSynchronized => true;

        public object SyncRoot => syncRoot;

        public MonthCollection()
        {
            this.syncRoot = new object();
            this.array = new Month[12]
            {
                new Month("January", 31),
                new Month("February", 28),
                new Month("March", 31),
                new Month("April", 30),
                new Month("May", 31),
                new Month("June", 30),
                new Month("July", 31),
                new Month("August", 31),
                new Month("September", 30),
                new Month("October", 31),
                new Month("November", 30),
                new Month("December", 31)
            };
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
            //array = new Month[12];
        }

        public bool Contains(object value)
        {
            if (value is Month)
            {
                foreach (Month el in array)
                    if (el.Equals((Month)value))
                        return true;
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
            if (value is Month)
            {
                for (int i = 0; i < this.array.Length; i++)
                    if (array[i].Equals((Month)value))
                        return i;
            }
            //throw new ArgumentException("not found");
            return -1;
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            //try
            //{
            //    int index = this.IndexOf(value);
            //    array[index] = new Month();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            //array[index] = new Month();
            throw new NotImplementedException();
        }

        public IEnumerable CreateCollectionMonthsWithSameAmountOfDays(int amountDays)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].AmountDays == amountDays)
                    yield return array[i];
            }
            yield break;
        }
    }
}
