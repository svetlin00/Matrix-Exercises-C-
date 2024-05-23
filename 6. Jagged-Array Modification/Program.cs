namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedMatrix[row] = new int[data.Length];
                for (int col = 0; col < data.Length; col++)
                {
                    jaggedMatrix[row][col] = data[col];


                }
            }
            string[] comands = Console.ReadLine().Split().ToArray();
            while (comands[0] != "END")
            {
                if (comands[0] == "Add")
                {
                    int row = int.Parse(comands[1]);
                    int col = int.Parse(comands[2]);
                    int value = int.Parse(comands[3]);
                    if (row >= 0 && col >= 0 && row < rows && col < jaggedMatrix[row].Length)
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (comands[0] == "Subtract")
                {
                    int row = int.Parse(comands[1]);
                    int col = int.Parse(comands[2]);
                    int value = int.Parse(comands[3]);
                    if (row >= 0 && col >= 0 && row < rows && col < jaggedMatrix[row].Length)
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                comands = Console.ReadLine().Split().ToArray();

            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    Console.Write(jaggedMatrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}