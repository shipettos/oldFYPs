namespace FinalYearProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cmdChooseFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLangId = new System.Windows.Forms.TabPage();
            this.GBResults = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdIdentifyLanguage = new System.Windows.Forms.Button();
            this.dataInput = new System.Windows.Forms.DataGridView();
            this.FileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engList = new System.Windows.Forms.TabPage();
            this.engData = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Times_Appeared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frList = new System.Windows.Forms.TabPage();
            this.frData = new System.Windows.Forms.DataGridView();
            this.NumFr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spList = new System.Windows.Forms.TabPage();
            this.spData = new System.Windows.Forms.DataGridView();
            this.NumSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEng = new System.Windows.Forms.Label();
            this.lblSpan = new System.Windows.Forms.Label();
            this.lblFr = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLangId.SuspendLayout();
            this.GBResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInput)).BeginInit();
            this.engList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engData)).BeginInit();
            this.frList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frData)).BeginInit();
            this.spList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a file to recocnise language :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(231, 53);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(194, 20);
            this.txtPath.TabIndex = 1;
            // 
            // cmdChooseFile
            // 
            this.cmdChooseFile.Location = new System.Drawing.Point(431, 53);
            this.cmdChooseFile.Name = "cmdChooseFile";
            this.cmdChooseFile.Size = new System.Drawing.Size(75, 23);
            this.cmdChooseFile.TabIndex = 2;
            this.cmdChooseFile.Text = "Choose";
            this.cmdChooseFile.UseVisualStyleBackColor = true;
            this.cmdChooseFile.Click += new System.EventHandler(this.cmdChooseFile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLangId);
            this.tabControl1.Controls.Add(this.engList);
            this.tabControl1.Controls.Add(this.frList);
            this.tabControl1.Controls.Add(this.spList);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 389);
            this.tabControl1.TabIndex = 8;
            // 
            // tabLangId
            // 
            this.tabLangId.Controls.Add(this.GBResults);
            this.tabLangId.Controls.Add(this.cmdIdentifyLanguage);
            this.tabLangId.Controls.Add(this.dataInput);
            this.tabLangId.Controls.Add(this.txtPath);
            this.tabLangId.Controls.Add(this.label1);
            this.tabLangId.Controls.Add(this.cmdChooseFile);
            this.tabLangId.Location = new System.Drawing.Point(4, 22);
            this.tabLangId.Name = "tabLangId";
            this.tabLangId.Padding = new System.Windows.Forms.Padding(3);
            this.tabLangId.Size = new System.Drawing.Size(694, 363);
            this.tabLangId.TabIndex = 0;
            this.tabLangId.Text = "Language Identification";
            this.tabLangId.UseVisualStyleBackColor = true;
            // 
            // GBResults
            // 
            this.GBResults.Controls.Add(this.lblFr);
            this.GBResults.Controls.Add(this.lblSpan);
            this.GBResults.Controls.Add(this.lblEng);
            this.GBResults.Controls.Add(this.label7);
            this.GBResults.Controls.Add(this.label6);
            this.GBResults.Controls.Add(this.label5);
            this.GBResults.Controls.Add(this.label4);
            this.GBResults.Controls.Add(this.lblLanguage);
            this.GBResults.Controls.Add(this.label3);
            this.GBResults.Controls.Add(this.label2);
            this.GBResults.Location = new System.Drawing.Point(431, 111);
            this.GBResults.Name = "GBResults";
            this.GBResults.Size = new System.Drawing.Size(187, 168);
            this.GBResults.TabIndex = 12;
            this.GBResults.TabStop = false;
            this.GBResults.Text = "Results";
            this.GBResults.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N/A";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(98, 19);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(27, 13);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Percentage (%) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Language : ";
            // 
            // cmdIdentifyLanguage
            // 
            this.cmdIdentifyLanguage.Enabled = false;
            this.cmdIdentifyLanguage.Location = new System.Drawing.Point(514, 53);
            this.cmdIdentifyLanguage.Name = "cmdIdentifyLanguage";
            this.cmdIdentifyLanguage.Size = new System.Drawing.Size(114, 23);
            this.cmdIdentifyLanguage.TabIndex = 11;
            this.cmdIdentifyLanguage.Text = "Identify Language";
            this.cmdIdentifyLanguage.UseVisualStyleBackColor = true;
            this.cmdIdentifyLanguage.Click += new System.EventHandler(this.cmdIdentifyLanguage_Click);
            // 
            // dataInput
            // 
            this.dataInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNumber,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.dataInput.Location = new System.Drawing.Point(7, 111);
            this.dataInput.Name = "dataInput";
            this.dataInput.Size = new System.Drawing.Size(370, 246);
            this.dataInput.TabIndex = 10;
            // 
            // FileNumber
            // 
            this.FileNumber.HeaderText = "#";
            this.FileNumber.Name = "FileNumber";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Token";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Times Appeared";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // engList
            // 
            this.engList.Controls.Add(this.engData);
            this.engList.Location = new System.Drawing.Point(4, 22);
            this.engList.Name = "engList";
            this.engList.Padding = new System.Windows.Forms.Padding(3);
            this.engList.Size = new System.Drawing.Size(694, 363);
            this.engList.TabIndex = 1;
            this.engList.Text = "English Text Lists";
            this.engList.UseVisualStyleBackColor = true;
            // 
            // engData
            // 
            this.engData.AllowUserToOrderColumns = true;
            this.engData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.engData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Token,
            this.Language,
            this.Times_Appeared});
            this.engData.Location = new System.Drawing.Point(7, 38);
            this.engData.Name = "engData";
            this.engData.Size = new System.Drawing.Size(484, 319);
            this.engData.TabIndex = 8;
            // 
            // Number
            // 
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // Language
            // 
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            // 
            // Times_Appeared
            // 
            this.Times_Appeared.HeaderText = "Times Appeared";
            this.Times_Appeared.Name = "Times_Appeared";
            // 
            // frList
            // 
            this.frList.Controls.Add(this.frData);
            this.frList.Location = new System.Drawing.Point(4, 22);
            this.frList.Name = "frList";
            this.frList.Size = new System.Drawing.Size(694, 363);
            this.frList.TabIndex = 2;
            this.frList.Text = "French Text Lists";
            this.frList.UseVisualStyleBackColor = true;
            // 
            // frData
            // 
            this.frData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumFr,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.frData.Location = new System.Drawing.Point(7, 53);
            this.frData.Name = "frData";
            this.frData.Size = new System.Drawing.Size(479, 304);
            this.frData.TabIndex = 13;
            // 
            // NumFr
            // 
            this.NumFr.HeaderText = "#";
            this.NumFr.Name = "NumFr";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Token";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Language";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Times Appeared";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // spList
            // 
            this.spList.Controls.Add(this.spData);
            this.spList.Location = new System.Drawing.Point(4, 22);
            this.spList.Name = "spList";
            this.spList.Size = new System.Drawing.Size(694, 363);
            this.spList.TabIndex = 3;
            this.spList.Text = "Spanish Text Lists";
            this.spList.UseVisualStyleBackColor = true;
            // 
            // spData
            // 
            this.spData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumSp,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.spData.Location = new System.Drawing.Point(7, 57);
            this.spData.Name = "spData";
            this.spData.Size = new System.Drawing.Size(484, 306);
            this.spData.TabIndex = 13;
            // 
            // NumSp
            // 
            this.NumSp.HeaderText = "#";
            this.NumSp.Name = "NumSp";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Token";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Language";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Times Appeared";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "English Distance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Spanish Distance :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "French Distance :";
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Location = new System.Drawing.Point(108, 68);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(27, 13);
            this.lblEng.TabIndex = 7;
            this.lblEng.Text = "N/A";
            // 
            // lblSpan
            // 
            this.lblSpan.AutoSize = true;
            this.lblSpan.Location = new System.Drawing.Point(108, 91);
            this.lblSpan.Name = "lblSpan";
            this.lblSpan.Size = new System.Drawing.Size(27, 13);
            this.lblSpan.TabIndex = 8;
            this.lblSpan.Text = "N/A";
            // 
            // lblFr
            // 
            this.lblFr.AutoSize = true;
            this.lblFr.Location = new System.Drawing.Point(108, 116);
            this.lblFr.Name = "lblFr";
            this.lblFr.Size = new System.Drawing.Size(27, 13);
            this.lblFr.TabIndex = 9;
            this.lblFr.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLangId.ResumeLayout(false);
            this.tabLangId.PerformLayout();
            this.GBResults.ResumeLayout(false);
            this.GBResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInput)).EndInit();
            this.engList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.engData)).EndInit();
            this.frList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frData)).EndInit();
            this.spList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button cmdChooseFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLangId;
        private System.Windows.Forms.TabPage engList;
        private System.Windows.Forms.TabPage frList;
        private System.Windows.Forms.TabPage spList;
        private System.Windows.Forms.DataGridView engData;
        private System.Windows.Forms.GroupBox GBResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdIdentifyLanguage;
        private System.Windows.Forms.DataGridView dataInput;
        private System.Windows.Forms.DataGridView frData;
        private System.Windows.Forms.DataGridView spData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Times_Appeared;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFr;
        private System.Windows.Forms.Label lblSpan;
        private System.Windows.Forms.Label lblEng;
    }
}

