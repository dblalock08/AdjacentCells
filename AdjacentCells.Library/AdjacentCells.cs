using System;
using System.Collections.Generic;
using System.Text;

namespace AdjacentCells.Library
{
    class AdjacentCells : IAdjacentCells
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

        }
    }
}
