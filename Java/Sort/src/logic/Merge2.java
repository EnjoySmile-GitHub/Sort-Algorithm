package logic;

/**
 * マージ（併合）_2
 */
public class Merge2 extends LogicSort {
	public void Sort() {
		// 番兵
		final int MAX_NUM = 9999;

		int[] data1 = { 1, 3, 4, 5, 6, 7, 8, MAX_NUM };
		int[] data2 = { 0, 2, 3, 5, 9, MAX_NUM };
		int[] data3 = new int[(data1.length - 1) + (data2.length - 1)];

		int index1 = 0, index2 = 0, index3 = 0;

		while (data1[index1] != MAX_NUM || data2[index2] != MAX_NUM) {
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

		for (int i = 0; i < data3.length; i++) {
			System.out.print(data3[i] + " ");
		}

		System.out.println();
	}
}
