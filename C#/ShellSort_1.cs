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
        /// シェルソート（改良挿入法）
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

            }
        }
    }
}
