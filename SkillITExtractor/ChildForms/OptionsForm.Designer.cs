namespace SkillITForm.ChildForms
{
    partial class OptionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLoginWait = new System.Windows.Forms.ComboBox();
            this.comboBoxPageLoadWait = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxJobNavigationWait = new System.Windows.Forms.ComboBox();
            this.groupBoxBrowserSelected = new System.Windows.Forms.GroupBox();
            this.radioButtonFireFox = new System.Windows.Forms.RadioButton();
            this.radioButtonEdge = new System.Windows.Forms.RadioButton();
            this.radioButtonChrome = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxBrowserSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Wait (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Page Load Wait (ms)";
            // 
            // comboBoxLoginWait
            // 
            this.comboBoxLoginWait.FormattingEnabled = true;
            this.comboBoxLoginWait.Location = new System.Drawing.Point(161, 12);
            this.comboBoxLoginWait.Name = "comboBoxLoginWait";
            this.comboBoxLoginWait.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoginWait.TabIndex = 2;
            // 
            // comboBoxPageLoadWait
            // 
            this.comboBoxPageLoadWait.FormattingEnabled = true;
            this.comboBoxPageLoadWait.Location = new System.Drawing.Point(161, 46);
            this.comboBoxPageLoadWait.Name = "comboBoxPageLoadWait";
            this.comboBoxPageLoadWait.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPageLoadWait.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Job Navigation Wait (ms)";
            // 
            // comboBoxJobNavigationWait
            // 
            this.comboBoxJobNavigationWait.FormattingEnabled = true;
            this.comboBoxJobNavigationWait.Location = new System.Drawing.Point(161, 80);
            this.comboBoxJobNavigationWait.Name = "comboBoxJobNavigationWait";
            this.comboBoxJobNavigationWait.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJobNavigationWait.TabIndex = 5;
            // 
            // groupBoxBrowserSelected
            // 
            this.groupBoxBrowserSelected.Controls.Add(this.radioButtonFireFox);
            this.groupBoxBrowserSelected.Controls.Add(this.radioButtonEdge);
            this.groupBoxBrowserSelected.Controls.Add(this.radioButtonChrome);
            this.groupBoxBrowserSelected.Location = new System.Drawing.Point(12, 115);
            this.groupBoxBrowserSelected.Name = "groupBoxBrowserSelected";
            this.groupBoxBrowserSelected.Size = new System.Drawing.Size(266, 88);
            this.groupBoxBrowserSelected.TabIndex = 6;
            this.groupBoxBrowserSelected.TabStop = false;
            this.groupBoxBrowserSelected.Text = "Select Browser";
            // 
            // radioButtonFireFox
            // 
            this.radioButtonFireFox.AutoSize = true;
            this.radioButtonFireFox.Location = new System.Drawing.Point(18, 65);
            this.radioButtonFireFox.Name = "radioButtonFireFox";
            this.radioButtonFireFox.Size = new System.Drawing.Size(56, 17);
            this.radioButtonFireFox.TabIndex = 2;
            this.radioButtonFireFox.TabStop = true;
            this.radioButtonFireFox.Text = "Firefox";
            this.radioButtonFireFox.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdge
            // 
            this.radioButtonEdge.AutoSize = true;
            this.radioButtonEdge.Location = new System.Drawing.Point(18, 42);
            this.radioButtonEdge.Name = "radioButtonEdge";
            this.radioButtonEdge.Size = new System.Drawing.Size(50, 17);
            this.radioButtonEdge.TabIndex = 1;
            this.radioButtonEdge.TabStop = true;
            this.radioButtonEdge.Text = "Edge";
            this.radioButtonEdge.UseVisualStyleBackColor = true;
            // 
            // radioButtonChrome
            // 
            this.radioButtonChrome.AutoSize = true;
            this.radioButtonChrome.Location = new System.Drawing.Point(18, 19);
            this.radioButtonChrome.Name = "radioButtonChrome";
            this.radioButtonChrome.Size = new System.Drawing.Size(61, 17);
            this.radioButtonChrome.TabIndex = 0;
            this.radioButtonChrome.TabStop = true;
            this.radioButtonChrome.Text = "Chrome";
            this.radioButtonChrome.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(11, 286);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(271, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save Options";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 321);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxBrowserSelected);
            this.Controls.Add(this.comboBoxJobNavigationWait);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPageLoadWait);
            this.Controls.Add(this.comboBoxLoginWait);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.groupBoxBrowserSelected.ResumeLayout(false);
            this.groupBoxBrowserSelected.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLoginWait;
        private System.Windows.Forms.ComboBox comboBoxPageLoadWait;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxJobNavigationWait;
        private System.Windows.Forms.GroupBox groupBoxBrowserSelected;
        private System.Windows.Forms.RadioButton radioButtonFireFox;
        private System.Windows.Forms.RadioButton radioButtonEdge;
        private System.Windows.Forms.RadioButton radioButtonChrome;
        private System.Windows.Forms.Button buttonSave;
    }
}