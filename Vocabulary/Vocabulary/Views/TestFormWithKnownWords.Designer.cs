namespace Vocabulary.Views
{
    partial class TestFormWithKnownWords
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
            this.comboBoxWords = new System.Windows.Forms.ComboBox();
            this.buttonShowRussian = new System.Windows.Forms.Button();
            this.buttonEnglishWord = new System.Windows.Forms.Button();
            this.textBoxFromEnglish = new System.Windows.Forms.TextBox();
            this.textBoxToRussian = new System.Windows.Forms.TextBox();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.buttonWrong = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountOfTranslations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(738, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Choose words:";
            // 
            // comboBoxWords
            // 
            this.comboBoxWords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWords.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWords.FormattingEnabled = true;
            this.comboBoxWords.Location = new System.Drawing.Point(698, 34);
            this.comboBoxWords.Name = "comboBoxWords";
            this.comboBoxWords.Size = new System.Drawing.Size(187, 26);
            this.comboBoxWords.TabIndex = 34;
            this.comboBoxWords.SelectedIndexChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // buttonShowRussian
            // 
            this.buttonShowRussian.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowRussian.Location = new System.Drawing.Point(515, 119);
            this.buttonShowRussian.Name = "buttonShowRussian";
            this.buttonShowRussian.Size = new System.Drawing.Size(120, 62);
            this.buttonShowRussian.TabIndex = 33;
            this.buttonShowRussian.Text = "Show russian";
            this.buttonShowRussian.UseVisualStyleBackColor = true;
            this.buttonShowRussian.Click += new System.EventHandler(this.ShowRussianWordHandler);
            // 
            // buttonEnglishWord
            // 
            this.buttonEnglishWord.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnglishWord.Location = new System.Drawing.Point(30, 119);
            this.buttonEnglishWord.Name = "buttonEnglishWord";
            this.buttonEnglishWord.Size = new System.Drawing.Size(120, 62);
            this.buttonEnglishWord.TabIndex = 32;
            this.buttonEnglishWord.Text = "English word";
            this.buttonEnglishWord.UseVisualStyleBackColor = true;
            this.buttonEnglishWord.Click += new System.EventHandler(this.ChooseEnglishWordHandler);
            // 
            // textBoxFromEnglish
            // 
            this.textBoxFromEnglish.BackColor = System.Drawing.Color.White;
            this.textBoxFromEnglish.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromEnglish.Location = new System.Drawing.Point(30, 34);
            this.textBoxFromEnglish.Name = "textBoxFromEnglish";
            this.textBoxFromEnglish.ReadOnly = true;
            this.textBoxFromEnglish.Size = new System.Drawing.Size(605, 26);
            this.textBoxFromEnglish.TabIndex = 31;
            this.textBoxFromEnglish.TabStop = false;
            // 
            // textBoxToRussian
            // 
            this.textBoxToRussian.BackColor = System.Drawing.Color.White;
            this.textBoxToRussian.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToRussian.Location = new System.Drawing.Point(30, 84);
            this.textBoxToRussian.Name = "textBoxToRussian";
            this.textBoxToRussian.ReadOnly = true;
            this.textBoxToRussian.Size = new System.Drawing.Size(605, 26);
            this.textBoxToRussian.TabIndex = 30;
            this.textBoxToRussian.TabStop = false;
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.Enabled = false;
            this.buttonCorrect.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCorrect.Location = new System.Drawing.Point(30, 228);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(120, 62);
            this.buttonCorrect.TabIndex = 36;
            this.buttonCorrect.Text = "Correct";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.CorrectAnswerHandler);
            // 
            // buttonWrong
            // 
            this.buttonWrong.Enabled = false;
            this.buttonWrong.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWrong.Location = new System.Drawing.Point(515, 228);
            this.buttonWrong.Name = "buttonWrong";
            this.buttonWrong.Size = new System.Drawing.Size(120, 62);
            this.buttonWrong.TabIndex = 37;
            this.buttonWrong.Text = "Wrong";
            this.buttonWrong.UseVisualStyleBackColor = true;
            this.buttonWrong.Click += new System.EventHandler(this.WrongAnswerHandler);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(877, 326);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 62);
            this.buttonExit.TabIndex = 38;
            this.buttonExit.Text = "Back";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(891, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Translations:";
            // 
            // labelCountOfTranslations
            // 
            this.labelCountOfTranslations.AutoSize = true;
            this.labelCountOfTranslations.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountOfTranslations.Location = new System.Drawing.Point(997, 34);
            this.labelCountOfTranslations.Name = "labelCountOfTranslations";
            this.labelCountOfTranslations.Size = new System.Drawing.Size(0, 18);
            this.labelCountOfTranslations.TabIndex = 40;
            // 
            // TestFormWithKnownWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 416);
            this.Controls.Add(this.labelCountOfTranslations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonWrong);
            this.Controls.Add(this.buttonCorrect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWords);
            this.Controls.Add(this.buttonShowRussian);
            this.Controls.Add(this.buttonEnglishWord);
            this.Controls.Add(this.textBoxFromEnglish);
            this.Controls.Add(this.textBoxToRussian);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestFormWithKnownWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestFormWithKnownWords";
            this.Load += new System.EventHandler(this.LoadedHandler);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWords;
        private System.Windows.Forms.Button buttonShowRussian;
        private System.Windows.Forms.Button buttonEnglishWord;
        private System.Windows.Forms.TextBox textBoxFromEnglish;
        private System.Windows.Forms.TextBox textBoxToRussian;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Button buttonWrong;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountOfTranslations;
    }
}