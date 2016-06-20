namespace ReArrange_Files
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
            this.radioTOFolders = new System.Windows.Forms.RadioButton();
            this.radioFolders = new System.Windows.Forms.RadioButton();
            this.radionFiles = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PathTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioTOFolders
            // 
            this.radioTOFolders.AutoSize = true;
            this.radioTOFolders.Location = new System.Drawing.Point(337, 89);
            this.radioTOFolders.Name = "radioTOFolders";
            this.radioTOFolders.Size = new System.Drawing.Size(94, 17);
            this.radioTOFolders.TabIndex = 9;
            this.radioTOFolders.TabStop = true;
            this.radioTOFolders.Text = "Split to Folders";
            this.radioTOFolders.UseVisualStyleBackColor = true;
            // 
            // radioFolders
            // 
            this.radioFolders.AutoSize = true;
            this.radioFolders.Location = new System.Drawing.Point(207, 89);
            this.radioFolders.Name = "radioFolders";
            this.radioFolders.Size = new System.Drawing.Size(98, 17);
            this.radioFolders.TabIndex = 8;
            this.radioFolders.TabStop = true;
            this.radioFolders.Text = "Contain Folders";
            this.radioFolders.UseVisualStyleBackColor = true;
            // 
            // radionFiles
            // 
            this.radionFiles.AutoSize = true;
            this.radionFiles.Location = new System.Drawing.Point(90, 89);
            this.radionFiles.Name = "radionFiles";
            this.radionFiles.Size = new System.Drawing.Size(85, 17);
            this.radionFiles.TabIndex = 7;
            this.radionFiles.TabStop = true;
            this.radionFiles.Text = "Contain Files";
            this.radionFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path of Files:";
            // 
            // PathTB
            // 
            this.PathTB.Location = new System.Drawing.Point(42, 41);
            this.PathTB.Name = "PathTB";
            this.PathTB.Size = new System.Drawing.Size(450, 20);
            this.PathTB.TabIndex = 5;
            this.PathTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathTB_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 144);
            this.Controls.Add(this.radioTOFolders);
            this.Controls.Add(this.radioFolders);
            this.Controls.Add(this.radionFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathTB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioTOFolders;
        private System.Windows.Forms.RadioButton radioFolders;
        private System.Windows.Forms.RadioButton radionFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathTB;
    }
}

