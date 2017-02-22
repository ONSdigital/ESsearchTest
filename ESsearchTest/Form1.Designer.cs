namespace ESsearchTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtxSearchResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthCheckBox = new System.Windows.Forms.CheckBox();
            this.URITextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.tbxName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(26, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 214);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(222, 65);
            this.tbxName.Margin = new System.Windows.Forms.Padding(6);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(338, 29);
            this.tbxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 113);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(341, 66);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rtxSearchResult
            // 
            this.rtxSearchResult.Location = new System.Drawing.Point(27, 419);
            this.rtxSearchResult.Margin = new System.Windows.Forms.Padding(6);
            this.rtxSearchResult.Name = "rtxSearchResult";
            this.rtxSearchResult.Size = new System.Drawing.Size(602, 528);
            this.rtxSearchResult.TabIndex = 27;
            this.rtxSearchResult.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search Result:";
            // 
            // AuthCheckBox
            // 
            this.AuthCheckBox.AutoSize = true;
            this.AuthCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AuthCheckBox.Location = new System.Drawing.Point(181, 54);
            this.AuthCheckBox.Name = "AuthCheckBox";
            this.AuthCheckBox.Size = new System.Drawing.Size(90, 29);
            this.AuthCheckBox.TabIndex = 29;
            this.AuthCheckBox.Text = "Auth: ";
            this.AuthCheckBox.UseVisualStyleBackColor = true;
            this.AuthCheckBox.CheckedChanged += new System.EventHandler(this.some_TextChanged);
            this.AuthCheckBox.EnabledChanged += new System.EventHandler(this.some_TextChanged);
            // 
            // URITextBox
            // 
            this.URITextBox.Location = new System.Drawing.Point(245, 13);
            this.URITextBox.Name = "URITextBox";
            this.URITextBox.Size = new System.Drawing.Size(338, 29);
            this.URITextBox.TabIndex = 30;
            this.URITextBox.TextChanged += new System.EventHandler(this.some_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(244, 118);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(338, 29);
            this.PasswordTextBox.TabIndex = 31;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.some_TextChanged);
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(244, 83);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(338, 29);
            this.UserTextBox.TabIndex = 32;
            this.UserTextBox.TextChanged += new System.EventHandler(this.some_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Elastic Search URI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Password:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 988);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.URITextBox);
            this.Controls.Add(this.AuthCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxSearchResult);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Elasticsearch Search Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtxSearchResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AuthCheckBox;
        private System.Windows.Forms.TextBox URITextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

