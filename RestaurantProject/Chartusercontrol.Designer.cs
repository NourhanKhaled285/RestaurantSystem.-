namespace RestaurantProject
{
    partial class Chartusercontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmb_Area = new System.Windows.Forms.ComboBox();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.boysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 763);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_Area);
            this.tabPage1.Controls.Add(this.PieChart);
            this.tabPage1.Controls.Add(this.BarChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 734);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmb_Area
            // 
            this.cmb_Area.Font = new System.Drawing.Font("Monotype Corsiva", 18.26866F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Area.FormattingEnabled = true;
            this.cmb_Area.Items.AddRange(new object[] {
            "Abbaseya",
            "El_Obour",
            "El-Shrouk",
            "El-Zayton",
            "El_Rehab",
            "Heliopolis",
            "Madinty",
            "Madint Nasr"});
            this.cmb_Area.Location = new System.Drawing.Point(408, 32);
            this.cmb_Area.Name = "cmb_Area";
            this.cmb_Area.Size = new System.Drawing.Size(262, 49);
            this.cmb_Area.TabIndex = 11;
            this.cmb_Area.Text = "Enter Your Area";
            this.cmb_Area.SelectedIndexChanged += new System.EventHandler(this.cmb_Area_SelectedIndexChanged_1);
            // 
            // PieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(657, 157);
            this.PieChart.Name = "PieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Delivery";
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(410, 545);
            this.PieChart.TabIndex = 10;
            this.PieChart.Text = "chart2";
            // 
            // BarChart
            // 
            chartArea2.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.BarChart.Legends.Add(legend2);
            this.BarChart.Location = new System.Drawing.Point(6, 157);
            this.BarChart.Name = "BarChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Delivery";
            this.BarChart.Series.Add(series2);
            this.BarChart.Size = new System.Drawing.Size(664, 545);
            this.BarChart.TabIndex = 9;
            this.BarChart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.boysChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 734);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // boysChart
            // 
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 7;
            chartArea3.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea3.AxisX.MaximumAutoSize = 100F;
            chartArea3.AxisX2.MaximumAutoSize = 100F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 94F;
            chartArea3.Position.Width = 100F;
            chartArea3.Position.Y = 3F;
            this.boysChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.boysChart.Legends.Add(legend3);
            this.boysChart.Location = new System.Drawing.Point(8, 11);
            this.boysChart.Name = "boysChart";
            this.boysChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "NumOfOrders";
            this.boysChart.Series.Add(series3);
            this.boysChart.Size = new System.Drawing.Size(1060, 720);
            this.boysChart.TabIndex = 0;
            this.boysChart.Text = "chart1";
            // 
            // Chartusercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Chartusercontrol";
            this.Size = new System.Drawing.Size(1076, 766);
            this.Load += new System.EventHandler(this.Chartusercontrol_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boysChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmb_Area;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart boysChart;

    }
}
