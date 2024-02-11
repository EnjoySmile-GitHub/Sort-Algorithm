package logic;

/**
 * マージ（併合）_1
 */
public class Merge1 extends LogicSort {
	public void Sort() {
		int[] data1 = { 1, 3, 4, 5, 7, 8 };
		int[] data2 = { 0, 2, 3, 5, 9 };
		int[] data3 = new int[data1.length + data2.length];

		int index1 = 0, index2 = 0, index3 = 0;

		while (index1 < data1.length && index2 < data2.length) {
			if (data1[index1] <= data2[index2]) {
				data3[index3] = data1[index1];
				index1++;
				index3++;
			} else {
				data3[index3] = data2[index2];
				index2++;
				index3++;
			}
		}

		while (index1 < data1.length) {
			data3[index3] = data1[index1];
			index1++;
			index3++;
		}

		while (index2 < data2.length) {
			data3[index3] = data2[index2];
			index2++;
			index3++;
		}

		for (int i = 0; i < data3.length; i++) {
			System.out.print(data3[i] + " ");
		}

		System.out.println();
	}
}
