namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int [rows, cols];
            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < rows; row++)
                
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];

                }
            }

            
            for (int row = 0; row < rows; row++)

            {
       
                for (int col = 0; col < cols; col++)
                {

                    if (col < cols - 1 && row < rows - 1)
                    {
                        int currSum = matrix[row, col] + matrix[row , col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        if (currSum > maxSum)
                        {
                            maxSum = currSum;
                            maxCol = col;
                            maxRow = row;
                          
                        }
                    }
                  
                   

                }
            }
            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}