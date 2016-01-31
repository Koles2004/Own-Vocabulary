namespace Vocabulary.Views
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.textBoxFromEnglish = new System.Windows.Forms.TextBox();
            this.textBoxToRussian = new System.Windows.Forms.TextBox();
            this.buttonShowRussian = new System.Windows.Forms.Button();
            this.buttonEnglishWord = new System.Windows.Forms.Button();
            this.textBoxToEnglish = new System.Windows.Forms.TextBox();
            this.textBoxFromRussian = new System.Windows.Forms.TextBox();
            this.buttonShowEnglish = new System.Windows.Forms.Button();
            this.buttonRussianWord = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxWords = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxFromEnglish
            // 
            this.textBoxFromEnglish.BackColor = System.Drawing.Color.White;
            this.textBoxFromEnglish.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromEnglish.Location = new System.Drawing.Point(30, 35);
            this.textBoxFromEnglish.Name = "textBoxFromEnglish";
            this.textBoxFromEnglish.ReadOnly = true;
            this.textBoxFromEnglish.Size = new System.Drawing.Size(364, 26);
            this.textBoxFromEnglish.TabIndex = 17;
            this.textBoxFromEnglish.TabStop = false;
            // 
            // textBoxToRussian
            // 
            this.textBoxToRussian.BackColor = System.Drawing.Color.White;
            this.textBoxToRussian.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToRussian.Location = new System.Drawing.Point(30, 85);
            this.textBoxToRussian.Name = "textBoxToRussian";
            this.textBoxToRussian.ReadOnly = true;
            this.textBoxToRussian.Size = new System.Drawing.Size(364, 26);
            this.textBoxToRussian.TabIndex = 16;
            this.textBoxToRussian.TabStop = false;
            // 
            // buttonShowRussian
            // 
            this.buttonShowRussian.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowRussian.Location = new System.Drawing.Point(274, 120);
            this.buttonShowRussian.Name = "buttonShowRussian";
            this.buttonShowRussian.Size = new System.Drawing.Size(120, 62);
            this.buttonShowRussian.TabIndex = 19;
            this.buttonShowRussian.Text = "Show russian";
            this.buttonShowRussian.UseVisualStyleBackColor = true;
            this.buttonShowRussian.Click += new System.EventHandler(this.ShowRussianWordHandler);
            // 
            // buttonEnglishWord
            // 
            this.buttonEnglishWord.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnglishWord.Location = new System.Drawing.Point(30, 120);
            this.buttonEnglishWord.Name = "buttonEnglishWord";
            this.buttonEnglishWord.Size = new System.Drawing.Size(120, 62);
            this.buttonEnglishWord.TabIndex = 18;
            this.buttonEnglishWord.Text = "English word";
            this.buttonEnglishWord.UseVisualStyleBackColor = true;
            this.buttonEnglishWord.Click += new System.EventHandler(this.ChooseEnglishWordHandler);
            // 
            // textBoxToEnglish
            // 
            this.textBoxToEnglish.BackColor = System.Drawing.Color.White;
            this.textBoxToEnglish.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxToEnglish.Location = new System.Drawing.Point(30, 285);
            this.textBoxToEnglish.Name = "textBoxToEnglish";
            this.textBoxToEnglish.ReadOnly = true;
            this.textBoxToEnglish.Size = new System.Drawing.Size(364, 26);
            this.textBoxToEnglish.TabIndex = 21;
            this.textBoxToEnglish.TabStop = false;
            // 
            // textBoxFromRussian
            // 
            this.textBoxFromRussian.BackColor = System.Drawing.Color.White;
            this.textBoxFromRussian.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromRussian.Location = new System.Drawing.Point(30, 235);
            this.textBoxFromRussian.Name = "textBoxFromRussian";
            this.textBoxFromRussian.ReadOnly = true;
            this.textBoxFromRussian.Size = new System.Drawing.Size(364, 26);
            this.textBoxFromRussian.TabIndex = 20;
            this.textBoxFromRussian.TabStop = false;
            // 
            // buttonShowEnglish
            // 
            this.buttonShowEnglish.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowEnglish.Location = new System.Drawing.Point(274, 315);
            this.buttonShowEnglish.Name = "buttonShowEnglish";
            this.buttonShowEnglish.Size = new System.Drawing.Size(120, 62);
            this.buttonShowEnglish.TabIndex = 23;
            this.buttonShowEnglish.Text = "Show english";
            this.buttonShowEnglish.UseVisualStyleBackColor = true;
            this.buttonShowEnglish.Click += new System.EventHandler(this.ShowEnglishWordHandler);
            // 
            // buttonRussianWord
            // 
            this.buttonRussianWord.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRussianWord.Location = new System.Drawing.Point(30, 315);
            this.buttonRussianWord.Name = "buttonRussianWord";
            this.buttonRussianWord.Size = new System.Drawing.Size(120, 62);
            this.buttonRussianWord.TabIndex = 22;
            this.buttonRussianWord.Text = "Russian word";
            this.buttonRussianWord.UseVisualStyleBackColor = true;
            this.buttonRussianWord.Click += new System.EventHandler(this.ChooseRussianWordHandler);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(488, 315);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 62);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Back";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(460, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Choose words:";
            // 
            // comboBoxWords
            // 
            this.comboBoxWords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWords.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWords.FormattingEnabled = true;
            this.comboBoxWords.Location = new System.Drawing.Point(420, 35);
            this.comboBoxWords.Name = "comboBoxWords";
            this.comboBoxWords.Size = new System.Drawing.Size(187, 26);
            this.comboBoxWords.TabIndex = 30;
            this.comboBoxWords.SelectedIndexChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWords);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowEnglish);
            this.Controls.Add(this.buttonRussianWord);
            this.Controls.Add(this.textBoxToEnglish);
            this.Controls.Add(this.textBoxFromRussian);
            this.Controls.Add(this.buttonShowRussian);
            this.Controls.Add(this.buttonEnglishWord);
            this.Controls.Add(this.textBoxFromEnglish);
            this.Controls.Add(this.textBoxToRussian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.LoadedHandler);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFromEnglish;
        private System.Windows.Forms.TextBox textBoxToRussian;
        private System.Windows.Forms.Button buttonShowRussian;
        private System.Windows.Forms.Button buttonEnglishWord;
        private System.Windows.Forms.TextBox textBoxToEnglish;
        private System.Windows.Forms.TextBox textBoxFromRussian;
        private System.Windows.Forms.Button buttonShowEnglish;
        private System.Windows.Forms.Button buttonRussianWord;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxWords;
    }
}