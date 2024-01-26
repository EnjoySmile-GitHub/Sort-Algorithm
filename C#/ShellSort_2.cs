using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class ShellSort_2 : MethodSort
    {
        /// <summary>
        /// シェルソート2（改良挿入法）
        /// </summary>
        public override void Sort()
        {
            Random rnd = new Random();
            int[] data = new int[100];

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = rnd.Next(100);
            }

            int gap = 1;
            while(gap < data.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while(gap > 0)
            {
                for(int i = gap; i < data.Length; i++)
                {
                    for(int j = i - gap; j > -1; j -= gap)
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

                gap /= 3;
            }

            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
