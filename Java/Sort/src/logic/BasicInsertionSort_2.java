package logic;

import java.util.Random;

public class BasicInsertionSort_2 extends LogicSort {
	// 基本挿入法2
	public void Sort() {
		int[] data = new int[100];
		int dataLength = data.length;

		Random rnd = new Random();
		for (int i = 0; i < dataLength; i++) {
			data[i] = rnd.nextInt(100);
		}
		
		int replaceCount = 0;
		
		for (int i = 1; i < dataLength; i++) {
			int dataTarget = data[i];
			int j = i - 1;
			while (j >= 0 && data[j] > dataTarget) {
				replaceCount++;
				
				data[j + 1] = data[j];
				j--;
			}
			data[j + 1] = dataTarget;
		}

		for (int i = 0; i < dataLength; i++) {
			System.out.print(data[i] + " ");
		}

		System.out.println();
		
		System.out.println("入替回数:" + replaceCount);
	}
}
