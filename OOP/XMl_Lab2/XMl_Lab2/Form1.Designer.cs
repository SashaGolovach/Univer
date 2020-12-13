namespace XMl_Lab2
{
    partial class XmlSearch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextOut = new System.Windows.Forms.RichTextBox();
            this.checkBoxGenre = new System.Windows.Forms.CheckBox();
            this.checkBoxStudio = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.comboStudio = new System.Windows.Forms.ComboBox();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.radioSAX = new System.Windows.Forms.RadioButton();
            this.radioDOM = new System.Windows.Forms.RadioButton();
            this.radioLINQ = new System.Windows.Forms.RadioButton();
            this.buttonHtml = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextOut
            // 
            this.TextOut.BackColor = System.Drawing.Color.Black;
            this.TextOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.TextOut.ForeColor = System.Drawing.Color.Ivory;
            this.TextOut.Location = new System.Drawing.Point(286, 0);
            this.TextOut.Margin = new System.Windows.Forms.Padding(2);
            this.TextOut.MinimumSize = new System.Drawing.Size(315, 440);
            this.TextOut.Name = "TextOut";
            this.TextOut.ReadOnly = true;
            this.TextOut.Size = new System.Drawing.Size(315, 440);
            this.TextOut.TabIndex = 0;
            this.TextOut.Text = "";
            // 
            // checkBoxGenre
            // 
            this.checkBoxGenre.AutoSize = true;
            this.checkBoxGenre.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxGenre.ForeColor = System.Drawing.Color.Black;
            this.checkBoxGenre.Location = new System.Drawing.Point(22, 26);
            this.checkBoxGenre.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGenre.Name = "checkBoxGenre";
            this.checkBoxGenre.Size = new System.Drawing.Size(73, 22);
            this.checkBoxGenre.TabIndex = 1;
            this.checkBoxGenre.Text = "Genre";
            this.checkBoxGenre.UseVisualStyleBackColor = true;
            // 
            // checkBoxStudio
            // 
            this.checkBoxStudio.AutoSize = true;
            this.checkBoxStudio.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxStudio.ForeColor = System.Drawing.Color.Black;
            this.checkBoxStudio.Location = new System.Drawing.Point(22, 64);
            this.checkBoxStudio.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxStudio.Name = "checkBoxStudio";
            this.checkBoxStudio.Size = new System.Drawing.Size(77, 22);
            this.checkBoxStudio.TabIndex = 2;
            this.checkBoxStudio.Text = "Studio";
            this.checkBoxStudio.UseVisualStyleBackColor = true;
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxName.ForeColor = System.Drawing.Color.Black;
            this.checkBoxName.Location = new System.Drawing.Point(22, 104);
            this.checkBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(72, 22);
            this.checkBoxName.TabIndex = 3;
            this.checkBoxName.Text = "Name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxYear.ForeColor = System.Drawing.Color.Black;
            this.checkBoxYear.Location = new System.Drawing.Point(24, 140);
            this.checkBoxYear.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(64, 22);
            this.checkBoxYear.TabIndex = 4;
            this.checkBoxYear.Text = "Year";
            this.checkBoxYear.UseVisualStyleBackColor = true;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTime.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTime.Location = new System.Drawing.Point(20, 178);
            this.checkBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(66, 22);
            this.checkBoxTime.TabIndex = 5;
            this.checkBoxTime.Text = "Time";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // comboGenre
            // 
            this.comboGenre.BackColor = System.Drawing.Color.Ivory;
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.ForeColor = System.Drawing.Color.Black;
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(130, 23);
            this.comboGenre.Margin = new System.Windows.Forms.Padding(2);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(116, 23);
            this.comboGenre.TabIndex = 6;
            // 
            // comboStudio
            // 
            this.comboStudio.BackColor = System.Drawing.Color.Ivory;
            this.comboStudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStudio.ForeColor = System.Drawing.Color.Black;
            this.comboStudio.FormattingEnabled = true;
            this.comboStudio.Location = new System.Drawing.Point(129, 62);
            this.comboStudio.Margin = new System.Windows.Forms.Padding(2);
            this.comboStudio.Name = "comboStudio";
            this.comboStudio.Size = new System.Drawing.Size(116, 23);
            this.comboStudio.TabIndex = 7;
            // 
            // comboName
            // 
            this.comboName.BackColor = System.Drawing.Color.Ivory;
            this.comboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboName.ForeColor = System.Drawing.Color.Black;
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(130, 101);
            this.comboName.Margin = new System.Windows.Forms.Padding(2);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(116, 23);
            this.comboName.TabIndex = 8;
            // 
            // comboYear
            // 
            this.comboYear.BackColor = System.Drawing.Color.Ivory;
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.ForeColor = System.Drawing.Color.Black;
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(130, 138);
            this.comboYear.Margin = new System.Windows.Forms.Padding(2);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(116, 23);
            this.comboYear.TabIndex = 9;
            // 
            // comboTime
            // 
            this.comboTime.BackColor = System.Drawing.Color.Ivory;
            this.comboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTime.ForeColor = System.Drawing.Color.Black;
            this.comboTime.FormattingEnabled = true;
            this.comboTime.Location = new System.Drawing.Point(129, 175);
            this.comboTime.Margin = new System.Windows.Forms.Padding(2);
            this.comboTime.Name = "comboTime";
            this.comboTime.Size = new System.Drawing.Size(116, 23);
            this.comboTime.TabIndex = 10;
            // 
            // radioSAX
            // 
            this.radioSAX.AutoSize = true;
            this.radioSAX.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioSAX.ForeColor = System.Drawing.Color.Black;
            this.radioSAX.Location = new System.Drawing.Point(20, 218);
            this.radioSAX.Margin = new System.Windows.Forms.Padding(2);
            this.radioSAX.Name = "radioSAX";
            this.radioSAX.Size = new System.Drawing.Size(59, 22);
            this.radioSAX.TabIndex = 11;
            this.radioSAX.TabStop = true;
            this.radioSAX.Text = "SAX";
            this.radioSAX.UseVisualStyleBackColor = true;
            // 
            // radioDOM
            // 
            this.radioDOM.AutoSize = true;
            this.radioDOM.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioDOM.ForeColor = System.Drawing.Color.Black;
            this.radioDOM.Location = new System.Drawing.Point(104, 218);
            this.radioDOM.Margin = new System.Windows.Forms.Padding(2);
            this.radioDOM.Name = "radioDOM";
            this.radioDOM.Size = new System.Drawing.Size(65, 22);
            this.radioDOM.TabIndex = 12;
            this.radioDOM.TabStop = true;
            this.radioDOM.Text = "DOM";
            this.radioDOM.UseVisualStyleBackColor = true;
            // 
            // radioLINQ
            // 
            this.radioLINQ.AutoSize = true;
            this.radioLINQ.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioLINQ.ForeColor = System.Drawing.Color.Black;
            this.radioLINQ.Location = new System.Drawing.Point(185, 218);
            this.radioLINQ.Margin = new System.Windows.Forms.Padding(2);
            this.radioLINQ.Name = "radioLINQ";
            this.radioLINQ.Size = new System.Drawing.Size(70, 22);
            this.radioLINQ.TabIndex = 13;
            this.radioLINQ.TabStop = true;
            this.radioLINQ.Text = "LINQ";
            this.radioLINQ.UseVisualStyleBackColor = true;
            // 
            // buttonHtml
            // 
            this.buttonHtml.BackColor = System.Drawing.Color.Black;
            this.buttonHtml.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHtml.ForeColor = System.Drawing.Color.Ivory;
            this.buttonHtml.Location = new System.Drawing.Point(1, 326);
            this.buttonHtml.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHtml.Name = "buttonHtml";
            this.buttonHtml.Size = new System.Drawing.Size(97, 26);
            this.buttonHtml.TabIndex = 14;
            this.buttonHtml.Text = "HTML";
            this.buttonHtml.UseVisualStyleBackColor = false;
            this.buttonHtml.Click += new System.EventHandler(this.buttonHtml_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Black;
            this.buttonClear.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.Ivory;
            this.buttonClear.Location = new System.Drawing.Point(1, 356);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 28);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Black;
            this.Search.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.Color.Ivory;
            this.Search.Location = new System.Drawing.Point(1, 296);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(74, 26);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // XmlSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 438);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHtml);
            this.Controls.Add(this.radioLINQ);
            this.Controls.Add(this.radioDOM);
            this.Controls.Add(this.radioSAX);
            this.Controls.Add(this.comboTime);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.comboStudio);
            this.Controls.Add(this.comboGenre);
            this.Controls.Add(this.checkBoxTime);
            this.Controls.Add(this.checkBoxYear);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.checkBoxStudio);
            this.Controls.Add(this.checkBoxGenre);
            this.Controls.Add(this.TextOut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(619, 482);
            this.Name = "XmlSearch";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.XmlSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextOut;
        private System.Windows.Forms.CheckBox checkBoxGenre;
        private System.Windows.Forms.CheckBox checkBoxStudio;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.ComboBox comboStudio;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.RadioButton radioSAX;
        private System.Windows.Forms.RadioButton radioDOM;
        private System.Windows.Forms.RadioButton radioLINQ;
        private System.Windows.Forms.Button buttonHtml;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button Search;
    }
}

