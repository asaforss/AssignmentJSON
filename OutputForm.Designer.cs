﻿namespace Assignement
{
    partial class OutputForm
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
            this.rtbxOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxOutput
            // 
            this.rtbxOutput.EnableAutoDragDrop = true;
            this.rtbxOutput.Location = new System.Drawing.Point(27, 23);
            this.rtbxOutput.Name = "rtbxOutput";
            this.rtbxOutput.Size = new System.Drawing.Size(436, 534);
            this.rtbxOutput.TabIndex = 0;
            this.rtbxOutput.Text = "";
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 569);
            this.Controls.Add(this.rtbxOutput);
            this.Name = "OutputForm";
            this.Text = "OutputForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbxOutput;
    }
}