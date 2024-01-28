package logic;

import java.util.Random;

public class BasicInsertionSort_1 extends LogicSort {
	// 基本挿入法1
	public void Sort() {
		int[] data = new int[100];
		int dataLength = data.length;

		Random rnd = new Random();
		for (int i = 0; i < dataLength; i++) {
			data[i] = rnd.nextInt(100);
		}
		
		int replaceCount = 0;

		for (int i = 1; i < dataLength; i++) {
			for (int j = i - 1; j > -1; j--) {
				if (data[j] > data[j + 1]) {
					replaceCount++;
					
					int temp = data[j];
					data[j] = data[j + 1];
					data[j + 1] = temp;
				} else {
					break;
				}
			}
		}

		for (int i = 0; i < dataLength; i++) {
			System.out.print(data[i] + " ");
		}

		System.out.println();
		
		System.out.println("入替回数:" + replaceCount);
	}
}
