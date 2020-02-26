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
        List<string> englishList = new List<string>();
        List<string> frenchList = new List<string>();
        List<string> spanishList = new List<string>();

        Dictionary<int, node> englDictionary = new Dictionary<int, node>();
        Dictionary<int, node> frDictionary = new Dictionary<int, node>();
        Dictionary<int, node> spanDictionary = new Dictionary<int, node>();

        //Input List
        List<string> inputProfile = new List<string>();
        Dictionary<int, node> inputDictionary = new Dictionary<int, node>();

        int englIndex = 0;
        int frIndex = 0;
        int spIndex = 0;
        int inputIndex = 0;




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
        /// will split the text into a specific n gram
        /// </summary>
        /// <param name="word"></param>
        /// <param name="NGram"></param>
        void split(string word, int NGram, ref Dictionary<int, node> dictionary, ref DataGridView data, ref int index)
        {

            string ngram = "";
            for (int i = 1; i < word.Length; i++) //character
            {

                for (int j = 1; j < word.Length; j++)
                {
                    if (i + NGram < word.Length)
                        ngram = word.Substring(i, NGram);

                }
 
                    addToList(ngram, ref dictionary, ref data, ref index);



            }
        }


        /// <summary>
        /// given the list and the token, it adds the token to the list
        /// responsible for the time occurances for each token
        /// </summary>
        /// <param name="ngram"></param>
        /// <param name="list"></param>
        void addToList(string ngram, ref Dictionary<int, node> dictionary, ref DataGridView data, ref int index)
        {
            try
            {
                bool found = false;

                foreach (var key in dictionary)
                {
                    if (key.Value.getToken() == ngram)
                    {
                        key.Value.increaseTimesOccured();
                        data.Rows[key.Key].Cells[3].Value = key.Value.getTimeOcc();
                        found = true;
                    }
                
                 }

                if (!found)
                {
                    node temp = new node();
                    temp.setToken(ngram);
                    index++;
                    data.Rows.Add(index, ngram, "", 1);
                    dictionary.Add(index, temp);
                }
            }
            catch
            {
                node temp = new node();
                temp.setTimesOcc(1);
                temp.setToken(ngram);
                index++;
                data.Rows.Add(index, ngram, "", 1);
                dictionary.Add(index, temp);
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
        void splitToTokens(string text, ref Dictionary<int, node> dictionary, ref DataGridView data, ref int index)
        {
            StringReader reader = new StringReader(text);

            string[] tokens = reader.ReadToEnd().Split(' ');

            string temp;

            for (int i = 0; i < tokens.Length; i++)
            {

                temp = tokens[i].Trim().ToLower();

                //new try 27/7
                for (int j = 0; j < temp.Length; j++)
                    split(temp, j, ref dictionary, ref data, ref index);

            }
        }

        /// <summary>
        /// this function will calculate the distance
        /// between 2 lists
        /// </summary>
        /// <param name="listA"></param>
        /// <param name="listB"></param>
        /// <returns></returns>
        int getDinstance(Dictionary<int, node> inputDict, Dictionary<int, node> checkDict)
        {
            int dinstance = 0;

            for (int i=0; i< inputDict.Count; i++)
            {
                for (int j=0; j<checkDict.Count; j++)
                {
                    if (inputDict[i].getTimeOcc() == inputDict[j].getTimeOcc())
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

            string docAllEnglish = doc1English +" " + doc2English + " " +doc3English + " " + doc4English + " " + doc5English;
            splitToTokens(docAllEnglish, ref englDictionary, ref engData, ref englIndex);
            


            //                                      CREATING THE FRENCH PROFILE
            //1. collect the french documents by words

            string docAllFrench = doc1French + " " + doc1French + " " + doc1French + " " + doc1French + " " + doc1French;
            splitToTokens(doc1French, ref frDictionary, ref frData, ref frIndex);



            //                                      CREATING THE SPANISH PROFILE
            //1. collect the spanish documents by words
            string docAllSpanish = doc1Spanish + " " + doc1Spanish + " " + doc1Spanish + " " + doc1Spanish + " " + doc1Spanish;
            splitToTokens(docAllSpanish, ref spanDictionary, ref spData, ref spIndex);
            


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
            int dinstancEngl = 0;
            int dinstanceFr = 0;
            int dinstanceSp = 0;


            string inputDocument = System.IO.File.ReadAllText(FILE_PATH);

            splitToTokens(inputDocument, ref inputDictionary, ref dataInput, ref inputIndex);

            dinstancEngl = getDinstance(inputDictionary, englDictionary);
            dinstanceSp = getDinstance(inputDictionary, spanDictionary);
            dinstanceFr = getDinstance(inputDictionary, frDictionary);


        }

    }
}
