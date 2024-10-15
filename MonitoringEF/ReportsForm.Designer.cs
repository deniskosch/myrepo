namespace MonitoringEF
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelFertilizerCostAvg;
        private System.Windows.Forms.Label labelFuelCostAvg;
        private System.Windows.Forms.Label labelTotalCostAvg;
        private System.Windows.Forms.Label labelFuelSum;
        private System.Windows.Forms.Label labelFertilizerSum;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label resultFertilizerCostAvg;
        private System.Windows.Forms.Label resultFuelCostAvg;
        private System.Windows.Forms.Label resultTotalCostAvg;
        private System.Windows.Forms.Label resultFuelSum;
        private System.Windows.Forms.Label resultFertilizerSum;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelFertilizerCostAvg = new Label();
            labelFuelCostAvg = new Label();
            labelTotalCostAvg = new Label();
            labelFuelSum = new Label();
            labelFertilizerSum = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonGenerateReport = new Button();
            resultFertilizerCostAvg = new Label();
            resultFuelCostAvg = new Label();
            resultTotalCostAvg = new Label();
            resultFuelSum = new Label();
            resultFertilizerSum = new Label();
            SuspendLayout();
            // 
            // labelFertilizerCostAvg
            // 
            labelFertilizerCostAvg.AutoSize = true;
            labelFertilizerCostAvg.Location = new Point(18, 22);
            labelFertilizerCostAvg.Name = "labelFertilizerCostAvg";
            labelFertilizerCostAvg.Size = new Size(181, 15);
            labelFertilizerCostAvg.TabIndex = 3;
            labelFertilizerCostAvg.Text = "Средние затраты на удобрения:";
            // 
            // labelFuelCostAvg
            // 
            labelFuelCostAvg.AutoSize = true;
            labelFuelCostAvg.Location = new Point(18, 52);
            labelFuelCostAvg.Name = "labelFuelCostAvg";
            labelFuelCostAvg.Size = new Size(168, 15);
            labelFuelCostAvg.TabIndex = 4;
            labelFuelCostAvg.Text = "Средние затраты на топливо:";
            // 
            // labelTotalCostAvg
            // 
            labelTotalCostAvg.AutoSize = true;
            labelTotalCostAvg.Location = new Point(18, 82);
            labelTotalCostAvg.Name = "labelTotalCostAvg";
            labelTotalCostAvg.Size = new Size(147, 15);
            labelTotalCostAvg.TabIndex = 5;
            labelTotalCostAvg.Text = "Общие затраты на выезд:";
            // 
            // labelFuelSum
            // 
            labelFuelSum.AutoSize = true;
            labelFuelSum.Location = new Point(18, 112);
            labelFuelSum.Name = "labelFuelSum";
            labelFuelSum.Size = new Size(151, 15);
            labelFuelSum.TabIndex = 6;
            labelFuelSum.Text = "Всего потрачено топлива:";
            // 
            // labelFertilizerSum
            // 
            labelFertilizerSum.AutoSize = true;
            labelFertilizerSum.Location = new Point(18, 142);
            labelFertilizerSum.Name = "labelFertilizerSum";
            labelFertilizerSum.Size = new Size(166, 15);
            labelFertilizerSum.TabIndex = 7;
            labelFertilizerSum.Text = "Всего потрачено удобрений:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(262, 15);
            dateTimePickerStart.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(176, 23);
            dateTimePickerStart.TabIndex = 2;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(262, 45);
            dateTimePickerEnd.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(176, 23);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.Location = new Point(262, 75);
            buttonGenerateReport.Margin = new Padding(3, 2, 3, 2);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(175, 26);
            buttonGenerateReport.TabIndex = 0;
            buttonGenerateReport.Text = "Сформировать отчет";
            buttonGenerateReport.Click += ButtonGenerateReport_Click;
            // 
            // resultFertilizerCostAvg
            // 
            resultFertilizerCostAvg.Location = new Point(210, 22);
            resultFertilizerCostAvg.Name = "resultFertilizerCostAvg";
            resultFertilizerCostAvg.Size = new Size(88, 17);
            resultFertilizerCostAvg.TabIndex = 8;
            // 
            // resultFuelCostAvg
            // 
            resultFuelCostAvg.Location = new Point(210, 52);
            resultFuelCostAvg.Name = "resultFuelCostAvg";
            resultFuelCostAvg.Size = new Size(88, 17);
            resultFuelCostAvg.TabIndex = 9;
            // 
            // resultTotalCostAvg
            // 
            resultTotalCostAvg.Location = new Point(210, 82);
            resultTotalCostAvg.Name = "resultTotalCostAvg";
            resultTotalCostAvg.Size = new Size(88, 17);
            resultTotalCostAvg.TabIndex = 10;
            // 
            // resultFuelSum
            // 
            resultFuelSum.Location = new Point(210, 112);
            resultFuelSum.Name = "resultFuelSum";
            resultFuelSum.Size = new Size(88, 17);
            resultFuelSum.TabIndex = 11;
            // 
            // resultFertilizerSum
            // 
            resultFertilizerSum.Location = new Point(210, 142);
            resultFertilizerSum.Name = "resultFertilizerSum";
            resultFertilizerSum.Size = new Size(88, 17);
            resultFertilizerSum.TabIndex = 12;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 312);
            Controls.Add(buttonGenerateReport);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelFertilizerCostAvg);
            Controls.Add(labelFuelCostAvg);
            Controls.Add(labelTotalCostAvg);
            Controls.Add(labelFuelSum);
            Controls.Add(labelFertilizerSum);
            Controls.Add(resultFertilizerCostAvg);
            Controls.Add(resultFuelCostAvg);
            Controls.Add(resultTotalCostAvg);
            Controls.Add(resultFuelSum);
            Controls.Add(resultFertilizerSum);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportsForm";
            Text = "Отчеты";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
