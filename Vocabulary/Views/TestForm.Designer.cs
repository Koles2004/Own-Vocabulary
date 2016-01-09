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
            this.radioButtonAllWords = new System.Windows.Forms.RadioButton();
            this.radioButtonExceptVerbs = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbs = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.radioButtonOnlyPhrasalVerbs = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbPut = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbTurn = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbGo = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbMake = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbTake = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbBe = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbKeep = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbLook = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlyVerbGet = new System.Windows.Forms.RadioButton();
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
            // 
            // buttonShowRussian
            // 
            this.buttonShowRussian.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowRussian.Location = new System.Drawing.Point(274, 121);
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
            this.buttonEnglishWord.Location = new System.Drawing.Point(30, 121);
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
            this.textBoxToEnglish.Location = new System.Drawing.Point(30, 391);
            this.textBoxToEnglish.Name = "textBoxToEnglish";
            this.textBoxToEnglish.ReadOnly = true;
            this.textBoxToEnglish.Size = new System.Drawing.Size(364, 26);
            this.textBoxToEnglish.TabIndex = 21;
            // 
            // textBoxFromRussian
            // 
            this.textBoxFromRussian.BackColor = System.Drawing.Color.White;
            this.textBoxFromRussian.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromRussian.Location = new System.Drawing.Point(30, 341);
            this.textBoxFromRussian.Name = "textBoxFromRussian";
            this.textBoxFromRussian.ReadOnly = true;
            this.textBoxFromRussian.Size = new System.Drawing.Size(364, 26);
            this.textBoxFromRussian.TabIndex = 20;
            // 
            // buttonShowEnglish
            // 
            this.buttonShowEnglish.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowEnglish.Location = new System.Drawing.Point(274, 448);
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
            this.buttonRussianWord.Location = new System.Drawing.Point(30, 448);
            this.buttonRussianWord.Name = "buttonRussianWord";
            this.buttonRussianWord.Size = new System.Drawing.Size(120, 62);
            this.buttonRussianWord.TabIndex = 22;
            this.buttonRussianWord.Text = "Russian word";
            this.buttonRussianWord.UseVisualStyleBackColor = true;
            this.buttonRussianWord.Click += new System.EventHandler(this.ChooseRussianWordHandler);
            // 
            // radioButtonAllWords
            // 
            this.radioButtonAllWords.AutoSize = true;
            this.radioButtonAllWords.Checked = true;
            this.radioButtonAllWords.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonAllWords.Location = new System.Drawing.Point(449, 35);
            this.radioButtonAllWords.Name = "radioButtonAllWords";
            this.radioButtonAllWords.Size = new System.Drawing.Size(96, 22);
            this.radioButtonAllWords.TabIndex = 26;
            this.radioButtonAllWords.TabStop = true;
            this.radioButtonAllWords.Text = "All words";
            this.radioButtonAllWords.UseVisualStyleBackColor = true;
            this.radioButtonAllWords.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonExceptVerbs
            // 
            this.radioButtonExceptVerbs.AutoSize = true;
            this.radioButtonExceptVerbs.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonExceptVerbs.Location = new System.Drawing.Point(449, 65);
            this.radioButtonExceptVerbs.Name = "radioButtonExceptVerbs";
            this.radioButtonExceptVerbs.Size = new System.Drawing.Size(122, 22);
            this.radioButtonExceptVerbs.TabIndex = 25;
            this.radioButtonExceptVerbs.Text = "Except verbs";
            this.radioButtonExceptVerbs.UseVisualStyleBackColor = true;
            this.radioButtonExceptVerbs.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbs
            // 
            this.radioButtonOnlyVerbs.AutoSize = true;
            this.radioButtonOnlyVerbs.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbs.Location = new System.Drawing.Point(449, 95);
            this.radioButtonOnlyVerbs.Name = "radioButtonOnlyVerbs";
            this.radioButtonOnlyVerbs.Size = new System.Drawing.Size(107, 22);
            this.radioButtonOnlyVerbs.TabIndex = 24;
            this.radioButtonOnlyVerbs.Text = "Only verbs";
            this.radioButtonOnlyVerbs.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbs.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(496, 448);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 62);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "Back";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // radioButtonOnlyPhrasalVerbs
            // 
            this.radioButtonOnlyPhrasalVerbs.AutoSize = true;
            this.radioButtonOnlyPhrasalVerbs.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyPhrasalVerbs.Location = new System.Drawing.Point(449, 125);
            this.radioButtonOnlyPhrasalVerbs.Name = "radioButtonOnlyPhrasalVerbs";
            this.radioButtonOnlyPhrasalVerbs.Size = new System.Drawing.Size(167, 22);
            this.radioButtonOnlyPhrasalVerbs.TabIndex = 28;
            this.radioButtonOnlyPhrasalVerbs.Text = "Only phrasal verbs";
            this.radioButtonOnlyPhrasalVerbs.UseVisualStyleBackColor = true;
            this.radioButtonOnlyPhrasalVerbs.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbPut
            // 
            this.radioButtonOnlyVerbPut.AutoSize = true;
            this.radioButtonOnlyVerbPut.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbPut.Location = new System.Drawing.Point(449, 275);
            this.radioButtonOnlyVerbPut.Name = "radioButtonOnlyVerbPut";
            this.radioButtonOnlyVerbPut.Size = new System.Drawing.Size(142, 22);
            this.radioButtonOnlyVerbPut.TabIndex = 46;
            this.radioButtonOnlyVerbPut.Text = "Only verb \"Put\"";
            this.radioButtonOnlyVerbPut.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbPut.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbTurn
            // 
            this.radioButtonOnlyVerbTurn.AutoSize = true;
            this.radioButtonOnlyVerbTurn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbTurn.Location = new System.Drawing.Point(449, 305);
            this.radioButtonOnlyVerbTurn.Name = "radioButtonOnlyVerbTurn";
            this.radioButtonOnlyVerbTurn.Size = new System.Drawing.Size(151, 22);
            this.radioButtonOnlyVerbTurn.TabIndex = 45;
            this.radioButtonOnlyVerbTurn.Text = "Only verb \"Turn\"";
            this.radioButtonOnlyVerbTurn.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbTurn.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbGo
            // 
            this.radioButtonOnlyVerbGo.AutoSize = true;
            this.radioButtonOnlyVerbGo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbGo.Location = new System.Drawing.Point(449, 335);
            this.radioButtonOnlyVerbGo.Name = "radioButtonOnlyVerbGo";
            this.radioButtonOnlyVerbGo.Size = new System.Drawing.Size(137, 22);
            this.radioButtonOnlyVerbGo.TabIndex = 44;
            this.radioButtonOnlyVerbGo.Text = "Only verb \"Go\"";
            this.radioButtonOnlyVerbGo.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbGo.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbMake
            // 
            this.radioButtonOnlyVerbMake.AutoSize = true;
            this.radioButtonOnlyVerbMake.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbMake.Location = new System.Drawing.Point(449, 365);
            this.radioButtonOnlyVerbMake.Name = "radioButtonOnlyVerbMake";
            this.radioButtonOnlyVerbMake.Size = new System.Drawing.Size(157, 22);
            this.radioButtonOnlyVerbMake.TabIndex = 43;
            this.radioButtonOnlyVerbMake.Text = "Only verb \"Make\"";
            this.radioButtonOnlyVerbMake.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbMake.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbTake
            // 
            this.radioButtonOnlyVerbTake.AutoSize = true;
            this.radioButtonOnlyVerbTake.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbTake.Location = new System.Drawing.Point(449, 395);
            this.radioButtonOnlyVerbTake.Name = "radioButtonOnlyVerbTake";
            this.radioButtonOnlyVerbTake.Size = new System.Drawing.Size(153, 22);
            this.radioButtonOnlyVerbTake.TabIndex = 42;
            this.radioButtonOnlyVerbTake.Text = "Only verb \"Take\"";
            this.radioButtonOnlyVerbTake.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbTake.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbBe
            // 
            this.radioButtonOnlyVerbBe.AutoSize = true;
            this.radioButtonOnlyVerbBe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbBe.Location = new System.Drawing.Point(449, 215);
            this.radioButtonOnlyVerbBe.Name = "radioButtonOnlyVerbBe";
            this.radioButtonOnlyVerbBe.Size = new System.Drawing.Size(136, 22);
            this.radioButtonOnlyVerbBe.TabIndex = 41;
            this.radioButtonOnlyVerbBe.Text = "Only verb \"Be\"";
            this.radioButtonOnlyVerbBe.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbBe.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbKeep
            // 
            this.radioButtonOnlyVerbKeep.AutoSize = true;
            this.radioButtonOnlyVerbKeep.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbKeep.Location = new System.Drawing.Point(449, 245);
            this.radioButtonOnlyVerbKeep.Name = "radioButtonOnlyVerbKeep";
            this.radioButtonOnlyVerbKeep.Size = new System.Drawing.Size(154, 22);
            this.radioButtonOnlyVerbKeep.TabIndex = 40;
            this.radioButtonOnlyVerbKeep.Text = "Only verb \"Keep\"";
            this.radioButtonOnlyVerbKeep.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbKeep.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbLook
            // 
            this.radioButtonOnlyVerbLook.AutoSize = true;
            this.radioButtonOnlyVerbLook.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbLook.Location = new System.Drawing.Point(449, 185);
            this.radioButtonOnlyVerbLook.Name = "radioButtonOnlyVerbLook";
            this.radioButtonOnlyVerbLook.Size = new System.Drawing.Size(153, 22);
            this.radioButtonOnlyVerbLook.TabIndex = 39;
            this.radioButtonOnlyVerbLook.Text = "Only verb \"Look\"";
            this.radioButtonOnlyVerbLook.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbLook.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // radioButtonOnlyVerbGet
            // 
            this.radioButtonOnlyVerbGet.AutoSize = true;
            this.radioButtonOnlyVerbGet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOnlyVerbGet.Location = new System.Drawing.Point(449, 155);
            this.radioButtonOnlyVerbGet.Name = "radioButtonOnlyVerbGet";
            this.radioButtonOnlyVerbGet.Size = new System.Drawing.Size(143, 22);
            this.radioButtonOnlyVerbGet.TabIndex = 38;
            this.radioButtonOnlyVerbGet.Text = "Only verb \"Get\"";
            this.radioButtonOnlyVerbGet.UseVisualStyleBackColor = true;
            this.radioButtonOnlyVerbGet.CheckedChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 539);
            this.Controls.Add(this.radioButtonOnlyVerbPut);
            this.Controls.Add(this.radioButtonOnlyVerbTurn);
            this.Controls.Add(this.radioButtonOnlyVerbGo);
            this.Controls.Add(this.radioButtonOnlyVerbMake);
            this.Controls.Add(this.radioButtonOnlyVerbTake);
            this.Controls.Add(this.radioButtonOnlyVerbBe);
            this.Controls.Add(this.radioButtonOnlyVerbKeep);
            this.Controls.Add(this.radioButtonOnlyVerbLook);
            this.Controls.Add(this.radioButtonOnlyVerbGet);
            this.Controls.Add(this.radioButtonOnlyPhrasalVerbs);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.radioButtonAllWords);
            this.Controls.Add(this.radioButtonExceptVerbs);
            this.Controls.Add(this.radioButtonOnlyVerbs);
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
        private System.Windows.Forms.RadioButton radioButtonAllWords;
        private System.Windows.Forms.RadioButton radioButtonExceptVerbs;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbs;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radioButtonOnlyPhrasalVerbs;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbPut;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbTurn;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbGo;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbMake;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbTake;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbBe;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbKeep;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbLook;
        private System.Windows.Forms.RadioButton radioButtonOnlyVerbGet;
    }
}