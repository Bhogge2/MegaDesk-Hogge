﻿namespace MegaDesk_Hogge
{
    partial class SearchQuotes
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
            this.btnCloseSearchQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseSearchQuotes
            // 
            this.btnCloseSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSearchQuotes.Location = new System.Drawing.Point(330, 200);
            this.btnCloseSearchQuotes.Name = "btnCloseSearchQuotes";
            this.btnCloseSearchQuotes.Size = new System.Drawing.Size(140, 50);
            this.btnCloseSearchQuotes.TabIndex = 28;
            this.btnCloseSearchQuotes.Text = "Close";
            this.btnCloseSearchQuotes.UseVisualStyleBackColor = true;
            this.btnCloseSearchQuotes.Click += new System.EventHandler(this.btnCloseSearchQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseSearchQuotes);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseSearchQuotes;
    }
}