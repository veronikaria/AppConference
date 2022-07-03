namespace AppConference
{
    partial class FormParticipants
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
            this.labelConference = new System.Windows.Forms.Label();
            this.comboBoxConference = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConference
            // 
            this.labelConference.AutoSize = true;
            this.labelConference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConference.Location = new System.Drawing.Point(39, 28);
            this.labelConference.Name = "labelConference";
            this.labelConference.Size = new System.Drawing.Size(214, 28);
            this.labelConference.TabIndex = 5;
            this.labelConference.Text = "Оберіть конференцію";
            // 
            // comboBoxConference
            // 
            this.comboBoxConference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConference.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxConference.FormattingEnabled = true;
            this.comboBoxConference.Location = new System.Drawing.Point(259, 28);
            this.comboBoxConference.Name = "comboBoxConference";
            this.comboBoxConference.Size = new System.Drawing.Size(836, 36);
            this.comboBoxConference.TabIndex = 4;
            this.comboBoxConference.SelectedIndexChanged += new System.EventHandler(this.comboBoxConference_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 260);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonFind
            // 
            this.buttonFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonFind.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFind.Location = new System.Drawing.Point(0, 399);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(1138, 51);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Здійснити пошук";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Visible = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // FormParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 450);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelConference);
            this.Controls.Add(this.comboBoxConference);
            this.Name = "FormParticipants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormParticipants";
            this.Load += new System.EventHandler(this.FormParticipants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelConference;
        private ComboBox comboBoxConference;
        private DataGridView dataGridView1;
        private Button buttonFind;
    }
}