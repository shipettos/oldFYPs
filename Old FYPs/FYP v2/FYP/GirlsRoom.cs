using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class GirlsRoom : Form
    {

        // takes the thime of each player and stores it in a file
        int seconds = 0;
        int minuts = 0;
        int hours = 0;

        int overallSeconds = 0;


        const int NumberOfCorrectAnswers = 1;
        int count_correct;
        string selectedShape;
        public List<string> simpleShapesList = new List<string>();
        public List<string> complexShapesList = new List<string>();
        public List<string> descriptionShapesList = new List<string>();
        public List<int> scores = new List<int>();
        public string name;

        public string difficulty = "";

        public GirlsRoom()
        {
            InitializeComponent();
        }
        //Controls if complex button is clicked
        public void setDifficultySimple()
        {
            //Picking a random shape in the list
            Random rand = new Random();
            int random = rand.Next(0, simpleShapesList.Count);

            selectedShape = simpleShapesList[random];
            simpleShapesList.RemoveAt(random);
            instructionLabel.Text = "Find " + NumberOfCorrectAnswers + " " + selectedShape + "s";
        }
        public void setDifficultyComplex()
        {

            var girlPictureboxes = this.Controls.OfType<PictureBox>();
            foreach (var pic in girlPictureboxes)
            {
                if (pic.Name.ToLower().Contains("heart") || (pic.Name.ToLower().Contains("star")) || (pic.Name.ToLower().Contains("pentagon")) || (pic.Name.ToLower().Contains("hexagon")) || (pic.Name.ToLower().Contains("octagon")))
                {
                    pic.Visible = true;
                }
            }

            Random rand = new Random();
            int randomComplex = rand.Next(0, complexShapesList.Count);
            selectedShape = complexShapesList[randomComplex];
            complexShapesList.RemoveAt(randomComplex);
            instructionLabel.Text = "Find " + NumberOfCorrectAnswers + " " + selectedShape + "s";

        }

        public void setDifficultyDescription()
        {
            var girlPictureboxes = this.Controls.OfType<PictureBox>();
            foreach (var pic in girlPictureboxes)
            {
                if (pic.Name.ToLower().Contains("heart") || (pic.Name.ToLower().Contains("star")) || (pic.Name.ToLower().Contains("pentagon")) || (pic.Name.ToLower().Contains("hexagon")) || (pic.Name.ToLower().Contains("octagon")))
                {
                    pic.Visible = true;
                }
            }

            Random rand = new Random();
            int randomDescription = rand.Next(0, descriptionShapesList.Count);
            selectedShape = descriptionShapesList[randomDescription];
            descriptionShapesList.RemoveAt(randomDescription);
            DescriptionFunction(NumberOfCorrectAnswers);
        }
        void DescriptionFunction(int number)
        {
            string text = "";

            switch (selectedShape)
            {
                case "circle":
                    {
                        if (number == 1)
                        {
                            text = " rounded shape\n with no angles";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        else if (number == 0)
                        {
                            instructionLabel.Text = "You found them!";
                        }
                        else
                        {
                            text = " rounded shapes\n with no angles";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        break;
                    }

                case "square":
                    {
                        if (number == 1)
                        {
                            text = " shape with\n four equal sides\n and four equal corners";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        else if (number == 0)
                        {
                            instructionLabel.Text = "You found them!";
                        }
                        else
                        {
                            text = " shapes with\n four equal sides\n and four equal corners";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        break;
                    }
                case "rectangle":
                    {
                        if (number == 1)
                        {
                            text = " shape with\n four equal corners\n but no equal sides";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        else if (number == 0)
                        {
                            instructionLabel.Text = "You found them!";
                        }
                        else
                        {
                            text = " shape with\n four equal corners\n but no equal sides";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        break;
                    }

                case "hexagon":
                    {
                        if (number == 1)
                        {
                            text = " shape with\n six angles";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        else if (number == 0)
                        {
                            instructionLabel.Text = "You found them!";
                        }
                        else
                        {
                            text = " shapes with\n six angles";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        break;
                    }
                case "octagon":
                    {
                        if (number == 1)
                        {
                            text = " shape with\n eight angles";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        else if (number == 0)
                        {
                            instructionLabel.Text = "You found them!";
                        }
                        else
                        {
                            text = " shapes with\n eight angles";
                            instructionLabel.Text = "Find " + number + text;

                        }
                        break;
                    }
                case "pentagon":
                    {
                        if (number == 1)
                        {
                            text = " shape with\n five angles";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        else if (number == 0)
                        {
                            instructionLabel.Text = "You found them!";
                        }
                        else
                        {
                            text = " shapes with\n five angles";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        break;
                    }
                case "triangle":
                    {
                        if (number == 1)
                        {
                            text = " shape with\n three angles and\n three sides";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        else if (number == 0)
                        {
                            instructionLabel.Text = "You found them!";
                        }
                        else
                        {
                            text = " shapes with\n three angles and\n three sides";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        break;
                    }
                case "diamond":
                    {
                        if (number == 1)
                        {
                            text = " shape that\n looks like a\n sided square";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        else if (number == 0)
                        {
                            instructionLabel.Text = "You found them!";
                        }
                        else
                        {
                            text = " shapes that\n looks like a\n sided square";
                            instructionLabel.Text = "Find " + number + text;
                        }
                        break;
                    }
            }
        }
        private void Wrong()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.Wrong);
            player.Play();
        }
        private void Correct()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.Correct);
            player.Play();
            count_correct++;

            if ((difficulty == "simple") || (difficulty == "complex"))
            {
                if ((NumberOfCorrectAnswers - count_correct) == 1)
                    instructionLabel.Text = "Find " + (NumberOfCorrectAnswers - count_correct) + " " + selectedShape;

                else if ((NumberOfCorrectAnswers - count_correct) == 0)
                    instructionLabel.Text = "You found them!";

                else
                    instructionLabel.Text = "Find " + (NumberOfCorrectAnswers - count_correct) + " " + selectedShape + "s";
            }
            else
            {
                DescriptionFunction(NumberOfCorrectAnswers - count_correct);
            }

            if (count_correct == NumberOfCorrectAnswers)
            {
                girlNextButton.Visible = true;
                scores.Add(overallSeconds);
            }
        }
        private void shape_click(object sender, EventArgs e)
        {
            var shape = sender as PictureBox;
            if (shape.Name.ToLower().Contains(selectedShape))
            {
                Correct();
                shape.Visible = false;
            }
            else
            {
                Wrong();
            }
        }

        private void girlBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.ShowDialog();
            
        }
        private void Play()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.Fairy);
            player.Play();
        }
        private void girlNextButton_Click(object sender, EventArgs e)
        {
            Play();
            this.Hide();
            if (difficulty == "simple")
            {
                Bathroom bathroom = new Bathroom();
                bathroom.simpleShapesList = simpleShapesList;
                bathroom.difficulty = "simple";
                bathroom.name = name;
                bathroom.scores = scores;
                bathroom.ShowDialog();
                this.Visible = false;

            }
            else
                if (difficulty == "complex")
                {
                    Bathroom bathroom = new Bathroom();
                    bathroom.complexShapesList = complexShapesList;
                    bathroom.difficulty = "complex";
                    bathroom.name = name;
                    bathroom.scores = scores;
                bathroom.ShowDialog();
                this.Visible = false;

            }
                else
                    if (difficulty == "description")
                    {
                        Bathroom bathroom = new Bathroom();
                        bathroom.descriptionShapesList = descriptionShapesList;
                        bathroom.difficulty = "description";
                        bathroom.name = name;
                        bathroom.scores = scores;
                        bathroom.ShowDialog();
                this.Visible = false;
                    }
            this.Close();
        }

        private void catPictureBox_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.Meow);
            player.Play();
        }

        private void bearPictureBox_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.Toy);
            player.Play();
        }

        private void toyPictureBox_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.Toy);
            player.Play();
        }

        private void cdplayerPictureBox_Click(object sender, EventArgs e)
        {
            if (notesPictureBox.Visible == false)
            {
                notesPictureBox.Visible = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.TeenageDream);
                player.Play();
            }
            else
            {
                notesPictureBox.Visible = false;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(FYP.Properties.Resources.TeenageDream);
                player.Stop();
            }
        }

        private void GirlsRoom_Load(object sender, EventArgs e)
        {
            timer.Start();
            if (difficulty == "simple")
                setDifficultySimple();
            else if (difficulty == "complex")
                setDifficultyComplex();
            else if (difficulty == "description")
                setDifficultyDescription();
        }

        //timer
        private void timer_Tick(object sender, EventArgs e)
        {
            string sTime = "";
            string mTime = "";
            string hTime = "";

            if (seconds < 60)
            {
                if (seconds < 9)
                    sTime = "0";

                if (minuts < 9)
                    mTime = "0";

                if (hours < 9)
                    hTime = "0";

                seconds++;
            }
            if (seconds == 60)
            {
                seconds = 0;
                sTime = "0";
                minuts++;
            }

            if (minuts == 60)
            {
                seconds = 0;
                minuts = 0;
                mTime = "0";
                hours++;
            }
            overallSeconds++;
            timerLabel.Text = hTime + hours + ":" + mTime + minuts + ":" + sTime + seconds;
        }
        public void initializeForm()
        {
            
        }
    }
}
