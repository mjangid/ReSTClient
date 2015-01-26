namespace ReSTClient
{
    partial class FrmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xmlView = new System.Windows.Forms.WebBrowser();
            this.tabGridView = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewHeader = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeader)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(844, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSend);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GET",
            "PUT",
            "POST",
            "DELETE",
            "INTERNET"});
            this.comboBox1.Location = new System.Drawing.Point(17, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // txtURI
            // 
            this.txtURI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURI.Location = new System.Drawing.Point(203, 17);
            this.txtURI.Margin = new System.Windows.Forms.Padding(4);
            this.txtURI.Multiline = true;
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(609, 43);
            this.txtURI.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabGridView);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(17, 69);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 513);
            this.tabControl1.TabIndex = 3;
            
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(939, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Raw Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(936, 478);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(939, 481);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Links";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.xmlView);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(939, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML View";
            this.tabPage2.UseVisualStyleBackColor = true;
            
            // 
            // xmlView
            // 
            this.xmlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlView.Location = new System.Drawing.Point(4, 4);
            this.xmlView.Margin = new System.Windows.Forms.Padding(4);
            this.xmlView.MinimumSize = new System.Drawing.Size(27, 25);
            this.xmlView.Name = "xmlView";
            this.xmlView.Size = new System.Drawing.Size(931, 473);
            this.xmlView.TabIndex = 0;
            // 
            // tabGridView
            // 
            this.tabGridView.Location = new System.Drawing.Point(4, 28);
            this.tabGridView.Name = "tabGridView";
            this.tabGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabGridView.Size = new System.Drawing.Size(939, 481);
            this.tabGridView.TabIndex = 8;
            this.tabGridView.Text = "Grid View";
            this.tabGridView.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPassword);
            this.tabPage3.Controls.Add(this.txtUserName);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(939, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Authentication";
            this.tabPage3.UseVisualStyleBackColor = true;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(180, 87);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(180, 50);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(315, 22);
            this.txtUserName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewHeader);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(939, 481);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Headers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHeader
            // 
            this.dataGridViewHeader.AllowUserToOrderColumns = true;
            this.dataGridViewHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHeader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeader,
            this.colValue});
            this.dataGridViewHeader.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewHeader.Name = "dataGridViewHeader";
            this.dataGridViewHeader.Size = new System.Drawing.Size(943, 485);
            this.dataGridViewHeader.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(939, 481);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "OAuth";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.linkLabel3);
            this.tabPage8.Controls.Add(this.linkLabel2);
            this.tabPage8.Controls.Add(this.linkLabel1);
            this.tabPage8.Location = new System.Drawing.Point(4, 28);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(939, 481);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Sample Request";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(22, 103);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(307, 16);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Tag = "m3";
            this.linkLabel3.Text = "http://www.thomas-bayer.com/sqlrest/CUSTOMER";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetLink);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(22, 65);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(422, 16);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Tag = "m2";
            this.linkLabel2.Text = "http://api.openweathermap.org/data/2.5/weather?q=London&mode=xml";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetLink);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(22, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(276, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "m1";
            this.linkLabel1.Text = "http://api.worldbank.org/countries?format=xml";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetLink);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(939, 481);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "About";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // colHeader
            // 
            this.colHeader.HeaderText = "Header";
            this.colHeader.MinimumWidth = 100;
            this.colHeader.Name = "colHeader";
            this.colHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHeader.Width = 200;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Value";
            this.colValue.MinimumWidth = 100;
            this.colValue.Name = "colValue";
            this.colValue.Width = 300;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "ReST Client ";
            this.SizeChanged += new System.EventHandler(this.OnSize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeader)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.WebBrowser xmlView;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dataGridViewHeader;
        private System.Windows.Forms.TabPage tabGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    }
}

