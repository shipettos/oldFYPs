using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

namespace FYP
{
    public partial class MainForm : Form
    {
        public string name; //Gets the name of the player
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Are you sure you want to exit the game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(close==DialogResult.Yes)
            {
                this.Close();
            }
           
        }
        //Adds a sound effect
        private void Play()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.Fairy);
            player.Play();
        }

       //Click the Shapes Button
        private void simpleShapesButton_Click(object sender, EventArgs e)
        {
            Play();
            BoyBedroom boy = new BoyBedroom();
            boy.difficulty = "simple";
            boy.name = name;
            this.Visible = false;
            boy.ShowDialog();
            Thread.Sleep(2000);
            this.Close();

            
        }
        //Click the Complex Button
        private void complexShapesButton_Click(object sender, EventArgs e)
        {
            Play();
            BoyBedroom boy = new BoyBedroom();
            boy.difficulty = "complex";
            boy.name = name;
            this.Visible = false;
            boy.ShowDialog();
            this.Close();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void descriptionButton_Click(object sender, EventArgs e)
        {
            Play();
            BoyBedroom boy = new BoyBedroom();
            boy.difficulty = "description";
            boy.name = name;
            this.Visible = false;
            boy.ShowDialog();
            this.Close();     
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if ((nameTextBox.Text == ""))
            {
                DialogResult enterName = MessageBox.Show("Please enter your name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                name = nameTextBox.Text;
                simpleShapesButton.Visible = true;
                complexShapesButton.Visible = true;
                descriptionButton.Visible = true;
                enterButton.Enabled = false;
            }
        }
       
    }
}
