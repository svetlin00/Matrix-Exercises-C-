namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrinx = new int[input, input];
            int sumOfDiagonal = 0;
            for (int row = 0; row < input; row++)

            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
               
                for (int col = 0; col < input; col++)
                {
                    matrinx[row, col] = data[col];
                    

                }
                sumOfDiagonal += matrinx[row, row];
            }
            Console.WriteLine(sumOfDiagonal);
           
        }
    }
}