namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = array[0];
            int cols = array[1];
            int[,] matrinx = new int[rows, cols];
            int sumOfRow = 0;
           
           
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrinx[row, col] = data[col];
                }
                
            }

            for (int col2 = 0; col2 < cols; col2++)
            {
                for (int row2 = 0; row2 < rows; row2++)
                {
                    sumOfRow += matrinx[row2, col2];

                }
                Console.WriteLine(sumOfRow);
                sumOfRow = 0;
            }
          
        }
    }
}