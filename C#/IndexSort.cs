using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class IndexSort : MethodSort
    {
        /// <summary>
        /// インデックスソート
        /// </summary>
        public override void Sort()
        {
            string[] kana = { "こばやし", "いとう", "さとう", "うえはら", "いのうえ", "かさい" };
            string[] kanji = { "小林", "伊藤", "佐藤", "上原", "井上", "河西" };
            int[] index = { 0, 1, 2, 3, 4, 5 };

            for(int i = 0; i < kana.Length - 1; i++)
            {
                for(int j = kana.Length - 1; j > i; j--)
                {
                    if (String.Compare(kana[index[j - 1]], kana[index[j]]) > 0)
                    {
                        int temp = index[j];
                        index[j] = index[j - 1];
                        index[j - 1] = temp;
                    }
                }
            }

            for(int i = 0; i < kana.Length; i++)
            {
                Console.WriteLine(kana[index[i]] + " " + kanji[index[i]]);
            }
        }
    }
}
