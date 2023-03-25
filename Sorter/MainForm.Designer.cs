namespace Sorter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenRan = new System.Windows.Forms.Button();
            this.btnConsoleTest = new System.Windows.Forms.Button();
            this.btnGenSeq = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtMain)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtMain
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chrtMain.ChartAreas.Add(chartArea1);
            this.chrtMain.Location = new System.Drawing.Point(12, 12);
            this.chrtMain.Name = "chrtMain";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            this.chrtMain.Series.Add(series1);
            this.chrtMain.Size = new System.Drawing.Size(1602, 1017);
            this.chrtMain.TabIndex = 0;
            this.chrtMain.Text = "chart1";
            // 
            // btnGenRan
            // 
            this.btnGenRan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGenRan.Location = new System.Drawing.Point(1702, 12);
            this.btnGenRan.Name = "btnGenRan";
            this.btnGenRan.Size = new System.Drawing.Size(151, 63);
            this.btnGenRan.TabIndex = 1;
            this.btnGenRan.Text = "Generate Random";
            this.btnGenRan.UseVisualStyleBackColor = true;
            this.btnGenRan.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnConsoleTest
            // 
            this.btnConsoleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnConsoleTest.Location = new System.Drawing.Point(1702, 208);
            this.btnConsoleTest.Name = "btnConsoleTest";
            this.btnConsoleTest.Size = new System.Drawing.Size(151, 63);
            this.btnConsoleTest.TabIndex = 2;
            this.btnConsoleTest.Text = "Test";
            this.btnConsoleTest.UseVisualStyleBackColor = true;
            this.btnConsoleTest.Click += new System.EventHandler(this.btnConsoleTest_Click);
            // 
            // btnGenSeq
            // 
            this.btnGenSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnGenSeq.Location = new System.Drawing.Point(1702, 81);
            this.btnGenSeq.Name = "btnGenSeq";
            this.btnGenSeq.Size = new System.Drawing.Size(151, 63);
            this.btnGenSeq.TabIndex = 3;
            this.btnGenSeq.Text = "Generate Sequential";
            this.btnGenSeq.UseVisualStyleBackColor = true;
            this.btnGenSeq.Click += new System.EventHandler(this.btnGenSeq_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSort.Location = new System.Drawing.Point(1702, 890);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(151, 63);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnGenSeq);
            this.Controls.Add(this.btnConsoleTest);
            this.Controls.Add(this.btnGenRan);
            this.Controls.Add(this.chrtMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chrtMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtMain;
        private System.Windows.Forms.Button btnGenRan;
        private System.Windows.Forms.Button btnConsoleTest;
        private System.Windows.Forms.Button btnGenSeq;
        private System.Windows.Forms.Button btnSort;
    }
}

