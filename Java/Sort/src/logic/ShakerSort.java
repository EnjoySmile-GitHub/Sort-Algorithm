package logic;

public class ShakerSort extends LogicSort {
	// シェーカーソート
	public void Sort() {
		int[] data = { 3, 5, 6, 9, 2, 7, 8, 4, 1, 0, 10 };

		int left = 0;
		int right = data.length - 1;
		int shift = 0;

		while (left < right) {
			for (int i = left; i < right; i++) {
				if (data[i] > data[i + 1]) {
					int temp = data[i];
					data[i] = data[i + 1];
					data[i + 1] = temp;
					shift = i;
				}
			}
			
			right = shift;

			for (int i = right; i > left; i--) {
				if (data[i - 1] > data[i]) {
					int temp = data[i];
					data[i] = data[i - 1];
					data[i - 1] = temp;
					shift = i;
				}
			}
			
			left = shift;
		}

		for (int i = 0; i < data.length; i++) {
			System.out.print(data[i] + " ");
		}

		System.out.println();
	}
}
