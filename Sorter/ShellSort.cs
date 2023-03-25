using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorter
{
    internal class ShellSort : Sorter
    {
        public async Task startSort(List<int> displayList)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                await Task.Run(() =>
                {
                    int[] gaps = {701, 301, 132, 57, 23, 10, 4, 1};

                    for(int k = 0; k < gaps.Length; k++)
                    {
                        var gap = gaps[k];
                        for(var start = 0; start < displayList.Count && start < gap; start++)
                        {
                            insertSortGap(displayList, start, gap);
                        }
                    }
                    keepLooping = base.isListSorted(displayList);
                    System.Threading.Thread.Sleep(1);
                });


            }
        }


        public void insertSortGap(List<int> displayList,int start, int gap)
        {
            try
            {
                for (int i = start + gap; i < displayList.Count; i+= gap)
                {
                    for (int k = i; k >= 0; k--)
                    {
                        if (displayList[i] < displayList[k])
                        {
                            int tempi = displayList[i];
                            int tempk = displayList[k];
                            displayList[i] = tempk;
                            displayList[k] = tempi;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }          
        }
    }
}
