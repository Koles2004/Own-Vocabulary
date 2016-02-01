namespace Vocabulary.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnEnglishWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTranslation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxEnglishWord = new System.Windows.Forms.TextBox();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenTest = new System.Windows.Forms.Button();
            this.superTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEnglishWord,
            this.columnTranslation});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(30, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(556, 370);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // columnEnglishWord
            // 
            this.columnEnglishWord.Text = "EnglishWord";
            this.columnEnglishWord.Width = 250;
            // 
            // columnTranslation
            // 
            this.columnTranslation.Text = "Translation";
            this.columnTranslation.Width = 300;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(621, 25);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 62);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddHandler);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(621, 119);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 62);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.EditHandler);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(621, 221);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 62);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteHandler);
            // 
            // textBoxEnglishWord
            // 
            this.textBoxEnglishWord.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnglishWord.Location = new System.Drawing.Point(141, 431);
            this.textBoxEnglishWord.Name = "textBoxEnglishWord";
            this.textBoxEnglishWord.Size = new System.Drawing.Size(445, 26);
            this.textBoxEnglishWord.TabIndex = 5;
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTranslation.Location = new System.Drawing.Point(141, 492);
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(445, 26);
            this.textBoxTranslation.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter word:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTranslate.Location = new System.Drawing.Point(621, 333);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(120, 62);
            this.buttonTranslate.TabIndex = 8;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.TranslateHandler);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Translation:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.testToolStripMenuItem,
            this.superTestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.OpenTestFormHandler);
            // 
            // buttonOpenTest
            // 
            this.buttonOpenTest.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenTest.Location = new System.Drawing.Point(621, 431);
            this.buttonOpenTest.Name = "buttonOpenTest";
            this.buttonOpenTest.Size = new System.Drawing.Size(120, 62);
            this.buttonOpenTest.TabIndex = 11;
            this.buttonOpenTest.Text = "Open test";
            this.buttonOpenTest.UseVisualStyleBackColor = true;
            this.buttonOpenTest.Click += new System.EventHandler(this.OpenTestFormHandler);
            // 
            // superTestToolStripMenuItem
            // 
            this.superTestToolStripMenuItem.Name = "superTestToolStripMenuItem";
            this.superTestToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.superTestToolStripMenuItem.Text = "SuperTest";
            this.superTestToolStripMenuItem.Click += new System.EventHandler(this.OpenSuperTestFormHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 538);
            this.Controls.Add(this.buttonOpenTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTranslation);
            this.Controls.Add(this.textBoxEnglishWord);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.LoadedHandler);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnEnglishWord;
        private System.Windows.Forms.ColumnHeader columnTranslation;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxEnglishWord;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpenTest;
        private System.Windows.Forms.ToolStripMenuItem superTestToolStripMenuItem;
    }
}