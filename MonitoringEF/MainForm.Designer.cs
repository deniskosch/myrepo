namespace MonitoringEF
{
    partial class MainForm
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
            OpenEquipmentForm = new Button();
            OpenEquipmentUsageForm = new Button();
            OpenConsumablesForm = new Button();
            OpenReportsForm = new Button();
            SuspendLayout();
            // 
            // OpenEquipmentForm
            // 
            OpenEquipmentForm.Location = new Point(306, 290);
            OpenEquipmentForm.Name = "OpenEquipmentForm";
            OpenEquipmentForm.Size = new Size(187, 23);
            OpenEquipmentForm.TabIndex = 0;
            OpenEquipmentForm.Text = "OpenEquipmentForm";
            OpenEquipmentForm.UseVisualStyleBackColor = true;
            OpenEquipmentForm.Click += OpenEquipmentForm_Click;
            // 
            // OpenEquipmentUsageForm
            // 
            OpenEquipmentUsageForm.Location = new Point(306, 323);
            OpenEquipmentUsageForm.Name = "OpenEquipmentUsageForm";
            OpenEquipmentUsageForm.Size = new Size(187, 23);
            OpenEquipmentUsageForm.TabIndex = 1;
            OpenEquipmentUsageForm.Text = "OpenEquipmentUsageForm";
            OpenEquipmentUsageForm.UseVisualStyleBackColor = true;
            OpenEquipmentUsageForm.Click += OpenEquipmentUsageForm_Click;
            // 
            // OpenConsumablesForm
            // 
            OpenConsumablesForm.Location = new Point(306, 354);
            OpenConsumablesForm.Name = "OpenConsumablesForm";
            OpenConsumablesForm.Size = new Size(187, 23);
            OpenConsumablesForm.TabIndex = 2;
            OpenConsumablesForm.Text = "OpenConsumablesForm";
            OpenConsumablesForm.UseVisualStyleBackColor = true;
            OpenConsumablesForm.Click += OpenConsumablesForm_Click;
            // 
            // OpenReportsForm
            // 
            OpenReportsForm.Location = new Point(306, 383);
            OpenReportsForm.Name = "OpenReportsForm";
            OpenReportsForm.Size = new Size(187, 23);
            OpenReportsForm.TabIndex = 3;
            OpenReportsForm.Text = "OpenReportsForm";
            OpenReportsForm.UseVisualStyleBackColor = true;
            OpenReportsForm.Click += OpenReportsForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OpenReportsForm);
            Controls.Add(OpenConsumablesForm);
            Controls.Add(OpenEquipmentUsageForm);
            Controls.Add(OpenEquipmentForm);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button OpenEquipmentForm;
        private Button OpenEquipmentUsageForm;
        private Button OpenConsumablesForm;
        private Button OpenReportsForm;
    }
}