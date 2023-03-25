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

        public async Task startSort(List<int> displayList)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                await Task.Run(() =>
                {

                   
                    keepLooping = base.isListSorted(displayList);
                    System.Threading.Thread.Sleep(1);
                });
            }
        }
    }
}
