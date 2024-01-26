using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class ShellSort_1 : MethodSort
    {
        /// <summary>
        /// シェルソート1（改良挿入法）
        /// </summary>
        public override void Sort()
        {
            Random rnd = new Random();
            int[] data = new int[100];

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(100);
            }

            int gap = data.Length / 2;

            while(gap > 0)
            {
                // ギャップとびの部分数列のソート
                for(int k = 0; k < gap; k++)
                {
                    for(int i = k + gap; i < data.Length; i += gap)
                    {
                        for(int j = i - gap; j > k - 1; j -= gap)
                        {
                            if (data[j] > data[j + gap])
                            {
                                int temp = data[j];
                                data[j] = data[j + gap];
                                data[j + gap] = temp;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                gap /= 2;
            }

            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
