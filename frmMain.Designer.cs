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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabResponse = new System.Windows.Forms.TabPage();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.tabRequest = new System.Windows.Forms.TabPage();
            this.rtbRequest = new System.Windows.Forms.RichTextBox();
            this.tabLinks = new System.Windows.Forms.TabPage();
            this.tabXmlView = new System.Windows.Forms.TabPage();
            this.xmlView = new System.Windows.Forms.WebBrowser();
            this.tabGridView = new System.Windows.Forms.TabPage();
            this.tabAuthentication = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabHeaders = new System.Windows.Forms.TabPage();
            this.dataGridViewHeader = new System.Windows.Forms.DataGridView();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOAuth = new System.Windows.Forms.TabPage();
            this.tabSampleRequest = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.listHistory = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabResponse.SuspendLayout();
            this.tabRequest.SuspendLayout();
            this.tabXmlView.SuspendLayout();
            this.tabAuthentication.SuspendLayout();
            this.tabHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeader)).BeginInit();
            this.tabSampleRequest.SuspendLayout();
            this.tabHistory.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabResponse);
            this.tabControl1.Controls.Add(this.tabRequest);
            this.tabControl1.Controls.Add(this.tabLinks);
            this.tabControl1.Controls.Add(this.tabXmlView);
            this.tabControl1.Controls.Add(this.tabGridView);
            this.tabControl1.Controls.Add(this.tabAuthentication);
            this.tabControl1.Controls.Add(this.tabHeaders);
            this.tabControl1.Controls.Add(this.tabOAuth);
            this.tabControl1.Controls.Add(this.tabSampleRequest);
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(17, 69);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 513);
            this.tabControl1.TabIndex = 3;
            // 
            // tabResponse
            // 
            this.tabResponse.Controls.Add(this.rtbResponse);
            this.tabResponse.Location = new System.Drawing.Point(4, 28);
            this.tabResponse.Margin = new System.Windows.Forms.Padding(4);
            this.tabResponse.Name = "tabResponse";
            this.tabResponse.Padding = new System.Windows.Forms.Padding(4);
            this.tabResponse.Size = new System.Drawing.Size(939, 481);
            this.tabResponse.TabIndex = 0;
            this.tabResponse.Text = "Response";
            this.tabResponse.UseVisualStyleBackColor = true;
            // 
            // rtbResponse
            // 
            this.rtbResponse.BackColor = System.Drawing.SystemColors.Control;
            this.rtbResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbResponse.Location = new System.Drawing.Point(0, 0);
            this.rtbResponse.Margin = new System.Windows.Forms.Padding(4);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.ReadOnly = true;
            this.rtbResponse.Size = new System.Drawing.Size(936, 478);
            this.rtbResponse.TabIndex = 0;
            this.rtbResponse.Text = "";
            // 
            // tabRequest
            // 
            this.tabRequest.Controls.Add(this.rtbRequest);
            this.tabRequest.Location = new System.Drawing.Point(4, 28);
            this.tabRequest.Name = "tabRequest";
            this.tabRequest.Size = new System.Drawing.Size(939, 481);
            this.tabRequest.TabIndex = 9;
            this.tabRequest.Text = "Request";
            this.tabRequest.UseVisualStyleBackColor = true;
            // 
            // rtbRequest
            // 
            this.rtbRequest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbRequest.Location = new System.Drawing.Point(1, 1);
            this.rtbRequest.Margin = new System.Windows.Forms.Padding(4);
            this.rtbRequest.Name = "rtbRequest";
            this.rtbRequest.Size = new System.Drawing.Size(936, 478);
            this.rtbRequest.TabIndex = 1;
            this.rtbRequest.Text = "";
            // 
            // tabLinks
            // 
            this.tabLinks.Location = new System.Drawing.Point(4, 28);
            this.tabLinks.Margin = new System.Windows.Forms.Padding(4);
            this.tabLinks.Name = "tabLinks";
            this.tabLinks.Size = new System.Drawing.Size(939, 481);
            this.tabLinks.TabIndex = 5;
            this.tabLinks.Text = "Links";
            this.tabLinks.UseVisualStyleBackColor = true;
            // 
            // tabXmlView
            // 
            this.tabXmlView.Controls.Add(this.xmlView);
            this.tabXmlView.Location = new System.Drawing.Point(4, 28);
            this.tabXmlView.Margin = new System.Windows.Forms.Padding(4);
            this.tabXmlView.Name = "tabXmlView";
            this.tabXmlView.Padding = new System.Windows.Forms.Padding(4);
            this.tabXmlView.Size = new System.Drawing.Size(939, 481);
            this.tabXmlView.TabIndex = 1;
            this.tabXmlView.Text = "XML View";
            this.tabXmlView.UseVisualStyleBackColor = true;
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
            // tabAuthentication
            // 
            this.tabAuthentication.Controls.Add(this.txtPassword);
            this.tabAuthentication.Controls.Add(this.txtUserName);
            this.tabAuthentication.Controls.Add(this.label2);
            this.tabAuthentication.Controls.Add(this.label1);
            this.tabAuthentication.Location = new System.Drawing.Point(4, 28);
            this.tabAuthentication.Margin = new System.Windows.Forms.Padding(4);
            this.tabAuthentication.Name = "tabAuthentication";
            this.tabAuthentication.Padding = new System.Windows.Forms.Padding(4);
            this.tabAuthentication.Size = new System.Drawing.Size(939, 481);
            this.tabAuthentication.TabIndex = 2;
            this.tabAuthentication.Text = "Authentication";
            this.tabAuthentication.UseVisualStyleBackColor = true;
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
            // tabHeaders
            // 
            this.tabHeaders.Controls.Add(this.dataGridViewHeader);
            this.tabHeaders.Location = new System.Drawing.Point(4, 28);
            this.tabHeaders.Margin = new System.Windows.Forms.Padding(4);
            this.tabHeaders.Name = "tabHeaders";
            this.tabHeaders.Size = new System.Drawing.Size(939, 481);
            this.tabHeaders.TabIndex = 3;
            this.tabHeaders.Text = "Headers";
            this.tabHeaders.UseVisualStyleBackColor = true;
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
            // tabOAuth
            // 
            this.tabOAuth.Location = new System.Drawing.Point(4, 28);
            this.tabOAuth.Margin = new System.Windows.Forms.Padding(4);
            this.tabOAuth.Name = "tabOAuth";
            this.tabOAuth.Size = new System.Drawing.Size(939, 481);
            this.tabOAuth.TabIndex = 4;
            this.tabOAuth.Text = "OAuth";
            this.tabOAuth.UseVisualStyleBackColor = true;
            // 
            // tabSampleRequest
            // 
            this.tabSampleRequest.Controls.Add(this.linkLabel3);
            this.tabSampleRequest.Controls.Add(this.linkLabel2);
            this.tabSampleRequest.Controls.Add(this.linkLabel1);
            this.tabSampleRequest.Location = new System.Drawing.Point(4, 28);
            this.tabSampleRequest.Name = "tabSampleRequest";
            this.tabSampleRequest.Size = new System.Drawing.Size(939, 481);
            this.tabSampleRequest.TabIndex = 7;
            this.tabSampleRequest.Text = "Sample Request";
            this.tabSampleRequest.UseVisualStyleBackColor = true;
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
            // tabAbout
            // 
            this.tabAbout.Location = new System.Drawing.Point(4, 28);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(939, 481);
            this.tabAbout.TabIndex = 6;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.listHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 28);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(939, 481);
            this.tabHistory.TabIndex = 10;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // listHistory
            // 
            this.listHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2});
            this.listHistory.Location = new System.Drawing.Point(3, 3);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(933, 475);
            this.listHistory.TabIndex = 0;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Method";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "URI";
            columnHeader2.Width = 400;
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
            this.tabResponse.ResumeLayout(false);
            this.tabRequest.ResumeLayout(false);
            this.tabXmlView.ResumeLayout(false);
            this.tabAuthentication.ResumeLayout(false);
            this.tabAuthentication.PerformLayout();
            this.tabHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHeader)).EndInit();
            this.tabSampleRequest.ResumeLayout(false);
            this.tabSampleRequest.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabResponse;
        private System.Windows.Forms.TabPage tabXmlView;
        private System.Windows.Forms.TabPage tabAuthentication;
        private System.Windows.Forms.TabPage tabHeaders;
        private System.Windows.Forms.TabPage tabOAuth;
        private System.Windows.Forms.TabPage tabLinks;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.WebBrowser xmlView;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.TabPage tabSampleRequest;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dataGridViewHeader;
        private System.Windows.Forms.TabPage tabGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.TabPage tabRequest;
        private System.Windows.Forms.RichTextBox rtbRequest;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.ListView listHistory;
    }
}

