
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SizeField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.WeigthField = new System.Windows.Forms.NumericUpDown();
            this.AngleField = new System.Windows.Forms.NumericUpDown();
            this.SpeedField = new System.Windows.Forms.NumericUpDown();
            this.StepField = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeigthField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SizeField);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WeigthField);
            this.panel1.Controls.Add(this.AngleField);
            this.panel1.Controls.Add(this.SpeedField);
            this.panel1.Controls.Add(this.StepField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Angle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 113);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SizeField
            // 
            this.SizeField.DecimalPlaces = 2;
            this.SizeField.Location = new System.Drawing.Point(265, 7);
            this.SizeField.Name = "SizeField";
            this.SizeField.Size = new System.Drawing.Size(120, 20);
            this.SizeField.TabIndex = 9;
            this.SizeField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weigth";
            // 
            // WeigthField
            // 
            this.WeigthField.DecimalPlaces = 2;
            this.WeigthField.Location = new System.Drawing.Point(265, 41);
            this.WeigthField.Name = "WeigthField";
            this.WeigthField.Size = new System.Drawing.Size(120, 20);
            this.WeigthField.TabIndex = 8;
            this.WeigthField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AngleField
            // 
            this.AngleField.Location = new System.Drawing.Point(57, 66);
            this.AngleField.Name = "AngleField";
            this.AngleField.Size = new System.Drawing.Size(120, 20);
            this.AngleField.TabIndex = 7;
            this.AngleField.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // SpeedField
            // 
            this.SpeedField.DecimalPlaces = 3;
            this.SpeedField.Location = new System.Drawing.Point(57, 36);
            this.SpeedField.Name = "SpeedField";
            this.SpeedField.Size = new System.Drawing.Size(120, 20);
            this.SpeedField.TabIndex = 6;
            this.SpeedField.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // StepField
            // 
            this.StepField.DecimalPlaces = 6;
            this.StepField.Location = new System.Drawing.Point(57, 7);
            this.StepField.Name = "StepField";
            this.StepField.Size = new System.Drawing.Size(120, 20);
            this.StepField.TabIndex = 5;
            this.StepField.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step";
            // 
            // Angle
            // 
            this.Angle.AutoSize = true;
            this.Angle.Location = new System.Drawing.Point(12, 68);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(34, 13);
            this.Angle.TabIndex = 0;
            this.Angle.Text = "Angle";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            this.chart1.Location = new System.Drawing.Point(0, 113);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(800, 544);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Step,
            this.Distance,
            this.MaxHeight,
            this.EndSpeed});
            this.dataGridView1.Location = new System.Drawing.Point(806, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 526);
            this.dataGridView1.TabIndex = 3;
            // 
            // Step
            // 
            this.Step.HeaderText = "Step";
            this.Step.Name = "Step";
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            // 
            // MaxHeight
            // 
            this.MaxHeight.HeaderText = "Max height";
            this.MaxHeight.Name = "MaxHeight";
            // 
            // EndSpeed
            // 
            this.EndSpeed.HeaderText = "EndSpeed";
            this.EndSpeed.Name = "EndSpeed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 657);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeigthField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown SizeField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown WeigthField;
        private System.Windows.Forms.NumericUpDown AngleField;
        private System.Windows.Forms.NumericUpDown SpeedField;
        private System.Windows.Forms.NumericUpDown StepField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Angle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndSpeed;
    }
}

