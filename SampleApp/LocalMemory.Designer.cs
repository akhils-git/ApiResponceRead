﻿
namespace SampleApp
{
    partial class LocalMemory
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(307, 150);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(189, 62);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(307, 45);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 20);
            this.txtIndex.TabIndex = 1;
            // 
            // LocalMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.btnTest);
            this.Name = "LocalMemory";
            this.Text = "LocalMemory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtIndex;
    }
}