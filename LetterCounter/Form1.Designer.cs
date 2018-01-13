namespace LetterCounter
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
            this.cmdOpenTextFile.Location = new System.Drawing.Point(12, 226);
            this.cmdOpenTextFile.Name = "cmdOpenTextFile";
            this.cmdOpenTextFile.Size = new System.Drawing.Size(135, 23);
            this.cmdOpenTextFile.TabIndex = 0;
            this.cmdOpenTextFile.Text = "Open Text File";
            this.cmdOpenTextFile.UseVisualStyleBackColor = true;
            this.cmdOpenTextFile.Click += new System.EventHandler(this.cmdOpenTextFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 261);
            this.Controls.Add(this.cmdOpenTextFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openTextFile;
        private System.Windows.Forms.Button cmdOpenTextFile;
    }
}

