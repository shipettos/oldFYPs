namespace FYP
{
    partial class Scores
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overall_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FYP.Properties.Resources.New_Picture;
            this.pictureBox1.Location = new System.Drawing.Point(427, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.Room1,
            this.Room2,
            this.Room3,
            this.Room4,
            this.Room5,
            this.Overall_Score});
            this.dataGridView.Location = new System.Drawing.Point(207, 329);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(932, 375);
            this.dataGridView.TabIndex = 2;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // Room1
            // 
            this.Room1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Room1.HeaderText = "Room 1";
            this.Room1.Name = "Room1";
            this.Room1.ReadOnly = true;
            // 
            // Room2
            // 
            this.Room2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Room2.HeaderText = "Room 2";
            this.Room2.Name = "Room2";
            this.Room2.ReadOnly = true;
            // 
            // Room3
            // 
            this.Room3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Room3.HeaderText = "Room 3";
            this.Room3.Name = "Room3";
            this.Room3.ReadOnly = true;
            // 
            // Room4
            // 
            this.Room4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Room4.HeaderText = "Room 4";
            this.Room4.Name = "Room4";
            this.Room4.ReadOnly = true;
            // 
            // Room5
            // 
            this.Room5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Room5.HeaderText = "Room 5";
            this.Room5.Name = "Room5";
            this.Room5.ReadOnly = true;
            // 
            // Overall_Score
            // 
            this.Overall_Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Overall_Score.HeaderText = "Overall Score";
            this.Overall_Score.Name = "Overall_Score";
            this.Overall_Score.ReadOnly = true;
            this.Overall_Score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FYP.Properties.Resources.web_shapes_pastel;
            this.ClientSize = new System.Drawing.Size(1382, 790);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Scores";
            this.Text = "Scores";
            this.Load += new System.EventHandler(this.Scores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overall_Score;
    }
}