namespace AngelBuilder
{
    partial class WeaponDeleter
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
            this.Label_Delete = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Id = new System.Windows.Forms.Label();
            this.Label_Sure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Delete
            // 
            this.Label_Delete.AutoSize = true;
            this.Label_Delete.Location = new System.Drawing.Point(14, 9);
            this.Label_Delete.Name = "Label_Delete";
            this.Label_Delete.Size = new System.Drawing.Size(473, 17);
            this.Label_Delete.TabIndex = 1;
            this.Label_Delete.Text = "Warning! You are DELETING the following Weapon, proceed with Caution!";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.Location = new System.Drawing.Point(250, 103);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Button_Cancel.TabIndex = 10;
            this.Button_Cancel.Text = "NO";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(169, 103);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 23);
            this.Button_Delete.TabIndex = 9;
            this.Button_Delete.Text = "YES";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(193, 31);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(98, 17);
            this.Label_Name.TabIndex = 8;
            this.Label_Name.Text = "Label_Name";
            // 
            // Label_Id
            // 
            this.Label_Id.AutoSize = true;
            this.Label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Id.Location = new System.Drawing.Point(206, 54);
            this.Label_Id.Name = "Label_Id";
            this.Label_Id.Size = new System.Drawing.Size(70, 17);
            this.Label_Id.TabIndex = 7;
            this.Label_Id.Text = "Label_Id";
            // 
            // Label_Sure
            // 
            this.Label_Sure.AutoSize = true;
            this.Label_Sure.Location = new System.Drawing.Point(143, 76);
            this.Label_Sure.Name = "Label_Sure";
            this.Label_Sure.Size = new System.Drawing.Size(214, 17);
            this.Label_Sure.TabIndex = 6;
            this.Label_Sure.Text = "Are you sure you wish to delete?";
            // 
            // WeaponDeleter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(492, 138);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Label_Id);
            this.Controls.Add(this.Label_Sure);
            this.Controls.Add(this.Label_Delete);
            this.Name = "WeaponDeleter";
            this.Text = "WeaponDeleter";
            this.Load += new System.EventHandler(this.WeaponDeleter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Delete;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Delete;
        public System.Windows.Forms.Label Label_Name;
        public System.Windows.Forms.Label Label_Id;
        private System.Windows.Forms.Label Label_Sure;
    }
}