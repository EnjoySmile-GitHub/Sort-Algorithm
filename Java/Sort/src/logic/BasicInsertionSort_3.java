package logic;

import java.util.Random;

public class BasicInsertionSort_3 {
	public static void main(String[] args) {
		// 基本挿入法3（番兵をたてる）
		final int DATA_COUNT = 100;
		int[] data = new int[DATA_COUNT];
		Random rnd = new Random();
		for(int i = 1; i < DATA_COUNT ; i++) {
			data[i] = rnd.nextInt(1001);
		}
		
		// 番兵
		data[0] = -9999;
		
		for(int i = 2; i < DATA_COUNT; i++) {
			int tmp = data[i];
			int index = i - 1;
			while(data[index]> tmp) {
				data[index + 1] = data[index];
				index--;
			}
			data[index + 1] = tmp;
		}
		
		for(int i = 1; i < DATA_COUNT; i++) {
			System.out.print(data[i] + " ");
		}
		
		System.out.println();
	}
}
