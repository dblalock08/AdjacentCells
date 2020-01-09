using System;
using System.Linq;
using AdjacentCells.Library;
using AdjacentCells = AdjacentCells.Library.AdjacentCells;

namespace AdjacentCells.Util
{
    class Program
    {
        static void Main(string[] args)
        {
            // args[0]: int[] grid
            // args[1]: int ticks

            if (args.Length < 2)
            {
                Console.WriteLine("Insufficient arguments.");
            }

            // Parse first arg into an array
            int[] grid = new int[]{};
            try
            {
                string argStr = args[0];
                if (argStr[0] != '[' && argStr[argStr.Length - 1] != ']')
                {
                    throw new Exception();
                }

                argStr = argStr.Replace("[", "").Replace("]", "");

                var values = argStr.Split(',');
                grid = values.Select(int.Parse).ToArray();
            }
            catch
            {
                Console.WriteLine("Error parsing input parameter 'grid'.");
            }

            // Parse second arg into ticks
            int ticks = 0;
            try
            {
                if (!Int32.TryParse(args[1], out ticks))
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Error parsing input parameter 'ticks'.");
            }

            Library.AdjacentCells adjacentCells = new Library.AdjacentCells();

            int[] output = adjacentCells.GridAfterTicks(grid, ticks);

            Console.WriteLine("[{0}]", String.Join(",", output));

            Console.ReadKey();
        }
    }
}
