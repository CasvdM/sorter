using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    public class BogoSort : Sorter
    {
        public BogoSort() { }

        public override void sortingMethod(List<int> displayList)
        {
            Random rng = new Random();
            int n = displayList.Count;

            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = displayList[k];
                displayList[k] = displayList[n];
                displayList[n] = value;
            }
        }
    }
}
