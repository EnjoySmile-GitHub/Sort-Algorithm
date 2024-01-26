using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class ShakerSort : MethodSort
    {
        /// <summary>
        /// シェーカーソート
        /// </summary>
        public override void Sort()
        {
            int[] data = { 3, 5, 6, 9, 2, 8, 7, 10, 4, 1 };

            int left = 0;
            int right = data.Length - 1;
            int shift = 0;
            while(left < right)
            {
                for(int i = left; i < right; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        int temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                        shift = i;
                    }
                }

                right = shift;

                for(int i = right; i > left; i--)
                {
                    if (data[i - 1] > data[i])
                    {
                        int temp = data[i];
                        data[i] = data[i - 1];
                        data[i - 1] = temp;
                        shift = i;
                    }
                }

                left = shift;
            }

            foreach(int num in data)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
