//driver code
using System;
using System.IO;

namespace Matrix_MainDiagonalSum{
	public class Program{
		public static void Main(string[] args){
			Solution s = new Solution();

			string[] input = args[0].Split(' ');

            List<List<int>> mat = new List<List<int>>();
            int rows = Convert.ToInt32(input[0]);
            int cols = Convert.ToInt32(input[1]);
            
            int count = 2;
            for(int i = 0; i < rows; i++){
                List<int> inner = new List<int>();
                for(int j = 0; j < cols; j++){
                    inner.Add(Convert.ToInt32(input[count]));
                    count++;
                }
                mat.Add(inner);
            }
			Console.WriteLine(s.solve(mat));
		}
	}
}
