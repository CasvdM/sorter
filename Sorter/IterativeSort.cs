using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    internal class IterativeSort
    {
        public IterativeSort() { }

        public async Task startSort(List<int> displayList)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                await Task.Run(() =>
                {               
                    int counter = 0;
                    for (int i = 1; i < displayList.Count; i++)
                    {
                        int j = i - 1;
                        if (displayList[i] < displayList[j])
                        {
                            int tempi = displayList[i];
                            int tempj = displayList[j];
                            displayList[i] = tempj;
                            displayList[j] = tempi;
                            counter++;
                        }
                        else if (i == displayList.Count - 1 && counter == 0)
                        {
                            keepLooping = false;
                            break;
                        }

                    }
                    System.Threading.Thread.Sleep(1);
                });
            }
        }
    }               
}



        

      