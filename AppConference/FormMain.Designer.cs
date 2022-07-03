namespace AppConference
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonParticipants = new System.Windows.Forms.Button();
            this.buttonEquipments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonSchedule.Location = new System.Drawing.Point(112, 59);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(600, 55);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "Розклад конференцій";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // buttonParticipants
            // 
            this.buttonParticipants.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonParticipants.Location = new System.Drawing.Point(112, 167);
            this.buttonParticipants.Name = "buttonParticipants";
            this.buttonParticipants.Size = new System.Drawing.Size(600, 55);
            this.buttonParticipants.TabIndex = 1;
            this.buttonParticipants.Text = "Учасники конференцій";
            this.buttonParticipants.UseVisualStyleBackColor = true;
            this.buttonParticipants.Click += new System.EventHandler(this.buttonParticipants_Click);
            // 
            // buttonEquipments
            // 
            this.buttonEquipments.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.buttonEquipments.Location = new System.Drawing.Point(112, 275);
            this.buttonEquipments.Name = "buttonEquipments";
            this.buttonEquipments.Size = new System.Drawing.Size(600, 55);
            this.buttonEquipments.TabIndex = 2;
            this.buttonEquipments.Text = "Обладнання для виступів";
            this.buttonEquipments.UseVisualStyleBackColor = true;
            this.buttonEquipments.Click += new System.EventHandler(this.buttonEquipments_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEquipments);
            this.Controls.Add(this.buttonParticipants);
            this.Controls.Add(this.buttonSchedule);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ІС Конференції";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSchedule;
        private Button buttonParticipants;
        private Button buttonEquipments;
    }
}