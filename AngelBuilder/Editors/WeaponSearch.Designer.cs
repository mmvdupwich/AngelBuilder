namespace AngelBuilder
{
    partial class WeaponSearch
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
            this.Label_Search = new System.Windows.Forms.Label();
            this.Text_Search = new System.Windows.Forms.TextBox();
            this.Button_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Search
            // 
            this.Label_Search.AutoSize = true;
            this.Label_Search.Location = new System.Drawing.Point(13, 13);
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(189, 17);
            this.Label_Search.TabIndex = 0;
            this.Label_Search.Text = "Fill in the Unique Weapon Id:";
            // 
            // Text_Search
            // 
            this.Text_Search.Location = new System.Drawing.Point(16, 34);
            this.Text_Search.Name = "Text_Search";
            this.Text_Search.Size = new System.Drawing.Size(354, 22);
            this.Text_Search.TabIndex = 1;
            this.Text_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Search_KeyDown);
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(157, 62);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(75, 23);
            this.Button_Search.TabIndex = 2;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // WeaponSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 95);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.Text_Search);
            this.Controls.Add(this.Label_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeaponSearch";
            this.Text = "WeaponSearch";
            this.Load += new System.EventHandler(this.WeaponSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Search;
        private System.Windows.Forms.TextBox Text_Search;
        private System.Windows.Forms.Button Button_Search;
    }
}