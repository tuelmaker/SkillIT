namespace SkillIT
{
    partial class SkillITMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillITMain));
            this.textBoxInitialJobSearchURL = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxExtractedInformation = new System.Windows.Forms.TextBox();
            this.buttonExtractInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonGetJobCount = new System.Windows.Forms.Button();
            this.groupBoxSelectionCriteria = new System.Windows.Forms.GroupBox();
            this.comboBoxLimitJobLookup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxJobListingPeriod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEmploymentType = new System.Windows.Forms.ComboBox();
            this.checkBoxOnSite = new System.Windows.Forms.CheckBox();
            this.checkBoxHybrid = new System.Windows.Forms.CheckBox();
            this.checkBoxRemote = new System.Windows.Forms.CheckBox();
            this.labelJobsFound = new System.Windows.Forms.Label();
            this.labelLoginStatus = new System.Windows.Forms.Label();
            this.buttonSaveJSON = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarProcessing = new System.Windows.Forms.ProgressBar();
            this.groupBoxSelectionCriteria.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInitialJobSearchURL
            // 
            this.textBoxInitialJobSearchURL.Location = new System.Drawing.Point(105, 23);
            this.textBoxInitialJobSearchURL.Name = "textBoxInitialJobSearchURL";
            this.textBoxInitialJobSearchURL.Size = new System.Drawing.Size(336, 20);
            this.textBoxInitialJobSearchURL.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(105, 103);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(52, 28);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxExtractedInformation
            // 
            this.textBoxExtractedInformation.Location = new System.Drawing.Point(15, 279);
            this.textBoxExtractedInformation.MaxLength = 2048000;
            this.textBoxExtractedInformation.Multiline = true;
            this.textBoxExtractedInformation.Name = "textBoxExtractedInformation";
            this.textBoxExtractedInformation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxExtractedInformation.Size = new System.Drawing.Size(821, 279);
            this.textBoxExtractedInformation.TabIndex = 8;
            // 
            // buttonExtractInformation
            // 
            this.buttonExtractInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonExtractInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExtractInformation.Location = new System.Drawing.Point(12, 211);
            this.buttonExtractInformation.Name = "buttonExtractInformation";
            this.buttonExtractInformation.Size = new System.Drawing.Size(824, 62);
            this.buttonExtractInformation.TabIndex = 7;
            this.buttonExtractInformation.Text = "Extract Information";
            this.buttonExtractInformation.UseVisualStyleBackColor = false;
            this.buttonExtractInformation.Click += new System.EventHandler(this.buttonExtractInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Job Search URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(105, 50);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(336, 20);
            this.textBoxUserName.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(105, 77);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(336, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonGetJobCount
            // 
            this.buttonGetJobCount.Location = new System.Drawing.Point(12, 182);
            this.buttonGetJobCount.Name = "buttonGetJobCount";
            this.buttonGetJobCount.Size = new System.Drawing.Size(207, 23);
            this.buttonGetJobCount.TabIndex = 6;
            this.buttonGetJobCount.Text = "Get Job Count";
            this.buttonGetJobCount.UseVisualStyleBackColor = true;
            this.buttonGetJobCount.Click += new System.EventHandler(this.buttonGetJobCount_Click);
            // 
            // groupBoxSelectionCriteria
            // 
            this.groupBoxSelectionCriteria.Controls.Add(this.comboBoxLimitJobLookup);
            this.groupBoxSelectionCriteria.Controls.Add(this.label7);
            this.groupBoxSelectionCriteria.Controls.Add(this.comboBoxJobListingPeriod);
            this.groupBoxSelectionCriteria.Controls.Add(this.label6);
            this.groupBoxSelectionCriteria.Controls.Add(this.label5);
            this.groupBoxSelectionCriteria.Controls.Add(this.comboBoxEmploymentType);
            this.groupBoxSelectionCriteria.Controls.Add(this.checkBoxOnSite);
            this.groupBoxSelectionCriteria.Controls.Add(this.checkBoxHybrid);
            this.groupBoxSelectionCriteria.Controls.Add(this.checkBoxRemote);
            this.groupBoxSelectionCriteria.Location = new System.Drawing.Point(468, 37);
            this.groupBoxSelectionCriteria.Name = "groupBoxSelectionCriteria";
            this.groupBoxSelectionCriteria.Size = new System.Drawing.Size(368, 135);
            this.groupBoxSelectionCriteria.TabIndex = 14;
            this.groupBoxSelectionCriteria.TabStop = false;
            this.groupBoxSelectionCriteria.Text = "Selection Criteria";
            // 
            // comboBoxLimitJobLookup
            // 
            this.comboBoxLimitJobLookup.FormattingEnabled = true;
            this.comboBoxLimitJobLookup.Location = new System.Drawing.Point(204, 69);
            this.comboBoxLimitJobLookup.Name = "comboBoxLimitJobLookup";
            this.comboBoxLimitJobLookup.Size = new System.Drawing.Size(143, 21);
            this.comboBoxLimitJobLookup.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Limit Job Lookup";
            // 
            // comboBoxJobListingPeriod
            // 
            this.comboBoxJobListingPeriod.Enabled = false;
            this.comboBoxJobListingPeriod.FormattingEnabled = true;
            this.comboBoxJobListingPeriod.Location = new System.Drawing.Point(204, 46);
            this.comboBoxJobListingPeriod.Name = "comboBoxJobListingPeriod";
            this.comboBoxJobListingPeriod.Size = new System.Drawing.Size(143, 21);
            this.comboBoxJobListingPeriod.TabIndex = 6;
            this.comboBoxJobListingPeriod.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(107, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Job Listing Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(107, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employment Type";
            // 
            // comboBoxEmploymentType
            // 
            this.comboBoxEmploymentType.Enabled = false;
            this.comboBoxEmploymentType.FormattingEnabled = true;
            this.comboBoxEmploymentType.Location = new System.Drawing.Point(204, 21);
            this.comboBoxEmploymentType.Name = "comboBoxEmploymentType";
            this.comboBoxEmploymentType.Size = new System.Drawing.Size(143, 21);
            this.comboBoxEmploymentType.TabIndex = 3;
            this.comboBoxEmploymentType.TabStop = false;
            // 
            // checkBoxOnSite
            // 
            this.checkBoxOnSite.AutoSize = true;
            this.checkBoxOnSite.Enabled = false;
            this.checkBoxOnSite.Location = new System.Drawing.Point(30, 71);
            this.checkBoxOnSite.Name = "checkBoxOnSite";
            this.checkBoxOnSite.Size = new System.Drawing.Size(61, 17);
            this.checkBoxOnSite.TabIndex = 2;
            this.checkBoxOnSite.TabStop = false;
            this.checkBoxOnSite.Text = "On-Site";
            this.checkBoxOnSite.UseVisualStyleBackColor = true;
            // 
            // checkBoxHybrid
            // 
            this.checkBoxHybrid.AutoSize = true;
            this.checkBoxHybrid.Enabled = false;
            this.checkBoxHybrid.Location = new System.Drawing.Point(30, 48);
            this.checkBoxHybrid.Name = "checkBoxHybrid";
            this.checkBoxHybrid.Size = new System.Drawing.Size(56, 17);
            this.checkBoxHybrid.TabIndex = 1;
            this.checkBoxHybrid.TabStop = false;
            this.checkBoxHybrid.Text = "Hybrid";
            this.checkBoxHybrid.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemote
            // 
            this.checkBoxRemote.AutoSize = true;
            this.checkBoxRemote.Enabled = false;
            this.checkBoxRemote.Location = new System.Drawing.Point(30, 23);
            this.checkBoxRemote.Name = "checkBoxRemote";
            this.checkBoxRemote.Size = new System.Drawing.Size(63, 17);
            this.checkBoxRemote.TabIndex = 0;
            this.checkBoxRemote.TabStop = false;
            this.checkBoxRemote.Text = "Remote";
            this.checkBoxRemote.UseVisualStyleBackColor = true;
            // 
            // labelJobsFound
            // 
            this.labelJobsFound.AutoSize = true;
            this.labelJobsFound.Location = new System.Drawing.Point(225, 187);
            this.labelJobsFound.Name = "labelJobsFound";
            this.labelJobsFound.Size = new System.Drawing.Size(62, 13);
            this.labelJobsFound.TabIndex = 15;
            this.labelJobsFound.Text = "Jobs Found";
            // 
            // labelLoginStatus
            // 
            this.labelLoginStatus.AutoSize = true;
            this.labelLoginStatus.Location = new System.Drawing.Point(261, 108);
            this.labelLoginStatus.Name = "labelLoginStatus";
            this.labelLoginStatus.Size = new System.Drawing.Size(66, 13);
            this.labelLoginStatus.TabIndex = 16;
            this.labelLoginStatus.Text = "Login Status";
            // 
            // buttonSaveJSON
            // 
            this.buttonSaveJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSaveJSON.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSaveJSON.Location = new System.Drawing.Point(12, 564);
            this.buttonSaveJSON.Name = "buttonSaveJSON";
            this.buttonSaveJSON.Size = new System.Drawing.Size(824, 62);
            this.buttonSaveJSON.TabIndex = 9;
            this.buttonSaveJSON.Text = "Save JSON to File";
            this.buttonSaveJSON.UseVisualStyleBackColor = false;
            this.buttonSaveJSON.Click += new System.EventHandler(this.buttonSaveJSON_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonRefresh);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxInitialJobSearchURL);
            this.groupBoxLogin.Controls.Add(this.labelLoginStatus);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Controls.Add(this.label3);
            this.groupBoxLogin.Controls.Add(this.textBoxUserName);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Location = new System.Drawing.Point(15, 35);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(447, 137);
            this.groupBoxLogin.TabIndex = 18;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Enabled = false;
            this.buttonRefresh.Location = new System.Drawing.Point(163, 103);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 28);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.Text = "Refresh Login";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStripOptions.Location = new System.Drawing.Point(0, 0);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Size = new System.Drawing.Size(848, 24);
            this.menuStripOptions.TabIndex = 19;
            this.menuStripOptions.Text = "menuStripOptions";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // progressBarProcessing
            // 
            this.progressBarProcessing.Location = new System.Drawing.Point(468, 182);
            this.progressBarProcessing.Name = "progressBarProcessing";
            this.progressBarProcessing.Size = new System.Drawing.Size(368, 23);
            this.progressBarProcessing.TabIndex = 20;
            // 
            // SkillITMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 647);
            this.Controls.Add(this.progressBarProcessing);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.buttonSaveJSON);
            this.Controls.Add(this.labelJobsFound);
            this.Controls.Add(this.groupBoxSelectionCriteria);
            this.Controls.Add(this.buttonGetJobCount);
            this.Controls.Add(this.buttonExtractInformation);
            this.Controls.Add(this.textBoxExtractedInformation);
            this.Controls.Add(this.menuStripOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripOptions;
            this.Name = "SkillITMain";
            this.Text = "SkillIT Linked In Extractor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkillITMain_FormClosing);
            this.Load += new System.EventHandler(this.SkillITMain_Load);
            this.groupBoxSelectionCriteria.ResumeLayout(false);
            this.groupBoxSelectionCriteria.PerformLayout();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInitialJobSearchURL;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxExtractedInformation;
        private System.Windows.Forms.Button buttonExtractInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonGetJobCount;
        private System.Windows.Forms.GroupBox groupBoxSelectionCriteria;
        private System.Windows.Forms.CheckBox checkBoxOnSite;
        private System.Windows.Forms.CheckBox checkBoxHybrid;
        private System.Windows.Forms.CheckBox checkBoxRemote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEmploymentType;
        private System.Windows.Forms.ComboBox comboBoxJobListingPeriod;
        private System.Windows.Forms.ComboBox comboBoxLimitJobLookup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelJobsFound;
        private System.Windows.Forms.Label labelLoginStatus;
        private System.Windows.Forms.Button buttonSaveJSON;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarProcessing;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
    }
}