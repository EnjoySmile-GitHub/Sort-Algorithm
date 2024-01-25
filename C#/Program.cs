﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using C_;

const int SORT_COUNT = 5;

MethodSort[] sort = new MethodSort[SORT_COUNT];

// 直接選択法
sort[0] = new DirectSelectionSort();
// バブルソート
sort[1] = new BubbleSort();
// シェーカーソート
sort[2] = new ShakerSort();
// インデックスソート
sort[3] = new IndexSort();
// 基本挿入法
sort[4] = new BasicInsertionSort();

for(int i = 0;i < sort.Length; i++)
{
    if (sort[i] == null)
    {
        continue;
    }

    sort[i].Sort();
}