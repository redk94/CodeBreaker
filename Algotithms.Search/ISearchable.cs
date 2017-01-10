using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public interface ISearchable
    {     
        int Search(int[] list, int target);

        int Location { get; }

        bool Found { get;  }
    }
}