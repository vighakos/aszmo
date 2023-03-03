
namespace szokitalaloka
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
            this.wordLbl = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.guessLbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newWordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordLbl
            // 
            this.wordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wordLbl.Location = new System.Drawing.Point(12, 9);
            this.wordLbl.Name = "wordLbl";
            this.wordLbl.Size = new System.Drawing.Size(238, 55);
            this.wordLbl.TabIndex = 0;
            this.wordLbl.Text = "????????";
            this.wordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userInput.Location = new System.Drawing.Point(12, 67);
            this.userInput.MaxLength = 8;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(238, 44);
            this.userInput.TabIndex = 1;
            this.userInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userInput_KeyUp);
            // 
            // guessLbox
            // 
            this.guessLbox.FormattingEnabled = true;
            this.guessLbox.Location = new System.Drawing.Point(12, 118);
            this.guessLbox.Name = "guessLbox";
            this.guessLbox.Size = new System.Drawing.Size(238, 225);
            this.guessLbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "????????";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newWordBtn
            // 
            this.newWordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newWordBtn.Location = new System.Drawing.Point(12, 349);
            this.newWordBtn.Name = "newWordBtn";
            this.newWordBtn.Size = new System.Drawing.Size(238, 45);
            this.newWordBtn.TabIndex = 4;
            this.newWordBtn.Text = "New word";
            this.newWordBtn.UseVisualStyleBackColor = true;
            this.newWordBtn.Click += new System.EventHandler(this.newWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 459);
            this.Controls.Add(this.newWordBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessLbox);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.wordLbl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitalálóka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.ListBox guessLbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newWordBtn;
    }
}

