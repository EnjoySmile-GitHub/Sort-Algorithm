using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Merge1 : MethodSort
    {
        /// <summary>
        /// マージ（併合）
        /// </summary>
        public override void Sort()
        {
            int[] data1 = { 2, 4, 5, 7, 8 };
            int[] data2 = { 1, 3, 4, 7 };
            int[] data3 = new int[data1.Length + data2.Length];

            int idx1 = 0;
            int idx2 = 0;
            int idx3 = 0;

            while (idx1 < data1.Length && idx2 < data2.Length)
            {
                if (data1[idx1] <= data2[idx2])
                {
                    data3[idx3] = data1[idx1];
                    idx1++;
                    idx3++;
                }
                else
                {
                    data3[idx3] = data2[idx2];
                    idx2++;
                    idx3++;
                }
            }

            while(idx1 < data1.Length)
            {
                data3[idx3] = data1[idx1];
                idx1++;
                idx3++;
            }

            while(idx2 < data2.Length)
            {
                data3[idx3] = data2[idx2];
                idx2++;
                idx3++;
            }

            for (int i = 0; i < data3.Length; i++)
            {
                Console.Write(data3[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
