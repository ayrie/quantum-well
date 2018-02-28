namespace Studnia
{
    partial class MyForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartEnergy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxBarrier = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelBarrier = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.labelFunIndex = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEnergy
            // 
            this.chartEnergy.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.chartEnergy.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.SystemColors.Control;
            legend3.Name = "Legend1";
            this.chartEnergy.Legends.Add(legend3);
            this.chartEnergy.Location = new System.Drawing.Point(33, 28);
            this.chartEnergy.Name = "chartEnergy";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Legend = "Legend1";
            series5.Name = "Energia";
            this.chartEnergy.Series.Add(series5);
            this.chartEnergy.Size = new System.Drawing.Size(455, 294);
            this.chartEnergy.TabIndex = 0;
            this.chartEnergy.Text = "chart1";
            // 
            // chartFunctions
            // 
            this.chartFunctions.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.chartFunctions.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.SystemColors.Control;
            legend4.Name = "Legend1";
            legend4.TitleBackColor = System.Drawing.SystemColors.Control;
            this.chartFunctions.Legends.Add(legend4);
            this.chartFunctions.Location = new System.Drawing.Point(504, 28);
            this.chartFunctions.Name = "chartFunctions";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Potencjał";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series7.Legend = "Legend1";
            series7.Name = "Energia";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series8.Legend = "Legend1";
            series8.Name = "Funkcja";
            this.chartFunctions.Series.Add(series6);
            this.chartFunctions.Series.Add(series7);
            this.chartFunctions.Series.Add(series8);
            this.chartFunctions.Size = new System.Drawing.Size(644, 573);
            this.chartFunctions.TabIndex = 1;
            this.chartFunctions.Text = "chart1";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(185, 365);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(74, 20);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.Text = "30";
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBarrier
            // 
            this.textBoxBarrier.Location = new System.Drawing.Point(185, 409);
            this.textBoxBarrier.Name = "textBoxBarrier";
            this.textBoxBarrier.Size = new System.Drawing.Size(74, 20);
            this.textBoxBarrier.TabIndex = 3;
            this.textBoxBarrier.Text = "0.2";
            this.textBoxBarrier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(39, 368);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(120, 13);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Szerokość studni d (nm)";
            // 
            // labelBarrier
            // 
            this.labelBarrier.AutoSize = true;
            this.labelBarrier.Location = new System.Drawing.Point(39, 413);
            this.labelBarrier.Name = "labelBarrier";
            this.labelBarrier.Size = new System.Drawing.Size(123, 13);
            this.labelBarrier.TabIndex = 6;
            this.labelBarrier.Text = "Wysokość bariery V (eV)";
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(332, 365);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(52, 13);
            this.labelStep.TabIndex = 9;
            this.labelStep.Text = "Krok (nm)";
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(426, 361);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(55, 20);
            this.textBoxStep.TabIndex = 8;
            this.textBoxStep.Text = "0.5";
            this.textBoxStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(332, 413);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(63, 13);
            this.labelRange.TabIndex = 11;
            this.labelRange.Text = "Zakres (nm)";
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(426, 409);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(55, 20);
            this.textBoxRange.TabIndex = 10;
            this.textBoxRange.Text = "100";
            this.textBoxRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelFunIndex
            // 
            this.labelFunIndex.AutoSize = true;
            this.labelFunIndex.Location = new System.Drawing.Point(1016, 331);
            this.labelFunIndex.Name = "labelFunIndex";
            this.labelFunIndex.Size = new System.Drawing.Size(99, 13);
            this.labelFunIndex.TabIndex = 13;
            this.labelFunIndex.Text = "Pokaż n-tą funkcję:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(203, 486);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(202, 35);
            this.buttonCalculate.TabIndex = 14;
            this.buttonCalculate.Text = "Przelicz";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(1205, 44);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(289, 459);
            this.textBoxDisplay.TabIndex = 15;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(1064, 358);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(46, 20);
            this.textBoxIndex.TabIndex = 16;
            this.textBoxIndex.Text = "0";
            this.textBoxIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 631);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelFunIndex);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.labelBarrier);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxBarrier);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.chartFunctions);
            this.Controls.Add(this.chartEnergy);
            this.Name = "MyForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEnergy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxBarrier;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelBarrier;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.Label labelFunIndex;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.TextBox textBoxIndex;
    }
}

