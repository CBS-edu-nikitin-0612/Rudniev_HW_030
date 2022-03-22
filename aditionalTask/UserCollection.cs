using System;
using System.Collections;

namespace aditionalTask
{
    class UserCollection
    {
        private int[] array = new int[10];

        public int Count
        {
            get => array.Length;
        }
        public int this[int index] 
        {
            set { array[index] = value; } 
            get { return array[index]; } 
        }
        public UserCollection()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0, 9);
        }
        public IEnumerator GetEnumerator(int[] array)
        {
            int position = -1;
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    if ((array[position] % 2) == 1)
                        yield return Math.Pow(array[position], 2);
                }
                else
                    yield break;
            }
        }
    }
}
