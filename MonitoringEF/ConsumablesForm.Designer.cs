namespace MonitoringEF
{
    partial class ConsumablesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewConsumables;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPrice;

        private void InitializeComponent()
        {
            this.dataGridViewConsumables = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumables)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewConsumables
            // 
            this.dataGridViewConsumables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsumables.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewConsumables.Name = "dataGridViewConsumables";
            this.dataGridViewConsumables.RowHeadersWidth = 51;
            this.dataGridViewConsumables.RowTemplate.Height = 29;
            this.dataGridViewConsumables.Size = new System.Drawing.Size(776, 300);
            this.dataGridViewConsumables.TabIndex = 0;
            this.dataGridViewConsumables.SelectionChanged += new System.EventHandler(this.dataGridViewConsumables_SelectionChanged);

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
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(12, 387);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(776, 27);
            this.txtType.TabIndex = 5;
            this.txtType.PlaceholderText = "Type";

            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 420);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(776, 27);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.PlaceholderText = "Price";

            // 
            // ConsumablesForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewConsumables);
            this.Name = "ConsumablesForm";
            this.Text = "Consumables Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsumables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
