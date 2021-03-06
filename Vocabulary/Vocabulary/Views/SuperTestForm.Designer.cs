﻿namespace Vocabulary.Views
{
    partial class SuperTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperTestForm));
            this.radioButtonVariant1 = new System.Windows.Forms.RadioButton();
            this.radioButtonVariant2 = new System.Windows.Forms.RadioButton();
            this.radioButtonVariant3 = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxFromEnglish = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxWords = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonVariant1
            // 
            this.radioButtonVariant1.AutoSize = true;
            this.radioButtonVariant1.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonVariant1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVariant1.Location = new System.Drawing.Point(32, 22);
            this.radioButtonVariant1.Name = "radioButtonVariant1";
            this.radioButtonVariant1.Size = new System.Drawing.Size(14, 13);
            this.radioButtonVariant1.TabIndex = 31;
            this.radioButtonVariant1.UseVisualStyleBackColor = false;
            this.radioButtonVariant1.Visible = false;
            this.radioButtonVariant1.CheckedChanged += new System.EventHandler(this.radioButtonVariant1_CheckedChanged);
            // 
            // radioButtonVariant2
            // 
            this.radioButtonVariant2.AutoSize = true;
            this.radioButtonVariant2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonVariant2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVariant2.Location = new System.Drawing.Point(32, 72);
            this.radioButtonVariant2.Name = "radioButtonVariant2";
            this.radioButtonVariant2.Size = new System.Drawing.Size(14, 13);
            this.radioButtonVariant2.TabIndex = 32;
            this.radioButtonVariant2.UseVisualStyleBackColor = false;
            this.radioButtonVariant2.Visible = false;
            this.radioButtonVariant2.CheckedChanged += new System.EventHandler(this.radioButtonVariant1_CheckedChanged);
            // 
            // radioButtonVariant3
            // 
            this.radioButtonVariant3.AutoSize = true;
            this.radioButtonVariant3.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonVariant3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonVariant3.Location = new System.Drawing.Point(32, 124);
            this.radioButtonVariant3.Name = "radioButtonVariant3";
            this.radioButtonVariant3.Size = new System.Drawing.Size(14, 13);
            this.radioButtonVariant3.TabIndex = 33;
            this.radioButtonVariant3.UseVisualStyleBackColor = false;
            this.radioButtonVariant3.Visible = false;
            this.radioButtonVariant3.CheckedChanged += new System.EventHandler(this.radioButtonVariant1_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(404, 400);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(143, 42);
            this.buttonStart.TabIndex = 34;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.StartTestHandler);
            // 
            // textBoxFromEnglish
            // 
            this.textBoxFromEnglish.BackColor = System.Drawing.Color.White;
            this.textBoxFromEnglish.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFromEnglish.Location = new System.Drawing.Point(31, 100);
            this.textBoxFromEnglish.Name = "textBoxFromEnglish";
            this.textBoxFromEnglish.ReadOnly = true;
            this.textBoxFromEnglish.Size = new System.Drawing.Size(516, 26);
            this.textBoxFromEnglish.TabIndex = 35;
            this.textBoxFromEnglish.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonVariant2);
            this.groupBox1.Controls.Add(this.radioButtonVariant1);
            this.groupBox1.Controls.Add(this.radioButtonVariant3);
            this.groupBox1.Location = new System.Drawing.Point(31, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 162);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Enabled = false;
            this.buttonAnswer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer.Location = new System.Drawing.Point(31, 400);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(143, 42);
            this.buttonAnswer.TabIndex = 39;
            this.buttonAnswer.Text = "Answer";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.AnswerHandler);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(31, 37);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 40;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Count of questions:";
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(208, 400);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(143, 42);
            this.buttonNext.TabIndex = 49;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.NextHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(584, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Choose words:";
            // 
            // comboBoxWords
            // 
            this.comboBoxWords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWords.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxWords.FormattingEnabled = true;
            this.comboBoxWords.Location = new System.Drawing.Point(587, 61);
            this.comboBoxWords.Name = "comboBoxWords";
            this.comboBoxWords.Size = new System.Drawing.Size(187, 26);
            this.comboBoxWords.TabIndex = 50;
            this.comboBoxWords.SelectedIndexChanged += new System.EventHandler(this.ChooseNeededWordsHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "English word:";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(631, 400);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(143, 42);
            this.buttonClose.TabIndex = 53;
            this.buttonClose.Text = "Back";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SuperTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxWords);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxFromEnglish);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuperTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SuperTestForm";
            this.Load += new System.EventHandler(this.LoadedHandler);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonVariant1;
        private System.Windows.Forms.RadioButton radioButtonVariant2;
        private System.Windows.Forms.RadioButton radioButtonVariant3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxFromEnglish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClose;
    }
}