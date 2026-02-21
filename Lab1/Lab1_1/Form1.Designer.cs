namespace Lab1_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswersBox = new System.Windows.Forms.TextBox();
            this.SaveAnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.QuestionLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(246, 81);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(277, 21);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Яку останню книгу ти прочитав?";
            // 
            // AnswersBox
            // 
            this.AnswersBox.BackColor = System.Drawing.SystemColors.Info;
            this.AnswersBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswersBox.Location = new System.Drawing.Point(217, 179);
            this.AnswersBox.Name = "AnswersBox";
            this.AnswersBox.Size = new System.Drawing.Size(339, 29);
            this.AnswersBox.TabIndex = 1;
            // 
            // SaveAnswerButton
            // 
            this.SaveAnswerButton.BackColor = System.Drawing.SystemColors.Window;
            this.SaveAnswerButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAnswerButton.Location = new System.Drawing.Point(322, 261);
            this.SaveAnswerButton.Name = "SaveAnswerButton";
            this.SaveAnswerButton.Size = new System.Drawing.Size(137, 48);
            this.SaveAnswerButton.TabIndex = 2;
            this.SaveAnswerButton.Text = "Тиць";
            this.SaveAnswerButton.UseVisualStyleBackColor = false;
            this.SaveAnswerButton.Click += new System.EventHandler(this.SaveAnswerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveAnswerButton);
            this.Controls.Add(this.AnswersBox);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.TextBox AnswersBox;
        private System.Windows.Forms.Button SaveAnswerButton;
    }
}

