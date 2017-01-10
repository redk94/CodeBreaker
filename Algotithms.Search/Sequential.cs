using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    /// <summary>
    /// Linear search
    /// </summary>
    class Sequential : ISearchable
    {
        public int Location { get; private set; }

        public bool Found { get; private set; }

        public Sequential()
        {
            Location = -1;
            Found = false;
        }
        
        public int Search(int[] list, int target)
        {
            int idx = -1;

            for(int i = 0; i <= list.Length -1; i++)
            {
                if (list[i] == target)
                {
                    idx = i;
                    break;
                }
            }

            return idx;
        }
    }
}
