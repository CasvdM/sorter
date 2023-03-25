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
    public partial class GenerationFormRandom : Form
    {
        randomNumberList rnList = new randomNumberList();
        public List<int> getRnList()
        {
            var list = rnList.requestList();
            return list;
        }
        public GenerationFormRandom()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            rnList.fillListWithRandomNumbers(Convert.ToInt32(txtMin.Text), Convert.ToInt32(txtMax.Text), Convert.ToInt32(txtAmt.Text));
            this.Close();
        }
    }
}
