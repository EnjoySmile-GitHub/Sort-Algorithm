import logic.BubbleSort;
import logic.DirectSelectionSort;
import logic.LogicSort;
import logic.ShakerSort;

public class Main {

	public static void main(String[] args) {
		final int SORT_COUNT = 3;

		LogicSort[] logicSortInstance = new LogicSort[SORT_COUNT];
		// 直接選択法
		logicSortInstance[0] = new DirectSelectionSort();
		// バブルソート
		logicSortInstance[1] = new BubbleSort();
		// シェーカーソート
		logicSortInstance[2] = new ShakerSort();

		for (int i = 0; i < SORT_COUNT; i++) {
			if (logicSortInstance[i] == null) {
				continue;
			}

			logicSortInstance[i].Sort();
		}
	}

}
