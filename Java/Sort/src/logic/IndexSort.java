package logic;

public class IndexSort extends LogicSort {
	// インデックスソート
	public void Sort() {
		String[] kana = { "こばやし", "いとう", "さとう", "うえはら", "いのうえ", "かさい" };
		String[] kanji = { "小林", "伊藤", "佐藤", "上原", "井上", "河西" };
		int[] index = { 0, 1, 2, 3, 4, 5 };

		int kanaLength = kana.length;
		for (int i = 0; i < kanaLength - 1; i++) {
			for (int j = kanaLength - 1; j > i; j--) {
				if (kana[index[j]].compareTo(kana[index[j - 1]]) < 0) {
					int temp = index[j];
					index[j] = index[j - 1];
					index[j - 1] = temp;
				}
			}
		}

		for (int i = 0; i < kanaLength; i++) {
			System.out.println(kanji[index[i]] + " " + kana[index[i]]);
		}
	}
}
