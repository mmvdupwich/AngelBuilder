namespace AngelBuilder
{
    partial class Form1
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
            this.Button_WeaponEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_WeaponEditor
            // 
            this.Button_WeaponEditor.Location = new System.Drawing.Point(12, 12);
            this.Button_WeaponEditor.Name = "Button_WeaponEditor";
            this.Button_WeaponEditor.Size = new System.Drawing.Size(142, 44);
            this.Button_WeaponEditor.TabIndex = 0;
            this.Button_WeaponEditor.Text = "Weapon Editor";
            this.Button_WeaponEditor.UseVisualStyleBackColor = true;
            this.Button_WeaponEditor.Click += new System.EventHandler(this.Button_WeaponEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_WeaponEditor);
            this.Name = "Form1";
            this.Text = "AngelBuilder Data Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_WeaponEditor;
    }
}

