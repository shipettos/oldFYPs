namespace FYP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleShapesButton = new System.Windows.Forms.Button();
            this.complexShapesButton = new System.Windows.Forms.Button();
            this.descriptionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FYP.Properties.Resources.New_Picture__21_;
            this.pictureBox1.Location = new System.Drawing.Point(335, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // simpleShapesButton
            // 
            this.simpleShapesButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.simpleShapesButton.Font = new System.Drawing.Font("Valken", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleShapesButton.Location = new System.Drawing.Point(307, 507);
            this.simpleShapesButton.Name = "simpleShapesButton";
            this.simpleShapesButton.Size = new System.Drawing.Size(150, 59);
            this.simpleShapesButton.TabIndex = 1;
            this.simpleShapesButton.Text = "Simple Shapes";
            this.simpleShapesButton.UseVisualStyleBackColor = false;
            this.simpleShapesButton.Visible = false;
            this.simpleShapesButton.Click += new System.EventHandler(this.simpleShapesButton_Click);
            // 
            // complexShapesButton
            // 
            this.complexShapesButton.BackColor = System.Drawing.Color.MediumOrchid;
            this.complexShapesButton.Font = new System.Drawing.Font("Valken", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complexShapesButton.Location = new System.Drawing.Point(566, 507);
            this.complexShapesButton.Name = "complexShapesButton";
            this.complexShapesButton.Size = new System.Drawing.Size(150, 59);
            this.complexShapesButton.TabIndex = 2;
            this.complexShapesButton.Text = "Complex Shapes";
            this.complexShapesButton.UseVisualStyleBackColor = false;
            this.complexShapesButton.Visible = false;
            this.complexShapesButton.Click += new System.EventHandler(this.complexShapesButton_Click);
            // 
            // descriptionButton
            // 
            this.descriptionButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.descriptionButton.Font = new System.Drawing.Font("Valken", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionButton.Location = new System.Drawing.Point(811, 507);
            this.descriptionButton.Name = "descriptionButton";
            this.descriptionButton.Size = new System.Drawing.Size(150, 59);
            this.descriptionButton.TabIndex = 3;
            this.descriptionButton.Text = "Description Shapes";
            this.descriptionButton.UseVisualStyleBackColor = false;
            this.descriptionButton.Visible = false;
            this.descriptionButton.Click += new System.EventHandler(this.descriptionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.HotPink;
            this.exitButton.Font = new System.Drawing.Font("Valken", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(566, 610);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 51);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Valken", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(473, 379);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(300, 39);
            this.nameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Valken", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(330, 389);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 29);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name:";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.enterButton.Font = new System.Drawing.Font("Valken", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(811, 379);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(150, 39);
            this.enterButton.TabIndex = 7;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FYP.Properties.Resources.web_shapes_pastel;
            this.ClientSize = new System.Drawing.Size(1276, 774);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.descriptionButton);
            this.Controls.Add(this.complexShapesButton);
            this.Controls.Add(this.simpleShapesButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Hidden Shapes Game!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button simpleShapesButton;
        private System.Windows.Forms.Button complexShapesButton;
        private System.Windows.Forms.Button descriptionButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button enterButton;
    }
}

