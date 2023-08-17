namespace MOTDGen
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pSMultiServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sVMLToolGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeLaboratoryDiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleGroup = new System.Windows.Forms.GroupBox();
            this.naviMOTD = new System.Windows.Forms.RadioButton();
            this.classicMOTD = new System.Windows.Forms.RadioButton();
            this.textGroup = new System.Windows.Forms.GroupBox();
            this.messageTextbox = new System.Windows.Forms.TextBox();
            this.headerGroup = new System.Windows.Forms.GroupBox();
            this.headerTextbox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.styleGroup.SuspendLayout();
            this.textGroup.SuspendLayout();
            this.headerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.linksToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pSMultiServerToolStripMenuItem,
            this.sVMLToolGithubToolStripMenuItem,
            this.homeLaboratoryDiscordToolStripMenuItem});
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linksToolStripMenuItem.Text = "Links";
            this.linksToolStripMenuItem.Click += new System.EventHandler(this.linksToolStripMenuItem_Click);
            // 
            // pSMultiServerToolStripMenuItem
            // 
            this.pSMultiServerToolStripMenuItem.Name = "pSMultiServerToolStripMenuItem";
            this.pSMultiServerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.pSMultiServerToolStripMenuItem.Text = "PSMultiServer";
            this.pSMultiServerToolStripMenuItem.Click += new System.EventHandler(this.pSMultiServerToolStripMenuItem_Click);
            // 
            // sVMLToolGithubToolStripMenuItem
            // 
            this.sVMLToolGithubToolStripMenuItem.Name = "sVMLToolGithubToolStripMenuItem";
            this.sVMLToolGithubToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.sVMLToolGithubToolStripMenuItem.Text = "SVMLTool Github";
            this.sVMLToolGithubToolStripMenuItem.Click += new System.EventHandler(this.sVMLToolGithubToolStripMenuItem_Click);
            // 
            // homeLaboratoryDiscordToolStripMenuItem
            // 
            this.homeLaboratoryDiscordToolStripMenuItem.Name = "homeLaboratoryDiscordToolStripMenuItem";
            this.homeLaboratoryDiscordToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.homeLaboratoryDiscordToolStripMenuItem.Text = "Home Laboratory Discord";
            this.homeLaboratoryDiscordToolStripMenuItem.Click += new System.EventHandler(this.homeLaboratoryDiscordToolStripMenuItem_Click);
            // 
            // styleGroup
            // 
            this.styleGroup.Controls.Add(this.naviMOTD);
            this.styleGroup.Controls.Add(this.classicMOTD);
            this.styleGroup.Location = new System.Drawing.Point(12, 27);
            this.styleGroup.Name = "styleGroup";
            this.styleGroup.Size = new System.Drawing.Size(119, 68);
            this.styleGroup.TabIndex = 1;
            this.styleGroup.TabStop = false;
            this.styleGroup.Text = "Style";
            // 
            // naviMOTD
            // 
            this.naviMOTD.AutoSize = true;
            this.naviMOTD.Enabled = false;
            this.naviMOTD.Location = new System.Drawing.Point(6, 42);
            this.naviMOTD.Name = "naviMOTD";
            this.naviMOTD.Size = new System.Drawing.Size(83, 17);
            this.naviMOTD.TabIndex = 2;
            this.naviMOTD.TabStop = true;
            this.naviMOTD.Text = "New (1.35+)";
            this.naviMOTD.UseVisualStyleBackColor = true;
            this.naviMOTD.CheckedChanged += new System.EventHandler(this.naviMOTD_CheckedChanged);
            // 
            // classicMOTD
            // 
            this.classicMOTD.AutoSize = true;
            this.classicMOTD.Checked = true;
            this.classicMOTD.Location = new System.Drawing.Point(6, 19);
            this.classicMOTD.Name = "classicMOTD";
            this.classicMOTD.Size = new System.Drawing.Size(100, 17);
            this.classicMOTD.TabIndex = 2;
            this.classicMOTD.TabStop = true;
            this.classicMOTD.Text = "Classic (<=1.32)";
            this.classicMOTD.UseVisualStyleBackColor = true;
            this.classicMOTD.CheckedChanged += new System.EventHandler(this.classicMOTD_CheckedChanged);
            // 
            // textGroup
            // 
            this.textGroup.Controls.Add(this.messageTextbox);
            this.textGroup.Location = new System.Drawing.Point(12, 101);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(571, 337);
            this.textGroup.TabIndex = 2;
            this.textGroup.TabStop = false;
            this.textGroup.Text = "Message";
            // 
            // messageTextbox
            // 
            this.messageTextbox.AcceptsReturn = true;
            this.messageTextbox.Location = new System.Drawing.Point(6, 19);
            this.messageTextbox.Multiline = true;
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextbox.Size = new System.Drawing.Size(559, 312);
            this.messageTextbox.TabIndex = 0;
            this.messageTextbox.Text = resources.GetString("messageTextbox.Text");
            // 
            // headerGroup
            // 
            this.headerGroup.Controls.Add(this.headerTextbox);
            this.headerGroup.Location = new System.Drawing.Point(137, 41);
            this.headerGroup.Name = "headerGroup";
            this.headerGroup.Size = new System.Drawing.Size(232, 45);
            this.headerGroup.TabIndex = 3;
            this.headerGroup.TabStop = false;
            this.headerGroup.Text = "Header";
            // 
            // headerTextbox
            // 
            this.headerTextbox.Location = new System.Drawing.Point(6, 16);
            this.headerTextbox.MaxLength = 36;
            this.headerTextbox.Name = "headerTextbox";
            this.headerTextbox.Size = new System.Drawing.Size(220, 20);
            this.headerTextbox.TabIndex = 4;
            this.headerTextbox.Text = "Message of the Day";
            this.headerTextbox.WordWrap = false;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(493, 55);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(84, 22);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create!";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.headerGroup);
            this.Controls.Add(this.textGroup);
            this.Controls.Add(this.styleGroup);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PlayStation Home SVML Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.styleGroup.ResumeLayout(false);
            this.styleGroup.PerformLayout();
            this.textGroup.ResumeLayout(false);
            this.textGroup.PerformLayout();
            this.headerGroup.ResumeLayout(false);
            this.headerGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox styleGroup;
        private System.Windows.Forms.RadioButton naviMOTD;
        private System.Windows.Forms.RadioButton classicMOTD;
        private System.Windows.Forms.GroupBox textGroup;
        private System.Windows.Forms.TextBox messageTextbox;
        private System.Windows.Forms.GroupBox headerGroup;
        private System.Windows.Forms.TextBox headerTextbox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pSMultiServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sVMLToolGithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeLaboratoryDiscordToolStripMenuItem;
    }
}

