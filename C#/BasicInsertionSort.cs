using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    /// <summary>
    /// 基本挿入法
    /// </summary>
    internal class BasicInsertionSort : MethodSort
    {
        public override void Sort()
        {
            int[] data = { 5, 4, 8, 9, 1, 3, 2, 6, 7, 0 };

            for(int i = 0; i < data.Length; i++)
            {
                for(int j = i - 1; j > -1; j--)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                    else
                    {
                        break;
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
