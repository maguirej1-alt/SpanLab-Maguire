namespace SpanLab
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
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.ArrayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.ItemHeight = 20;
            this.DisplayListBox.Location = new System.Drawing.Point(12, 30);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(514, 384);
            this.DisplayListBox.TabIndex = 0;
            // 
            // ArrayButton
            // 
            this.ArrayButton.Location = new System.Drawing.Point(597, 71);
            this.ArrayButton.Name = "ArrayButton";
            this.ArrayButton.Size = new System.Drawing.Size(95, 44);
            this.ArrayButton.TabIndex = 1;
            this.ArrayButton.Text = "Array";
            this.ArrayButton.UseVisualStyleBackColor = true;
            this.ArrayButton.Click += new System.EventHandler(this.ArrayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ArrayButton);
            this.Controls.Add(this.DisplayListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Button ArrayButton;
    }
}

