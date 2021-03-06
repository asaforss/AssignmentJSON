﻿namespace Assignment
{
    partial class IndataForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMonday = new System.Windows.Forms.CheckBox();
            this.cbxSunday = new System.Windows.Forms.CheckBox();
            this.cbxSaturday = new System.Windows.Forms.CheckBox();
            this.cbxFriday = new System.Windows.Forms.CheckBox();
            this.cbxThursday = new System.Windows.Forms.CheckBox();
            this.cbxWednesday = new System.Windows.Forms.CheckBox();
            this.cbxTuesday = new System.Windows.Forms.CheckBox();
            this.numDaysInAdvance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnTemporary = new System.Windows.Forms.RadioButton();
            this.rbnExternal = new System.Windows.Forms.RadioButton();
            this.rbnNormal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysInAdvance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Info;
            this.btnStart.Location = new System.Drawing.Point(556, 281);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(91, 23);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(161, 20);
            this.tbxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delivery days:";
            // 
            // cbxMonday
            // 
            this.cbxMonday.AutoSize = true;
            this.cbxMonday.Location = new System.Drawing.Point(96, 76);
            this.cbxMonday.Name = "cbxMonday";
            this.cbxMonday.Size = new System.Drawing.Size(64, 17);
            this.cbxMonday.TabIndex = 5;
            this.cbxMonday.Text = "Monday";
            this.cbxMonday.UseVisualStyleBackColor = true;
            // 
            // cbxSunday
            // 
            this.cbxSunday.AutoSize = true;
            this.cbxSunday.Location = new System.Drawing.Point(538, 76);
            this.cbxSunday.Name = "cbxSunday";
            this.cbxSunday.Size = new System.Drawing.Size(62, 17);
            this.cbxSunday.TabIndex = 6;
            this.cbxSunday.Text = "Sunday";
            this.cbxSunday.UseVisualStyleBackColor = true;
            // 
            // cbxSaturday
            // 
            this.cbxSaturday.AutoSize = true;
            this.cbxSaturday.Location = new System.Drawing.Point(464, 76);
            this.cbxSaturday.Name = "cbxSaturday";
            this.cbxSaturday.Size = new System.Drawing.Size(68, 17);
            this.cbxSaturday.TabIndex = 7;
            this.cbxSaturday.Text = "Saturday";
            this.cbxSaturday.UseVisualStyleBackColor = true;
            // 
            // cbxFriday
            // 
            this.cbxFriday.AutoSize = true;
            this.cbxFriday.Location = new System.Drawing.Point(404, 76);
            this.cbxFriday.Name = "cbxFriday";
            this.cbxFriday.Size = new System.Drawing.Size(54, 17);
            this.cbxFriday.TabIndex = 8;
            this.cbxFriday.Text = "Friday";
            this.cbxFriday.UseVisualStyleBackColor = true;
            // 
            // cbxThursday
            // 
            this.cbxThursday.AutoSize = true;
            this.cbxThursday.Location = new System.Drawing.Point(328, 76);
            this.cbxThursday.Name = "cbxThursday";
            this.cbxThursday.Size = new System.Drawing.Size(70, 17);
            this.cbxThursday.TabIndex = 9;
            this.cbxThursday.Text = "Thursday";
            this.cbxThursday.UseVisualStyleBackColor = true;
            // 
            // cbxWednesday
            // 
            this.cbxWednesday.AutoSize = true;
            this.cbxWednesday.Location = new System.Drawing.Point(239, 76);
            this.cbxWednesday.Name = "cbxWednesday";
            this.cbxWednesday.Size = new System.Drawing.Size(83, 17);
            this.cbxWednesday.TabIndex = 10;
            this.cbxWednesday.Text = "Wednesday";
            this.cbxWednesday.UseVisualStyleBackColor = true;
            // 
            // cbxTuesday
            // 
            this.cbxTuesday.AutoSize = true;
            this.cbxTuesday.Location = new System.Drawing.Point(166, 76);
            this.cbxTuesday.Name = "cbxTuesday";
            this.cbxTuesday.Size = new System.Drawing.Size(67, 17);
            this.cbxTuesday.TabIndex = 11;
            this.cbxTuesday.Text = "Tuesday";
            this.cbxTuesday.UseVisualStyleBackColor = true;
            // 
            // numDaysInAdvance
            // 
            this.numDaysInAdvance.Location = new System.Drawing.Point(497, 126);
            this.numDaysInAdvance.Name = "numDaysInAdvance";
            this.numDaysInAdvance.Size = new System.Drawing.Size(45, 20);
            this.numDaysInAdvance.TabIndex = 12;
            this.numDaysInAdvance.ValueChanged += new System.EventHandler(this.NumDaysInAdvance_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Days in advance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnTemporary);
            this.groupBox1.Controls.Add(this.rbnExternal);
            this.groupBox1.Controls.Add(this.rbnNormal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 55);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // rbnTemporary
            // 
            this.rbnTemporary.AutoSize = true;
            this.rbnTemporary.Location = new System.Drawing.Point(244, 27);
            this.rbnTemporary.Name = "rbnTemporary";
            this.rbnTemporary.Size = new System.Drawing.Size(75, 17);
            this.rbnTemporary.TabIndex = 18;
            this.rbnTemporary.Text = "Temporary\r\n";
            this.rbnTemporary.UseVisualStyleBackColor = true;
            this.rbnTemporary.CheckedChanged += new System.EventHandler(this.RbnTemporary_CheckedChanged);
            // 
            // rbnExternal
            // 
            this.rbnExternal.AutoSize = true;
            this.rbnExternal.Location = new System.Drawing.Point(175, 27);
            this.rbnExternal.Name = "rbnExternal";
            this.rbnExternal.Size = new System.Drawing.Size(63, 17);
            this.rbnExternal.TabIndex = 17;
            this.rbnExternal.TabStop = true;
            this.rbnExternal.Text = "External";
            this.rbnExternal.UseVisualStyleBackColor = true;
            this.rbnExternal.CheckedChanged += new System.EventHandler(this.RbnExternal_CheckedChanged);
            // 
            // rbnNormal
            // 
            this.rbnNormal.AutoSize = true;
            this.rbnNormal.Checked = true;
            this.rbnNormal.Location = new System.Drawing.Point(111, 27);
            this.rbnNormal.Name = "rbnNormal";
            this.rbnNormal.Size = new System.Drawing.Size(58, 17);
            this.rbnNormal.TabIndex = 16;
            this.rbnNormal.TabStop = true;
            this.rbnNormal.Text = "Normal";
            this.rbnNormal.UseVisualStyleBackColor = true;
            this.rbnNormal.CheckedChanged += new System.EventHandler(this.RbnNormal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.tbxName);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numDaysInAdvance);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxMonday);
            this.groupBox2.Controls.Add(this.cbxTuesday);
            this.groupBox2.Controls.Add(this.cbxSunday);
            this.groupBox2.Controls.Add(this.cbxWednesday);
            this.groupBox2.Controls.Add(this.cbxSaturday);
            this.groupBox2.Controls.Add(this.cbxThursday);
            this.groupBox2.Controls.Add(this.cbxFriday);
            this.groupBox2.Location = new System.Drawing.Point(39, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 176);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(370, 31);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.tbxPostalCode);
            this.groupBox3.Location = new System.Drawing.Point(39, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 47);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Postal code";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(91, 19);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(89, 20);
            this.tbxPostalCode.TabIndex = 0;
            // 
            // IndataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 326);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStart);
            this.Name = "IndataForm";
            this.Text = "Indata";
            ((System.ComponentModel.ISupportInitialize)(this.numDaysInAdvance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxMonday;
        private System.Windows.Forms.CheckBox cbxSunday;
        private System.Windows.Forms.CheckBox cbxSaturday;
        private System.Windows.Forms.CheckBox cbxFriday;
        private System.Windows.Forms.CheckBox cbxThursday;
        private System.Windows.Forms.CheckBox cbxWednesday;
        private System.Windows.Forms.CheckBox cbxTuesday;
        private System.Windows.Forms.NumericUpDown numDaysInAdvance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnTemporary;
        private System.Windows.Forms.RadioButton rbnExternal;
        private System.Windows.Forms.RadioButton rbnNormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

