using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class BubbleSort
    {
        /// <summary>
        /// バブルソートによるソート
        /// </summary>
        public static void Sort()
        {
            int[] data = { 30, 20, 50, 10, 40 };

            for(int i = 0; i < data.Length - 1; i++)
            {
                for(int j = data.Length - 1; i < j; j--)
                {
                    if (data[j] < data[j - 1])
                    {
                        int temp = data[j];
                        data[j] = data[j - 1];
                        data[j - 1] = temp;
                    }
                }
            }

            foreach(int num in data)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
