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
            this.StringSpanButton = new System.Windows.Forms.Button();
            this.SliceButton = new System.Windows.Forms.Button();
            this.StackButton = new System.Windows.Forms.Button();
            this.UnsafeButton = new System.Windows.Forms.Button();
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
            // StringSpanButton
            // 
            this.StringSpanButton.Location = new System.Drawing.Point(597, 143);
            this.StringSpanButton.Name = "StringSpanButton";
            this.StringSpanButton.Size = new System.Drawing.Size(161, 40);
            this.StringSpanButton.TabIndex = 2;
            this.StringSpanButton.Text = "String Span";
            this.StringSpanButton.UseVisualStyleBackColor = true;
            this.StringSpanButton.Click += new System.EventHandler(this.StringSpanButton_Click);
            // 
            // SliceButton
            // 
            this.SliceButton.Location = new System.Drawing.Point(531, 230);
            this.SliceButton.Name = "SliceButton";
            this.SliceButton.Size = new System.Drawing.Size(161, 40);
            this.SliceButton.TabIndex = 3;
            this.SliceButton.Text = "Slice";
            this.SliceButton.UseVisualStyleBackColor = true;
            this.SliceButton.Click += new System.EventHandler(this.SliceButton_Click);
            // 
            // StackButton
            // 
            this.StackButton.Location = new System.Drawing.Point(531, 328);
            this.StackButton.Name = "StackButton";
            this.StackButton.Size = new System.Drawing.Size(161, 40);
            this.StackButton.TabIndex = 4;
            this.StackButton.Text = "Stack";
            this.StackButton.UseVisualStyleBackColor = true;
            this.StackButton.Click += new System.EventHandler(this.StackButton_Click);
            // 
            // UnsafeButton
            // 
            this.UnsafeButton.Location = new System.Drawing.Point(532, 189);
            this.UnsafeButton.Name = "UnsafeButton";
            this.UnsafeButton.Size = new System.Drawing.Size(161, 40);
            this.UnsafeButton.TabIndex = 5;
            this.UnsafeButton.Text = "Unsafe";
            this.UnsafeButton.UseVisualStyleBackColor = true;
            this.UnsafeButton.Click += new System.EventHandler(this.UnsafeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UnsafeButton);
            this.Controls.Add(this.StackButton);
            this.Controls.Add(this.SliceButton);
            this.Controls.Add(this.StringSpanButton);
            this.Controls.Add(this.ArrayButton);
            this.Controls.Add(this.DisplayListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Button ArrayButton;
        private System.Windows.Forms.Button StringSpanButton;
        private System.Windows.Forms.Button SliceButton;
        private System.Windows.Forms.Button StackButton;
        private System.Windows.Forms.Button UnsafeButton;
    }
}

