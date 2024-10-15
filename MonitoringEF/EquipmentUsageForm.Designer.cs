namespace MonitoringEF
{
    partial class EquipmentUsageForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbEquipment;
        private System.Windows.Forms.ComboBox cmbFertilizer;
        private System.Windows.Forms.ComboBox cmbFuel;
        private System.Windows.Forms.NumericUpDown nudFertilizerUsed;
        private System.Windows.Forms.NumericUpDown nudFuelUsed;
        private System.Windows.Forms.NumericUpDown nudHoursWorked;
        private System.Windows.Forms.NumericUpDown nudDistanceCovered;
        private System.Windows.Forms.NumericUpDown nudAreaCovered;
        private System.Windows.Forms.NumericUpDown nudRepairCost;
        private System.Windows.Forms.NumericUpDown nudRefills;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.DateTimePicker dateTimePicker;

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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cmbEquipment = new ComboBox();
            cmbFertilizer = new ComboBox();
            cmbFuel = new ComboBox();
            nudFertilizerUsed = new NumericUpDown();
            nudFuelUsed = new NumericUpDown();
            nudHoursWorked = new NumericUpDown();
            nudDistanceCovered = new NumericUpDown();
            nudAreaCovered = new NumericUpDown();
            nudRepairCost = new NumericUpDown();
            nudRefills = new NumericUpDown();
            txtComments = new TextBox();
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFertilizerUsed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFuelUsed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHoursWorked).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistanceCovered).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAreaCovered).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRepairCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRefills).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 300);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 318);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbEquipment
            // 
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(12, 348);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(121, 23);
            cmbEquipment.TabIndex = 4;
            cmbEquipment.Text = "Оборудование";
            // 
            // cmbFertilizer
            // 
            cmbFertilizer.FormattingEnabled = true;
            cmbFertilizer.Location = new Point(139, 348);
            cmbFertilizer.Name = "cmbFertilizer";
            cmbFertilizer.Size = new Size(121, 23);
            cmbFertilizer.TabIndex = 5;
            cmbFertilizer.Text = "Удобрение";
            // 
            // cmbFuel
            // 
            cmbFuel.FormattingEnabled = true;
            cmbFuel.Location = new Point(266, 348);
            cmbFuel.Name = "cmbFuel";
            cmbFuel.Size = new Size(121, 23);
            cmbFuel.TabIndex = 6;
            cmbFuel.Text = "Топливо";
            // 
            // nudFertilizerUsed
            // 
            nudFertilizerUsed.Location = new Point(398, 377);
            nudFertilizerUsed.Name = "nudFertilizerUsed";
            nudFertilizerUsed.Size = new Size(120, 23);
            nudFertilizerUsed.TabIndex = 7;
            // 
            // nudFuelUsed
            // 
            nudFuelUsed.Location = new Point(524, 377);
            nudFuelUsed.Name = "nudFuelUsed";
            nudFuelUsed.Size = new Size(120, 23);
            nudFuelUsed.TabIndex = 8;
            // 
            // nudHoursWorked
            // 
            nudHoursWorked.Location = new Point(650, 377);
            nudHoursWorked.Name = "nudHoursWorked";
            nudHoursWorked.Size = new Size(120, 23);
            nudHoursWorked.TabIndex = 9;
            // 
            // nudDistanceCovered
            // 
            nudDistanceCovered.Location = new Point(12, 433);
            nudDistanceCovered.Name = "nudDistanceCovered";
            nudDistanceCovered.Size = new Size(120, 23);
            nudDistanceCovered.TabIndex = 10;
            // 
            // nudAreaCovered
            // 
            nudAreaCovered.Location = new Point(139, 433);
            nudAreaCovered.Name = "nudAreaCovered";
            nudAreaCovered.Size = new Size(120, 23);
            nudAreaCovered.TabIndex = 11;
            // 
            // nudRepairCost
            // 
            nudRepairCost.Location = new Point(267, 433);
            nudRepairCost.Name = "nudRepairCost";
            nudRepairCost.Size = new Size(120, 23);
            nudRepairCost.TabIndex = 12;
            // 
            // nudRefills
            // 
            nudRefills.Location = new Point(398, 433);
            nudRefills.Name = "nudRefills";
            nudRefills.Size = new Size(120, 23);
            nudRefills.TabIndex = 13;
            // 
            // txtComments
            // 
            txtComments.Location = new Point(524, 406);
            txtComments.Multiline = true;
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(246, 50);
            txtComments.TabIndex = 14;
            txtComments.Text = "Комментарии оператора";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(12, 494);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 15;
            dateTimePicker.Value = new DateTime(2024, 10, 15, 14, 14, 51, 75);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 352);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 16;
            label1.Text = "nudFertilizerUsed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 352);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 17;
            label2.Text = "nudFuelUsed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 356);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 18;
            label3.Text = "nudHoursWorked";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 409);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 19;
            label4.Text = "nudDistanceCovered";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 409);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 20;
            label5.Text = "nudAreaCovered";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 409);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 21;
            label6.Text = "nudRepairCost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(400, 409);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 22;
            label7.Text = "nudRefills";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 469);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 23;
            label8.Text = "dateTimePicker";
            // 
            // EquipmentUsageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Controls.Add(txtComments);
            Controls.Add(nudRefills);
            Controls.Add(nudRepairCost);
            Controls.Add(nudAreaCovered);
            Controls.Add(nudDistanceCovered);
            Controls.Add(nudHoursWorked);
            Controls.Add(nudFuelUsed);
            Controls.Add(nudFertilizerUsed);
            Controls.Add(cmbFuel);
            Controls.Add(cmbFertilizer);
            Controls.Add(cmbEquipment);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "EquipmentUsageForm";
            Text = "Использование оборудования";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFertilizerUsed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFuelUsed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHoursWorked).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistanceCovered).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAreaCovered).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRepairCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRefills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
