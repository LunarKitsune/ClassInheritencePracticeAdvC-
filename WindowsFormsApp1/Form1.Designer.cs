﻿namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDInput = new System.Windows.Forms.TextBox();
            this.txtCreditInput = new System.Windows.Forms.TextBox();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.txtPointInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgeInput = new System.Windows.Forms.TextBox();
            this.rtbAcademicOutput = new System.Windows.Forms.RichTextBox();
            this.btnGetAcademicPerform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Points:";
            // 
            // txtIDInput
            // 
            this.txtIDInput.Location = new System.Drawing.Point(85, 37);
            this.txtIDInput.Name = "txtIDInput";
            this.txtIDInput.Size = new System.Drawing.Size(100, 20);
            this.txtIDInput.TabIndex = 4;
            // 
            // txtCreditInput
            // 
            this.txtCreditInput.Location = new System.Drawing.Point(85, 155);
            this.txtCreditInput.Name = "txtCreditInput";
            this.txtCreditInput.Size = new System.Drawing.Size(100, 20);
            this.txtCreditInput.TabIndex = 5;
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(85, 83);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(100, 20);
            this.txtNameInput.TabIndex = 6;
            // 
            // txtPointInput
            // 
            this.txtPointInput.Location = new System.Drawing.Point(85, 201);
            this.txtPointInput.Name = "txtPointInput";
            this.txtPointInput.Size = new System.Drawing.Size(100, 20);
            this.txtPointInput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age:";
            // 
            // txtAgeInput
            // 
            this.txtAgeInput.Location = new System.Drawing.Point(85, 122);
            this.txtAgeInput.Name = "txtAgeInput";
            this.txtAgeInput.Size = new System.Drawing.Size(100, 20);
            this.txtAgeInput.TabIndex = 9;
            // 
            // rtbAcademicOutput
            // 
            this.rtbAcademicOutput.Location = new System.Drawing.Point(253, 37);
            this.rtbAcademicOutput.Name = "rtbAcademicOutput";
            this.rtbAcademicOutput.Size = new System.Drawing.Size(152, 131);
            this.rtbAcademicOutput.TabIndex = 10;
            this.rtbAcademicOutput.Text = "";
            // 
            // btnGetAcademicPerform
            // 
            this.btnGetAcademicPerform.Location = new System.Drawing.Point(253, 174);
            this.btnGetAcademicPerform.Name = "btnGetAcademicPerform";
            this.btnGetAcademicPerform.Size = new System.Drawing.Size(152, 47);
            this.btnGetAcademicPerform.TabIndex = 11;
            this.btnGetAcademicPerform.Text = "Calculate";
            this.btnGetAcademicPerform.UseVisualStyleBackColor = true;
            this.btnGetAcademicPerform.Click += new System.EventHandler(this.BtnGetAcademicPerform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 304);
            this.Controls.Add(this.btnGetAcademicPerform);
            this.Controls.Add(this.rtbAcademicOutput);
            this.Controls.Add(this.txtAgeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPointInput);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.txtCreditInput);
            this.Controls.Add(this.txtIDInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GPA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDInput;
        private System.Windows.Forms.TextBox txtCreditInput;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.TextBox txtPointInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgeInput;
        private System.Windows.Forms.RichTextBox rtbAcademicOutput;
        private System.Windows.Forms.Button btnGetAcademicPerform;
    }
}

