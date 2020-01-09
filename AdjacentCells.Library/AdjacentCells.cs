namespace AdjacentCells.Library
{
    public class AdjacentCells : IAdjacentCells
    {
        // For a 1-dimensional array, cells can be either inactive (0) or active (1).
        // Each tick, a cell value will be set based on the following rules.
        //  - If the cells immediately adjacent are both active or inactive, then the cell is active.
        //  - Otherwise, the cell is inactive.
        //  - Because the first and last cells have only a single neighbor, consider the value of the "edge" to always be 0;
        //      - Ex. Given grid [1,1,0,0], the cell at index 0 has a 0 to the left, and a 1 to the right.
        //            The cell at index 3 has a 0 to the left, and a 0 to the right.
        public int[] GridAfterTicks(int[] grid, int ticks)
        {
            int[] tickResult = new int[grid.Length];

            for (int i = 0; i < ticks; i++)
            {
                for (int pos = 0; pos < grid.Length; pos++)
                {
                    int leftVal;
                    int rightVal;

                    if (pos == 0)
                    {
                        leftVal = 0;
                        rightVal = grid[pos + 1];
                    }
                    else if (pos == grid.Length - 1)
                    {
                        leftVal = grid[pos - 1];
                        rightVal = 0;
                    }
                    else
                    {
                        leftVal = grid[pos - 1];
                        rightVal = grid[pos + 1];
                    }

                    if (leftVal == rightVal)
                    {
                        tickResult[pos] = 1;
                    }
                    else
                    {
                        tickResult[pos] = 0;
                    }
                }

                tickResult.CopyTo(grid, 0);
            }

            return grid;
        }
    }
}
