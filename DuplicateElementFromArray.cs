using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class DuplicateElementFromArray
    {
        public void find()
        {
            int[] array = { 1, 2, 3, 2, 3, 4, 5, 1, 6, 1 };

            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        array[j] = -1;
                    }
                }

                if (array[i] != -1)
                {
                    Console.WriteLine($"{array[i]} is repeated  {count} times");
                }
            }
        }
    }
}
