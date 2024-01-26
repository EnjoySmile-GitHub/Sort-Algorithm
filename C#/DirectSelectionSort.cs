using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class DirectSelectionSort : MethodSort
    {
        /// <summary>
        /// 直接選択法
        /// </summary>
        public override void Sort()
        {
            int[] data = { 20, 30, 50, 10, 40 };

            for(int i = 0; i < data.Length - 1; i++)
            {
                int minData = data[i];
                int minIndex = i;

                for(int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < minData)
                    {
                        minData = data[j];
                        minIndex = j;
                    }
                }

                int temp = data[i];
                data[i] = data[minIndex];
                data[minIndex] = temp;
            }

            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
