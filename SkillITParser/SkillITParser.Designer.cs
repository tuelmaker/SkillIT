namespace SkillITParser
{
    partial class SkillITParser
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
            this.openFileDialogLoadJsonFile = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFlattenedJson = new System.Windows.Forms.DataGridView();
            this.buttonSaveAsCsv = new System.Windows.Forms.Button();
            this.textBoxJsonFile = new System.Windows.Forms.TextBox();
            this.buttonLoadJsonFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlattenedJson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Json File Path";
            // 
            // dataGridViewFlattenedJson
            // 
            this.dataGridViewFlattenedJson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlattenedJson.Location = new System.Drawing.Point(16, 49);
            this.dataGridViewFlattenedJson.Name = "dataGridViewFlattenedJson";
            this.dataGridViewFlattenedJson.Size = new System.Drawing.Size(772, 341);
            this.dataGridViewFlattenedJson.TabIndex = 2;
            // 
            // buttonSaveAsCsv
            // 
            this.buttonSaveAsCsv.Location = new System.Drawing.Point(16, 396);
            this.buttonSaveAsCsv.Name = "buttonSaveAsCsv";
            this.buttonSaveAsCsv.Size = new System.Drawing.Size(772, 42);
            this.buttonSaveAsCsv.TabIndex = 3;
            this.buttonSaveAsCsv.Text = "Save as CSV";
            this.buttonSaveAsCsv.UseVisualStyleBackColor = true;
            this.buttonSaveAsCsv.Click += new System.EventHandler(this.buttonSaveAsCsv_Click);
            // 
            // textBoxJsonFile
            // 
            this.textBoxJsonFile.Location = new System.Drawing.Point(92, 10);
            this.textBoxJsonFile.Name = "textBoxJsonFile";
            this.textBoxJsonFile.Size = new System.Drawing.Size(653, 20);
            this.textBoxJsonFile.TabIndex = 4;
            // 
            // buttonLoadJsonFile
            // 
            this.buttonLoadJsonFile.Location = new System.Drawing.Point(745, 8);
            this.buttonLoadJsonFile.Name = "buttonLoadJsonFile";
            this.buttonLoadJsonFile.Size = new System.Drawing.Size(36, 23);
            this.buttonLoadJsonFile.TabIndex = 5;
            this.buttonLoadJsonFile.Text = "...";
            this.buttonLoadJsonFile.UseVisualStyleBackColor = true;
            this.buttonLoadJsonFile.Click += new System.EventHandler(this.buttonLoadJsonFile_Click);
            // 
            // SkillITParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoadJsonFile);
            this.Controls.Add(this.textBoxJsonFile);
            this.Controls.Add(this.buttonSaveAsCsv);
            this.Controls.Add(this.dataGridViewFlattenedJson);
            this.Controls.Add(this.label1);
            this.Name = "SkillITParser";
            this.Text = "SkillIT Parser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlattenedJson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogLoadJsonFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFlattenedJson;
        private System.Windows.Forms.Button buttonSaveAsCsv;
        private System.Windows.Forms.TextBox textBoxJsonFile;
        private System.Windows.Forms.Button buttonLoadJsonFile;
    }
}

