namespace AppConference
{
    partial class FormSchedule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxConference = new System.Windows.Forms.ComboBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.labelConference = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxConference
            // 
            this.comboBoxConference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxConference.FormattingEnabled = true;
            this.comboBoxConference.Location = new System.Drawing.Point(350, 40);
            this.comboBoxConference.Name = "comboBoxConference";
            this.comboBoxConference.Size = new System.Drawing.Size(776, 36);
            this.comboBoxConference.TabIndex = 1;
            this.comboBoxConference.SelectedIndexChanged += new System.EventHandler(this.comboBoxConference_SelectedIndexChanged);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(350, 95);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(776, 36);
            this.comboBoxSection.TabIndex = 2;
            this.comboBoxSection.Visible = false;
            // 
            // labelConference
            // 
            this.labelConference.AutoSize = true;
            this.labelConference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConference.Location = new System.Drawing.Point(130, 40);
            this.labelConference.Name = "labelConference";
            this.labelConference.Size = new System.Drawing.Size(214, 28);
            this.labelConference.TabIndex = 3;
            this.labelConference.Text = "Оберіть конференцію";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSection.Location = new System.Drawing.Point(193, 98);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(151, 28);
            this.labelSection.TabIndex = 4;
            this.labelSection.Text = "Оберіть секцію";
            this.labelSection.Visible = false;
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFind.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFind.Location = new System.Drawing.Point(0, 447);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(1259, 56);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Здійснити пошук";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Visible = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 503);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.labelConference);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.comboBoxConference);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxConference;
        private ComboBox comboBoxSection;
        private Label labelConference;
        private Label labelSection;
        private Button buttonFind;
    }
}