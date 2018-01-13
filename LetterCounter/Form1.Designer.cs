﻿namespace LetterCounter
{
    partial class frmMain
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
            this.openTextFile = new System.Windows.Forms.OpenFileDialog();
            this.cmdOpenTextFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openTextFile
            // 
            this.openTextFile.FileName = "openFileDialog";
            this.openTextFile.Filter = "\"Text Files|*.txt|All Files|*.*\"";
            this.openTextFile.Title = "Select Text File";
            // 
            // cmdOpenTextFile
            // 
            this.cmdOpenTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOpenTextFile.Location = new System.Drawing.Point(12, 359);
            this.cmdOpenTextFile.Name = "cmdOpenTextFile";
            this.cmdOpenTextFile.Size = new System.Drawing.Size(135, 23);
            this.cmdOpenTextFile.TabIndex = 0;
            this.cmdOpenTextFile.Text = "Open Text File";
            this.cmdOpenTextFile.UseVisualStyleBackColor = true;
            this.cmdOpenTextFile.Click += new System.EventHandler(this.cmdOpenTextFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 303);
            this.listBox1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 394);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdOpenTextFile);
            this.Name = "frmMain";
            this.Text = "Char Counter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openTextFile;
        private System.Windows.Forms.Button cmdOpenTextFile;
        private System.Windows.Forms.ListBox listBox1;
    }
}

