package logic;

import java.util.Random;

public class ShellSort_1 extends LogicSort {
	// シェルソート（改良挿入法）1
	public void Sort() {
		int[] data = new int[100];
		int dataLength = data.length;

		Random rnd = new Random();
		for (int i = 0; i < dataLength; i++) {
			data[i] = rnd.nextInt(100);
		}

		int gap = dataLength / 2;
		int replaceCount = 0;
		
		while (gap > 0) {
			for (int k = 0; k < gap; k++) {
				for (int i = k + gap; i < dataLength; i += gap) {
					for (int j = i - gap; j > -1; j -= gap) {
						if (data[j] > data[j + gap]) {
							replaceCount++;
							
							int temp = data[j];
							data[j] = data[j + gap];
							data[j + gap] = temp;
						} else {
							break;
						}
					}
				}
			}

			gap /= 2;
		}

		for (int i = 0; i < dataLength; i++) {
			System.out.print(data[i] + " ");
		}

		System.out.println();
		
		System.out.println("入替回数:" + replaceCount);
	}
}
