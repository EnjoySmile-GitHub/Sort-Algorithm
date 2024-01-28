import logic.BasicInsertionSort_1;
import logic.BasicInsertionSort_2;
import logic.BubbleSort;
import logic.DirectSelectionSort;
import logic.IndexSort;
import logic.LogicSort;
import logic.ShakerSort;
import logic.ShellSort_1;
import logic.ShellSort_2;

public class Main {

	public static void main(String[] args) {
		final int SORT_COUNT = 8;

		LogicSort[] logicSortInstance = new LogicSort[SORT_COUNT];
		// 直接選択法
		logicSortInstance[0] = new DirectSelectionSort();
		// バブルソート
		logicSortInstance[1] = new BubbleSort();
		// シェーカーソート
		logicSortInstance[2] = new ShakerSort();
		// インデックスソート
		logicSortInstance[3] = new IndexSort();
		// 基本挿入法1
		logicSortInstance[4] = new BasicInsertionSort_1();
		// 基本挿入法2
		logicSortInstance[5] = new BasicInsertionSort_2();
		// シェルソート1
		logicSortInstance[6] = new ShellSort_1();
		// シェルソート2
		logicSortInstance[7] = new ShellSort_2();

		for (int i = 0; i < SORT_COUNT; i++) {
			if (logicSortInstance[i] == null) {
				continue;
			}

			logicSortInstance[i].Sort();
		}
	}

}
