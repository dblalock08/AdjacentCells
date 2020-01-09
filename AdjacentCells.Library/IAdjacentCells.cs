using System;
using System.Collections.Generic;
using System.Text;

namespace AdjacentCells.Library
{
    interface IAdjacentCells
    {
        int[] GridAfterTicks(int[] grid, int ticks);
    }
}
