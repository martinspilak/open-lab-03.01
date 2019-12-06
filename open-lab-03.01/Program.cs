using System;

namespace open_lab_03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2D = new string[,] {{ "one", "two", "three"}, {"Apple", "orange", "banana"}, };
            Console.WriteLine(array2D[1, 2]);
        }
    }
}
