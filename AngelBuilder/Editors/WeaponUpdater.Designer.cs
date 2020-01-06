namespace AngelBuilder
{
    partial class WeaponUpdater
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
            this.Label_Warning = new System.Windows.Forms.Label();
            this.Label_Sure = new System.Windows.Forms.Label();
            this.Label_Id = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Warning
            // 
            this.Label_Warning.AutoSize = true;
            this.Label_Warning.Location = new System.Drawing.Point(12, 9);
            this.Label_Warning.Name = "Label_Warning";
            this.Label_Warning.Size = new System.Drawing.Size(459, 17);
            this.Label_Warning.TabIndex = 0;
            this.Label_Warning.Text = "Warning! You are updating the following Weapon, proceed with Caution!";
            // 
            // Label_Sure
            // 
            this.Label_Sure.AutoSize = true;
            this.Label_Sure.Location = new System.Drawing.Point(134, 80);
            this.Label_Sure.Name = "Label_Sure";
            this.Label_Sure.Size = new System.Drawing.Size(219, 17);
            this.Label_Sure.TabIndex = 1;
            this.Label_Sure.Text = "Are you sure you wish to update?";
            // 
            // Label_Id
            // 
            this.Label_Id.AutoSize = true;
            this.Label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Id.Location = new System.Drawing.Point(197, 58);
            this.Label_Id.Name = "Label_Id";
            this.Label_Id.Size = new System.Drawing.Size(70, 17);
            this.Label_Id.TabIndex = 2;
            this.Label_Id.Text = "Label_Id";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(184, 35);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(98, 17);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "Label_Name";
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point(160, 107);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(75, 23);
            this.Button_Update.TabIndex = 4;
            this.Button_Update.Text = "YES";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(241, 107);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 5;
            this.Button_Cancel.Text = "NO";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // WeaponUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 137);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Update);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_Id);
            this.Controls.Add(this.Label_Sure);
            this.Controls.Add(this.Label_Warning);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeaponUpdater";
            this.Text = "WeaponUpdater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Warning;
        private System.Windows.Forms.Label Label_Sure;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_Cancel;
        public System.Windows.Forms.Label Label_Id;
        public System.Windows.Forms.Label Label_Name;
    }
}