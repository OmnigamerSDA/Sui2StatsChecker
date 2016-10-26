namespace Sui2StatsChecker
{
    partial class StatCheckerForm
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
            this.statBox = new System.Windows.Forms.ComboBox();
            this.pdfChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.statGrid = new System.Windows.Forms.DataGridView();
            this.statColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charBox = new System.Windows.Forms.ComboBox();
            this.charGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pdfChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statBox
            // 
            this.statBox.FormattingEnabled = true;
            this.statBox.Location = new System.Drawing.Point(21, 194);
            this.statBox.Name = "statBox";
            this.statBox.Size = new System.Drawing.Size(121, 21);
            this.statBox.TabIndex = 0;
            this.statBox.SelectedIndexChanged += new System.EventHandler(this.statBox_SelectedIndexChanged);
            // 
            // pdfChart
            // 
            chartArea1.AxisX.Interval = 2D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 2D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.Name = "ChartArea1";
            this.pdfChart.ChartAreas.Add(chartArea1);
            this.pdfChart.Location = new System.Drawing.Point(12, 221);
            this.pdfChart.Name = "pdfChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.pdfChart.Series.Add(series1);
            this.pdfChart.Size = new System.Drawing.Size(788, 328);
            this.pdfChart.TabIndex = 1;
            this.pdfChart.Text = "chart1";
            // 
            // levelBox
            // 
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Location = new System.Drawing.Point(21, 154);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(121, 21);
            this.levelBox.TabIndex = 2;
            this.levelBox.SelectedIndexChanged += new System.EventHandler(this.levelBox_SelectedIndexChanged);
            // 
            // statGrid
            // 
            this.statGrid.AllowUserToAddRows = false;
            this.statGrid.AllowUserToDeleteRows = false;
            this.statGrid.AllowUserToOrderColumns = true;
            this.statGrid.AllowUserToResizeRows = false;
            this.statGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statColumn,
            this.probColumn,
            this.cdfColumn});
            this.statGrid.Location = new System.Drawing.Point(529, 12);
            this.statGrid.Name = "statGrid";
            this.statGrid.ReadOnly = true;
            this.statGrid.RowHeadersVisible = false;
            this.statGrid.Size = new System.Drawing.Size(271, 203);
            this.statGrid.TabIndex = 3;
            // 
            // statColumn
            // 
            this.statColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.statColumn.HeaderText = "Stat Value";
            this.statColumn.Name = "statColumn";
            this.statColumn.ReadOnly = true;
            this.statColumn.Width = 81;
            // 
            // probColumn
            // 
            this.probColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.probColumn.HeaderText = "Probability";
            this.probColumn.Name = "probColumn";
            this.probColumn.ReadOnly = true;
            this.probColumn.Width = 80;
            // 
            // cdfColumn
            // 
            this.cdfColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cdfColumn.HeaderText = "Cumulative";
            this.cdfColumn.Name = "cdfColumn";
            this.cdfColumn.ReadOnly = true;
            this.cdfColumn.Width = 84;
            // 
            // charBox
            // 
            this.charBox.FormattingEnabled = true;
            this.charBox.Location = new System.Drawing.Point(21, 114);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(121, 21);
            this.charBox.TabIndex = 6;
            this.charBox.SelectedIndexChanged += new System.EventHandler(this.charBox_SelectedIndexChanged);
            // 
            // charGrid
            // 
            this.charGrid.AllowUserToAddRows = false;
            this.charGrid.AllowUserToDeleteRows = false;
            this.charGrid.AllowUserToOrderColumns = true;
            this.charGrid.AllowUserToResizeRows = false;
            this.charGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.charGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.minColumn,
            this.maxColumn});
            this.charGrid.Location = new System.Drawing.Point(157, 12);
            this.charGrid.Name = "charGrid";
            this.charGrid.ReadOnly = true;
            this.charGrid.RowHeadersVisible = false;
            this.charGrid.Size = new System.Drawing.Size(366, 203);
            this.charGrid.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Stat Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Rank";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 58;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Average";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 72;
            // 
            // minColumn
            // 
            this.minColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.minColumn.HeaderText = "Minimum";
            this.minColumn.Name = "minColumn";
            this.minColumn.ReadOnly = true;
            this.minColumn.Width = 73;
            // 
            // maxColumn
            // 
            this.maxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maxColumn.HeaderText = "Maximum";
            this.maxColumn.Name = "maxColumn";
            this.maxColumn.ReadOnly = true;
            this.maxColumn.Width = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Character:";
            // 
            // picBox
            // 
            this.picBox.Image = global::Sui2StatsChecker.Properties.Resources.riou02;
            this.picBox.Location = new System.Drawing.Point(21, 13);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(121, 82);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 11;
            this.picBox.TabStop = false;
            // 
            // StatCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(810, 561);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charGrid);
            this.Controls.Add(this.charBox);
            this.Controls.Add(this.statGrid);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.pdfChart);
            this.Controls.Add(this.statBox);
            this.Name = "StatCheckerForm";
            this.Text = "Sui2 Stat Checker";
            ((System.ComponentModel.ISupportInitialize)(this.pdfChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart pdfChart;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.DataGridView statGrid;
        private System.Windows.Forms.ComboBox charBox;
        private System.Windows.Forms.DataGridView charGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn minColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn statColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn probColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdfColumn;
        private System.Windows.Forms.PictureBox picBox;
    }
}

