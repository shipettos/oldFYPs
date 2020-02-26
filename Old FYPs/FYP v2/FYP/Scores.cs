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
    public partial class Scores : Form
    {
        public string difficulty = "";
        public List<int> scores = new List<int>();
        public string name;


        public Scores()
        {
            InitializeComponent();
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            string txtPath = "";

            if (difficulty == "simple")
            {              
                txtPath = "SimpleHighScores.txt";  
            }
            else if (difficulty == "complex")
            {               
                txtPath = "ComplexHighScores.txt";           
            }
            else if (difficulty == "description")
            {    
                txtPath = "DescriptionHighScores.txt";
            }

            System.IO.StreamReader rd = new System.IO.StreamReader(txtPath);


                //https://social.msdn.microsoft.com/Forums/vstudio/en-US/222f44e4-5427-48cf-aa2e-941ca146fd92/how-do-i-skip-blank-lines-when-reading-a-text-file?forum=csharpgeneral


            string[] lines = rd.ReadToEnd().TrimEnd().Split('\n');

            for (int i = 0; i <lines.Length; i++)      //row
            {
                //if (lines[i] == '\n'.ToString())
                //{
                    string[] scores = lines[i].Split(' ');
                    for (int j = 0; j < scores.Length; j++)     // column
                    {
                        try
                        {
                            int.Parse(scores[j]);
                            dataGridView.Rows.Add();
                            dataGridView.Rows[i].Cells[j + 1].Value = scores[j];

                        }
                        catch
                        {
                            dataGridView.Rows[i].Cells[0].Value = scores[j];
                        }
                    }
                //}

            }

           /* bool Empty = true;

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                Empty = true;
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null && dataGridView.Rows[i].Cells[j].Value.ToString() != "")
                    {
                        Empty = false;
                        break;
                    }
                }
                if (Empty)
                {
                    dataGridView.Rows.RemoveAt(i);
                }
            }*/
            rd.Close();
            dataGridView.Sort(dataGridView.Columns[6], ListSortDirection.Descending);

            for (int i =0; i<dataGridView.Rows.Count; i++)
            {
                for (int j = 0;j< dataGridView.Columns.Count; j++)
                {
                    int time = 0;
                    int seconds=0;
                    int minutes=0;
                    int hours=0;

                    try
                    {
                        time = int.Parse(dataGridView.Rows[i].Cells[j].Value.ToString());
                        seconds = time % 60;
                        minutes = (time / 60)%60;
                        hours = time / 3600;

                        //at the end,
                        dataGridView.Rows[i].Cells[j].Value = hours+":"+minutes+":"+seconds;
                    }
                    catch
                    {
                        //.l.
                    }
                   

                }
            }


        }
    }
}
