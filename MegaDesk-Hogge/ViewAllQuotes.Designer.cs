namespace MegaDesk_Hogge
{
    partial class ViewAllQuotes
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
            this.btnCloseViewAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseViewAllQuotes
            // 
            this.btnCloseViewAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseViewAllQuotes.Location = new System.Drawing.Point(330, 200);
            this.btnCloseViewAllQuotes.Name = "btnCloseViewAllQuotes";
            this.btnCloseViewAllQuotes.Size = new System.Drawing.Size(140, 50);
            this.btnCloseViewAllQuotes.TabIndex = 28;
            this.btnCloseViewAllQuotes.Text = "Close";
            this.btnCloseViewAllQuotes.UseVisualStyleBackColor = true;
            this.btnCloseViewAllQuotes.Click += new System.EventHandler(this.btnCloseViewAllQuotes_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseViewAllQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseViewAllQuotes;
    }
}