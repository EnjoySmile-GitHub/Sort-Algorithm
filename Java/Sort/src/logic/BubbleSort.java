package logic;

public class BubbleSort extends LogicSort {
	// バブルソート
	public void Sort() {
		int[] data = { 20, 30, 10, 50, 40 };

		for (int i = 0; i < data.length - 1; i++) {
			for (int j = data.length - 1; j > i; j--) {
				if (data[j - 1] > data[j]) {
					int temp = data[j];
					data[j] = data[j - 1];
					data[j - 1] = temp;
				}
			}
		}

		for (int i = 0; i < data.length; i++) {
			System.out.print(data[i] + " ");
		}

		System.out.println();
	}
}
