using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorter
{
    public partial class MainForm : Form
    {
        List<int> displayList = new List<int>();
        private Timer timer1;
        public MainForm()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = (1000/60);
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;

            chrtMain.Series.Clear();
            chrtMain.ChartAreas[0].AxisX.Title = "Count";
        }
        public async void timer1_Tick(object sender, EventArgs e)
        {
            chrtMain.BeginInvoke(new Action(() =>
            {
                chrtMain.Series.Clear();
                Series series = chrtMain.Series.Add("Values");
                chrtMain.ChartAreas[0].AxisX.Minimum = 0;
                chrtMain.ChartAreas[0].AxisX.Maximum = displayList.Count;

                for (int i = 0; i < displayList.Count; i++)
                {
                    series.Points.AddXY(i + 1, displayList[i]);
                }
            }));
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerationFormRandom generationForm = new GenerationFormRandom();
            generationForm.ShowDialog();
        
            displayList = generationForm.getRnList();
            //generationForm.Dispose();
        }
        private void btnGenSeq_Click(object sender, EventArgs e)
        {
            GenerationFormSequential generationForm = new GenerationFormSequential();
            generationForm.ShowDialog();
            displayList = generationForm.getList();
        }

        private void btnConsoleTest_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New test: ");
            foreach(var entry in displayList)
            {
                Console.WriteLine(entry);
            }   
        }
        private async void btnSort_Click(object sender, EventArgs e)
        {
            DateTime startingTime = DateTime.Now;
            //Call sortfunction in sort type selected
            //var sorterSelected = new IterativeSort();
            var sorterSelected = new ShellSort();
            //var sorterSelected = new BogoSort();
            await sorterSelected.startSort(displayList);
            
            DateTime endTime = DateTime.Now;
            TimeSpan duration = endTime - startingTime;
            MessageBox.Show("Sorted!\n It took " + duration + " to sort this list of " + displayList.Count + " values.");
        }
    }
}
