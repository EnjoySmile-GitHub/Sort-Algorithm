package logic;

public class DirectSelectionSort extends LogicSort {
	// 直接選択法
	public void Sort() {
		int[] data = { 1, 3, 2, 5, 8, 7, 9, 6, 4, 0 };

		for (int i = 0; i < data.length - 1; i++) {
			int minData = data[i];
			int minIndex = i;

			for (int j = i + 1; j < data.length; j++) {
				if (data[j] < minData) {
					minData = data[j];
					minIndex = j;
				}
			}

			int temp = data[i];
			data[i] = data[minIndex];
			data[minIndex] = temp;
		}

		for (int i = 0; i < data.length; i++) {
			System.out.print(data[i] + " ");
		}

		System.out.println();
	}
}
