using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{

    public class randomNumberList : List<int>
    {
        private List<int> list { get; set; }    
        public randomNumberList()
        {
            list = new List<int>();
        }
        public void fillListWithRandomNumbers(int rangeStart, int rangeEnd, int amount)
        {
            var random = new Random();
            for (int i = 0; i < amount; i++)
            {
                list.Add(random.Next(rangeStart, rangeEnd));
            }
        }

        public List<int> requestList()
        {
            return list;
        }
        //public List<int> requestList(List<int> list)
        //{
        //    return list;
        //}
    }
}
