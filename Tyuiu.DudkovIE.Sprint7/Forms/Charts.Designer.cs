
namespace Tyuiu.DudkovIE.Sprint7.Forms
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            this.chart_PriceProduct_DIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_ShowCharts_DIE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_PriceProduct_DIE)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_PriceProduct_DIE
            // 
            this.chart_PriceProduct_DIE.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart_PriceProduct_DIE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_PriceProduct_DIE.Legends.Add(legend1);
            this.chart_PriceProduct_DIE.Location = new System.Drawing.Point(1, 45);
            this.chart_PriceProduct_DIE.Name = "chart_PriceProduct_DIE";
            series1.ChartArea = "ChartArea1";
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            this.chart_PriceProduct_DIE.Series.Add(series1);
            this.chart_PriceProduct_DIE.Size = new System.Drawing.Size(384, 315);
            this.chart_PriceProduct_DIE.TabIndex = 1;
            this.chart_PriceProduct_DIE.Text = "chart2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(121, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 62;
            this.textBox1.Text = "ЦЕНА ТОВАРА";
            // 
            // button_ShowCharts_DIE
            // 
            this.button_ShowCharts_DIE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ShowCharts_DIE.BackgroundImage")));
            this.button_ShowCharts_DIE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ShowCharts_DIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowCharts_DIE.ForeColor = System.Drawing.Color.White;
            this.button_ShowCharts_DIE.Location = new System.Drawing.Point(318, 366);
            this.button_ShowCharts_DIE.Name = "button_ShowCharts_DIE";
            this.button_ShowCharts_DIE.Size = new System.Drawing.Size(103, 48);
            this.button_ShowCharts_DIE.TabIndex = 63;
            this.button_ShowCharts_DIE.Text = "ПОКАЗАТЬ ГРАФИКИ";
            this.button_ShowCharts_DIE.UseVisualStyleBackColor = true;
            this.button_ShowCharts_DIE.Click += new System.EventHandler(this.button_ShowCharts_DIE_Click);
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ShowCharts_DIE);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart_PriceProduct_DIE);
            this.Name = "Charts";
            this.Text = "Charts";
            ((System.ComponentModel.ISupportInitialize)(this.chart_PriceProduct_DIE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PriceProduct_DIE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_ShowCharts_DIE;
    }
}