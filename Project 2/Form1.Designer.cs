namespace Project_2
{
    partial class aStockForm
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
            this.tickerbox = new System.Windows.Forms.TextBox();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.byGroup = new System.Windows.Forms.GroupBox();
            this.rWeek = new System.Windows.Forms.RadioButton();
            this.rDay = new System.Windows.Forms.RadioButton();
            this.rMonth = new System.Windows.Forms.RadioButton();
            this.goButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.byGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tickerbox
            // 
            this.tickerbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tickerbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickerbox.Location = new System.Drawing.Point(12, 32);
            this.tickerbox.Name = "tickerbox";
            this.tickerbox.Size = new System.Drawing.Size(141, 29);
            this.tickerbox.TabIndex = 0;
            // 
            // fromdate
            // 
            this.fromdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromdate.Location = new System.Drawing.Point(187, 32);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(116, 20);
            this.fromdate.TabIndex = 1;
            // 
            // todate
            // 
            this.todate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.todate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todate.Location = new System.Drawing.Point(187, 81);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(116, 20);
            this.todate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ticker name";
            // 
            // byGroup
            // 
            this.byGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.byGroup.Controls.Add(this.rWeek);
            this.byGroup.Controls.Add(this.rDay);
            this.byGroup.Controls.Add(this.rMonth);
            this.byGroup.Location = new System.Drawing.Point(337, 16);
            this.byGroup.Name = "byGroup";
            this.byGroup.Size = new System.Drawing.Size(71, 85);
            this.byGroup.TabIndex = 6;
            this.byGroup.TabStop = false;
            this.byGroup.Text = "By:";
            // 
            // rWeek
            // 
            this.rWeek.AutoSize = true;
            this.rWeek.Location = new System.Drawing.Point(6, 61);
            this.rWeek.Name = "rWeek";
            this.rWeek.Size = new System.Drawing.Size(54, 17);
            this.rWeek.TabIndex = 8;
            this.rWeek.TabStop = true;
            this.rWeek.Text = "Week";
            this.rWeek.UseVisualStyleBackColor = true;
            // 
            // rDay
            // 
            this.rDay.AutoSize = true;
            this.rDay.Location = new System.Drawing.Point(6, 19);
            this.rDay.Name = "rDay";
            this.rDay.Size = new System.Drawing.Size(44, 17);
            this.rDay.TabIndex = 0;
            this.rDay.TabStop = true;
            this.rDay.Text = "Day";
            this.rDay.UseVisualStyleBackColor = true;
            // 
            // rMonth
            // 
            this.rMonth.AutoSize = true;
            this.rMonth.Location = new System.Drawing.Point(6, 41);
            this.rMonth.Name = "rMonth";
            this.rMonth.Size = new System.Drawing.Size(55, 17);
            this.rMonth.TabIndex = 7;
            this.rMonth.TabStop = true;
            this.rMonth.Text = "Month";
            this.rMonth.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goButton.Location = new System.Drawing.Point(28, 79);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(109, 22);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "GO!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.clickGo);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 125);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(388, 250);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // aStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 382);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.byGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todate);
            this.Controls.Add(this.fromdate);
            this.Controls.Add(this.tickerbox);
            this.Name = "aStockForm";
            this.Text = "Stock History";
            this.byGroup.ResumeLayout(false);
            this.byGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tickerbox;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox byGroup;
        private System.Windows.Forms.RadioButton rWeek;
        private System.Windows.Forms.RadioButton rDay;
        private System.Windows.Forms.RadioButton rMonth;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

