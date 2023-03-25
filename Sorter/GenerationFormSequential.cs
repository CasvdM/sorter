using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    public partial class GenerationFormSequential : Form
    {
        List<int> seqList = new List<int>();
        public List<int> getList()
        {
            return seqList;
        }
        public GenerationFormSequential()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            generateList(Convert.ToInt32(txtAmt.Text));
            shuffleList();
            this.Close();
        }

        public void generateList(int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                seqList.Add(i);
            }
        }
        public void shuffleList()
        {
            Random random = new Random();
            int n = seqList.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = seqList[k];
                seqList[k] = seqList[n];
                seqList[n] = value;
            }
        }

    }
}
