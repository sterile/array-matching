namespace array_matching
{
    partial class Lab7
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
            this.wpmInput = new System.Windows.Forms.TextBox();
            this.gradeLabelStatic = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.gradeLetterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Words Per Minute (WPM)";
            // 
            // wpmInput
            // 
            this.wpmInput.Location = new System.Drawing.Point(146, 10);
            this.wpmInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wpmInput.Name = "wpmInput";
            this.wpmInput.Size = new System.Drawing.Size(52, 20);
            this.wpmInput.TabIndex = 1;
            // 
            // gradeLabelStatic
            // 
            this.gradeLabelStatic.AutoSize = true;
            this.gradeLabelStatic.Location = new System.Drawing.Point(60, 36);
            this.gradeLabelStatic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gradeLabelStatic.Name = "gradeLabelStatic";
            this.gradeLabelStatic.Size = new System.Drawing.Size(85, 13);
            this.gradeLabelStatic.TabIndex = 2;
            this.gradeLabelStatic.Text = "Grade Received";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(40, 58);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(142, 26);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Student Grade";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // gradeLetterLabel
            // 
            this.gradeLetterLabel.AutoSize = true;
            this.gradeLetterLabel.Location = new System.Drawing.Point(146, 36);
            this.gradeLetterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gradeLetterLabel.Name = "gradeLetterLabel";
            this.gradeLetterLabel.Size = new System.Drawing.Size(33, 13);
            this.gradeLetterLabel.TabIndex = 4;
            this.gradeLetterLabel.Text = "None";
            // 
            // Lab7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 90);
            this.Controls.Add(this.gradeLetterLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.gradeLabelStatic);
            this.Controls.Add(this.wpmInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lab7";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wpmInput;
        private System.Windows.Forms.Label gradeLabelStatic;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label gradeLetterLabel;
    }
}

