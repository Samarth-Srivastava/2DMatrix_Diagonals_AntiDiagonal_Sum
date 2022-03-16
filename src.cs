namespace Matrix_MainDiagonalSum{
	public class Solution{
		public int solve(List<List<int>> A){
			int rows = A.Count();
			int cols = A[0].Count();

			//sum of main diagonal
			int sum = 0;
			int N = min(rows, cols);
			for(int i = 0; i < N; i++){
				sum = sum + A[i][i];
			}

			//sum of main anti diagonal
			int antiSum = 0;
			int rowCount = 0;
			int colCount = cols -1;

			while(rowCount < N && colCount >= 0 ){
				antiSum = antiSum + A[rowCount][colCount];
				rowCount++;
				colCount--;
			}
			return antiSum;
		}

		public int min(int a, int b){
			if(a < b){
				return a;
			}
			return b;
		}
	}
}
