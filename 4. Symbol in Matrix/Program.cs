namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfRow = int.Parse(Console.ReadLine());
            string[,] matrix =  new  string [numOfRow, numOfRow];
              
            for (int row = 0; row < numOfRow; row++)
            {

                string symbol = Console.ReadLine();
                for (int col = 0; col < numOfRow; col++)
                {
                    matrix[row, col] = symbol[col].ToString();
                    
                }
              
            }
            string wantedSymbol = Console.ReadLine();
            for (int row = 0; row < numOfRow; row++)
            {
                for (int col = 0; col < numOfRow; col++)
                {
                    string currSymbol = matrix[row, col];
                    if (currSymbol == wantedSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }

            }
            Console.WriteLine($"{wantedSymbol} does not occur in the matrix");
        }
    }
}