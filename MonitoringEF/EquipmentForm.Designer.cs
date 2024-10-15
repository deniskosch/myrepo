namespace MonitoringEF
{
    partial class EquipmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewEquipment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFertilizerTankCapacity;
        private System.Windows.Forms.TextBox txtFuelTankCapacity;
        private System.Windows.Forms.TextBox txtEnginePower;
        private System.Windows.Forms.TextBox txtLoadCapacity;
        private System.Windows.Forms.TextBox txtEquipmentType;

        private void InitializeComponent()
        {
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFertilizerTankCapacity = new System.Windows.Forms.TextBox();
            this.txtFuelTankCapacity = new System.Windows.Forms.TextBox();
            this.txtEnginePower = new System.Windows.Forms.TextBox();
            this.txtLoadCapacity = new System.Windows.Forms.TextBox();
            this.txtEquipmentType = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewEquipment
            // 
            this.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipment.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.RowHeadersWidth = 51;
            this.dataGridViewEquipment.RowTemplate.Height = 29;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(776, 300);
            this.dataGridViewEquipment.TabIndex = 0;
            this.dataGridViewEquipment.SelectionChanged += new System.EventHandler(this.dataGridViewEquipment_SelectionChanged);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 318);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 354);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(776, 27);
            this.txtName.TabIndex = 4;
            this.txtName.PlaceholderText = "Name";

            // 
            // txtFertilizerTankCapacity
            // 
            this.txtFertilizerTankCapacity.Location = new System.Drawing.Point(12, 387);
            this.txtFertilizerTankCapacity.Name = "txtFertilizerTankCapacity";
            this.txtFertilizerTankCapacity.Size = new System.Drawing.Size(776, 27);
            this.txtFertilizerTankCapacity.TabIndex = 5;
            this.txtFertilizerTankCapacity.PlaceholderText = "Fertilizer Tank Capacity";

            // 
            // txtFuelTankCapacity
            // 
            this.txtFuelTankCapacity.Location = new System.Drawing.Point(12, 420);
            this.txtFuelTankCapacity.Name = "txtFuelTankCapacity";
            this.txtFuelTankCapacity.Size = new System.Drawing.Size(776, 27);
            this.txtFuelTankCapacity.TabIndex = 6;
            this.txtFuelTankCapacity.PlaceholderText = "Fuel Tank Capacity";

            // 
            // txtEnginePower
            // 
            this.txtEnginePower.Location = new System.Drawing.Point(12, 453);
            this.txtEnginePower.Name = "txtEnginePower";
            this.txtEnginePower.Size = new System.Drawing.Size(776, 27);
            this.txtEnginePower.TabIndex = 7;
            this.txtEnginePower.PlaceholderText = "Engine Power";

            // 
            // txtLoadCapacity
            // 
            this.txtLoadCapacity.Location = new System.Drawing.Point(12, 486);
            this.txtLoadCapacity.Name = "txtLoadCapacity";
            this.txtLoadCapacity.Size = new System.Drawing.Size(776, 27);
            this.txtLoadCapacity.TabIndex = 8;
            this.txtLoadCapacity.PlaceholderText = "Load Capacity";

            // 
            // txtEquipmentType
            // 
            this.txtEquipmentType.Location = new System.Drawing.Point(12, 519);
            this.txtEquipmentType.Name = "txtEquipmentType";
            this.txtEquipmentType.Size = new System.Drawing.Size(776, 27);
            this.txtEquipmentType.TabIndex = 9;
            this.txtEquipmentType.PlaceholderText = "Equipment Type";

            // 
            // EquipmentForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtEquipmentType);
            this.Controls.Add(this.txtLoadCapacity);
            this.Controls.Add(this.txtEnginePower);
            this.Controls.Add(this.txtFuelTankCapacity);
            this.Controls.Add(this.txtFertilizerTankCapacity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewEquipment);
            this.Name = "EquipmentForm";
            this.Text = "Equipment Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
