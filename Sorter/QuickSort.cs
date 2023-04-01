using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    internal class QuickSort : Sorter
    {
        public QuickSort() { }

        public override void sortingMethod(List<int> displayList)
        {
            displayList = quickSort(displayList);
            
        }

        public List<int> quickSort(List<int> arr)
        {
            if(arr.Count <= 1)
            {
                return arr;
            }

            int pivotIndex = new Random().Next(arr.Count);
            int pivot = arr[pivotIndex];

            List<int> leftArray = new List<int>();
            List<int> rightArray = new List<int>();
            for(int i = 0; i < arr.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (arr[i] < pivot)
                {
                    leftArray.Add(arr[i]);
                }
                else
                {
                    rightArray.Add(arr[i]);
                }
            }

            leftArray = quickSort(leftArray);
            rightArray = quickSort(rightArray);

            List<int> sortedArray = new List<int>();
            sortedArray.AddRange(leftArray);
            sortedArray.Add(pivot);
            sortedArray.AddRange(rightArray);

            arr.Clear();
            arr.AddRange(sortedArray);
            
            return arr;
        }
    }
}

//        List<int> leftArray = new List<int>();
//        List<int> rightArray = new List<int>();
//        int pivotValue;
        

//        public override void sortingMethod(List<int> displayList)
//        {

//            Random random = new Random();
//            int pivotIndex = random.Next(0, displayList.Count - 1);
//            pivotValue = displayList[pivotIndex];

//            for (int i = 0; i < displayList.Count; i++)
//            {
//                if (i != pivotIndex)
//                {
//                    if (displayList[i] < pivotValue)
//                    {
//                        leftArray.Add(displayList[i]);
//                    }
//                    else if (displayList[i] > pivotValue)
//                    {
//                        rightArray.Add(displayList[i]);
//                    }
//                }
//            }
//            sortingMethod(leftArray);
//            sortingMethod(rightArray);
//            concatenateLists(displayList, pivotIndex);
//        }

//        public void SortSubArray(List<int> subArray)
//        {
//            bool keeplooping = true;
            
//            while(keeplooping)
//            {
//                Random random = new Random();
//                int pivotIndex = random.Next(0, subArray.Count - 1);
//                pivotValue = subArray[pivotIndex];

//                for (int i = 0; i < subArray.Count; i++)
//                {
//                    if (i != pivotIndex)
//                    {
//                        if (subArray[i] < pivotValue)
//                        {
//                            leftArray.Add(subArray[i]);
//                        }
//                        else if (subArray[i] > pivotValue)
//                        {
//                            rightArray.Add(subArray[i]);
//                        }
//                    }
//                }
//                concatenateLists
//            }

//        }

//        public void concatenateLists(List<int> displayList, int pivotIndex)
//        {
//            List<int> sortedArray = new List<int>();
//            sortedArray.AddRange(leftArray);
//            sortedArray.Add(displayList[pivotIndex]);
//            sortedArray.AddRange(rightArray);
//            displayList.Clear();
//            displayList.AddRange(sortedArray);
//            leftArray.Clear();
            
//            rightArray.Clear();
//        }
//    }
//}
