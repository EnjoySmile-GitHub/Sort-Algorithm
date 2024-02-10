using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Merge2 : MethodSort
    {
        /// <summary>
        /// マージ（併合） 番兵を立てる
        /// </summary>
        public override void Sort()
        {
            const int MAX = 9999;

            int[] data1 = { 2, 4, 6, 8, 9, MAX };
            int[] data2 = { 1, 3, 5, 6, 7, 10, MAX };
            int[] data3 = new int[(data1.Length - 1) + (data2.Length - 1)];

            int idx1 = 0;
            int idx2 = 0;
            int idx3 = 0;

            while (data1[idx1] != MAX || data2[idx2] != MAX)
            {
                if (data1[idx1] <= data2[idx2])
                {
                    data3[idx3] = data1[idx1];
                    idx1++;
                    idx3++;
                }
                else
                {
                    {
                        data3[idx3] = data2[idx2];
                        idx2++;
                        idx3++;
                    }
                }
            }

            for (int i = 0; i < data3.Length; i++)
            {
                Console.Write(data3[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
