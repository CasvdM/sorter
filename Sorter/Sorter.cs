using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    public class Sorter
    {
        public Sorter() { }

        public async Task startSort(List<int> displayList)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                await Task.Run(() =>
                {
                    sortingMethod();
                    keepLooping = isListSorted(displayList);
                    System.Threading.Thread.Sleep(1);
                });
            }
        }

        public void sortingMethod() { }

        internal bool isListSorted(List<int> displayList)
        {
            int counter = 0;
            for (int i = 1; i < displayList.Count; i++)
            {
                int j = i - 1;
                if (displayList[i] < displayList[j])
                {
                    counter++;
                }
                else if (i == displayList.Count - 1 && counter == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
