using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalYearProject
{
    public partial class Form1 : Form
    {
        //Languages Lists
        List<node> englProfile = new List<node>();
        List<node> frProfile = new List<node>();
        List<node> spanProfile = new List<node>();

        //Input List
        List<node> inputProfile = new List<node>();



        string FILE_PATH = "";


        /// <summary>
        /// our struct that will help us count the occurances of a gram
        /// </summary>
        class node
        {
            string token;
            int timesOccured;

            
            public node() // constructor
            {
                token = "";
                timesOccured = 1;
            }


            public void increaseTimesOccured()
            {
                timesOccured++;
            }



            // Setters / Getters
            public void setTimesOcc(int times)
            {
                timesOccured = times;
            }

            public int getTimeOcc()
            {
                return timesOccured;
            }

            public void setToken(string tkn)
            {
                token = tkn;
            }

            public string getToken()
            {
                return token;
            }



        }


        /// <summary>
        /// creating the profile of the given language
        /// </summary>
        /// <param name="LBox"></param>
        /// <param name="list"></param>
        void createProfile(ListBox LBox, ref List<node> list)
        {
            for (int i = 0; i < LBox.Items.Count; i++)
            {
                int length = LBox.Items[i].ToString().Length;
                string currWord = LBox.Items[i].ToString();

                // the length of every word
                for (int j = 1; j < length; j++)
                {
                    split(currWord, j, ref list);
                }
            }
        }

        /// <summary>
        /// will split the text into a specific n gram
        /// </summary>
        /// <param name="word"></param>
        /// <param name="NGram"></param>
        void split(string word, int NGram, ref List<node> list)
        {
            //string element = LBWords.Items[k].ToString();
            string elmnt = word;

            int n = elmnt.Length;

            for (int i = 0; i <= n; i++) //character
            {
                string ngram = "";
                //LBNgrams.Items.Add(element[i].ToString());

                bool exc = false; // exception variable.

                for (int j = 1; j < n; j++)
                {
                    if (i + NGram < word.Length)
                        ngram = word.Substring(i, NGram);

                    addToList(ngram, ref list);
                }


            }
        }


        /// <summary>
        /// given the list and the token, it adds the token to the list
        /// responsible for the time occurances for each token
        /// </summary>
        /// <param name="ngram"></param>
        /// <param name="list"></param>
        void addToList(string ngram, ref List<node> list)
        {
            try
            {
                bool found = false;

                for (int i= 0; i<list.Count; i++)
                {
                    if (list[i].getToken() == ngram)
                    {
                        //int temp = list[i].timesOccured + 1;
                        Console.WriteLine(list[i].getToken() + " = " + ngram);
                        list[i].increaseTimesOccured();
                        found = true;
                    }
                }

                if (!found)
                {
                    node temp = new node();
                    temp.setToken(ngram);
                    list.Add(temp);
                }
            }
            catch
            {
                node temp = new node();
                temp.setTimesOcc(1);
                temp.setToken(ngram);
                list.Add(temp);
            }
           
        }


        /// <summary>
        /// on form load the profiles are being generated
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// this function takes a document in a .txt form and 
        /// split the words (tokens) in a list box.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="LBox"></param>
        void splitToTokens(string text, ref ListBox LBox)
        {
            StringReader reader = new StringReader(text);

            string[] tokens = reader.ReadToEnd().Split(' ');
            

            int lenght = tokens.Length;


            for (int i = 0; i < lenght; i++)
            {
                string temp;

                temp = tokens[i].Trim().ToLower();
                LBox.Items.Add(temp);
            }
        }

        /// <summary>
        /// this function will calculate the distance
        /// between 2 lists
        /// </summary>
        /// <param name="listA"></param>
        /// <param name="listB"></param>
        /// <returns></returns>
        int getDinstance(List<node> inputList, List<node> profileList)
        {
            int dinstance = 0;

            for (int i=0; i< inputList.Count; i++)
            {
                for (int j=0; j<profileList.Count; j++)
                {
                    if (inputList[i].getTimeOcc() == inputProfile[j].getTimeOcc())
                    {
                        dinstance = j - i;
                    }

                }
            }

            return dinstance;

        }




        /// <summary>
        /// On form load, it creates the profiles for each one of our language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {


            int timeToCompile = 0;

            //timeToCompile = 

            //                                              READING THE FILES
            //1. English Documents
            string doc1English = Properties.Resources.ENGL_A_diet_for_Better_Energy;
            string doc2English = Properties.Resources.ENGL_How_Nuclear_Power_Can_Stop_Global_Warming;
            string doc3English = Properties.Resources.ENGL_How_social_networks_can_destroy_your_social_life;
            string doc4English = Properties.Resources.ENGL_Rocket_Science;
            string doc5English = Properties.Resources.ENGL_Tank_Military_Vehicle;


            //2. French Documents
            string doc1French = Properties.Resources.FR_Comment_le_futur_de_l;
            string doc2French = Properties.Resources.FR_FUMEUR;
            string doc3French = Properties.Resources.FR_intelligence_artificielle;
            string doc4French = Properties.Resources.FR_régime_équilibré;
            string doc5French = Properties.Resources.FR_énergie_nucléaire;


            //3. Spanish Documents
            string doc1Spanish = Properties.Resources.SP_funciona_un_molino_de_viento;
            string doc2Spanish = Properties.Resources.SP_Hoja_de_Información_Sobre_el_Plomo;
            string doc3Spanish = Properties.Resources.SP_Mago_de_Oz_biografia;
            string doc4Spanish = Properties.Resources.SP_PROCESO_DE_PRODUCCIÓN_DEL_CAFÉ;
            string doc5Spanish = Properties.Resources.SP_Tecnología_que_mejora_la_calidad_de_vida;



            //                                      CREATING THE ENGLISH PROFILE
            //1. collect the english documents by words
            splitToTokens(doc1English, ref LBoxEngDoc1);
            splitToTokens(doc2English, ref LBoxEngDoc1);
            splitToTokens(doc3English, ref LBoxEngDoc1);
            splitToTokens(doc4English, ref LBoxEngDoc1);
            splitToTokens(doc5English, ref LBoxEngDoc1); 


            //2. Splitting it to N-Grams
             createProfile(LBoxEngDoc1, ref englProfile);

            //3. Sort them by the TimesOccured
            englProfile = englProfile.OrderByDescending(o => o.getTimeOcc()).ToList();

            //4. Show them to the table
            int count = 0;
            foreach (node element in englProfile)
            {
                engData.Rows.Add((count+1), englProfile[count].getToken(), "English", englProfile[count].getTimeOcc());
                count++;
            }


            //                                      CREATING THE FRENCH PROFILE
            //1. collect the french documents by words
            splitToTokens(doc1French, ref LBoxFrDoc);
            splitToTokens(doc2French, ref LBoxFrDoc);
            splitToTokens(doc3French, ref LBoxFrDoc);
            splitToTokens(doc4French, ref LBoxFrDoc);
            splitToTokens(doc5French, ref LBoxFrDoc);

            //2. Splitting it to N-Grams
            createProfile(LBoxFrDoc, ref frProfile);

            //3. Sort them by the TimesOccured
            frProfile = frProfile.OrderByDescending(o => o.getTimeOcc()).ToList();

            //4. Show them to the table
            count = 0;
            foreach (node element in frProfile)
            {
                frData.Rows.Add((count + 1), frProfile[count].getToken(), "French", frProfile[count].getTimeOcc());
                count++;
            }
            //                                      CREATING THE SPANISH PROFILE
            //1. collect the spanish documents by words
            splitToTokens(doc1Spanish, ref LBoxEngDoc1);
            splitToTokens(doc2Spanish, ref LBoxEngDoc1);
            splitToTokens(doc3Spanish, ref LBoxEngDoc1);
            splitToTokens(doc4Spanish, ref LBoxEngDoc1);
            splitToTokens(doc5Spanish, ref LBoxEngDoc1);

            //2. Splitting it to N-Grams
            createProfile(LBoxSpDoc, ref spanProfile);

            //3. Sort them by the TimesOccured
            spanProfile = spanProfile.OrderByDescending(o => o.getTimeOcc()).ToList();

            //4. Show them to the table
            count = 0;
            foreach (node element in frProfile)
            {
                spData.Rows.Add((count + 1), spanProfile[count].getToken(), "Spanish", spanProfile[count].getTimeOcc());
                count++;
            }

        }


        /// <summary>
        /// choosing a file to be searched
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdChooseFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";

            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = fileDialog.FileName;
                FILE_PATH = txtPath.Text;
                cmdIdentifyLanguage.Enabled = true;
            }

        }


        /// <summary>
        /// Try to identify the language of the given file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdIdentifyLanguage_Click(object sender, EventArgs e)
        {
            string inputDocument = System.IO.File.ReadAllText(FILE_PATH);
            int distanceEngl = 0;
            int distanceFr = 0;
            int distanceSp = 0;

            splitToTokens(inputDocument, ref LBInput);

            createProfile(LBInput, ref inputProfile);

            List<node> InputSorted = inputProfile.OrderByDescending(o => o.getTimeOcc()).ToList();

            int count = 0;
            foreach (node element in InputSorted)
            {
                dataInput.Rows.Add((count + 1), InputSorted[count].getToken(), InputSorted[count].getTimeOcc());
                count++;
            }

            distanceEngl = getDinstance(inputProfile, englProfile);
            distanceFr = getDinstance(inputProfile, frProfile);
            distanceSp = getDinstance(inputProfile, spanProfile);

            // find max

        }
    }
}
