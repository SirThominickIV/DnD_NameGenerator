using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DnD_Name_Generator
{
    public partial class Form1 : Form
    {
        //Form initialization
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = tb_Consonants;
        }

        //Variables
        List<String> ConsonantsList = new List<string>();       //A list containing all of the consonants
        List<String> VowelsList = new List<string>();           //A list containing all of the vowels
        List<bool> PatternList = new List<bool>();              //A list containing the pattern for consonants & vowels (true = con, false = vow)
        Random rng = new Random();                              //Need an RNG to figure out which cons/vowels to use
        String OutputName = "";                                 //The output string, needs storage because it is added to over time
        int PatternLength = 0;                                  //The length of the random pattern to generate

        //Clear buttons
        private void b_ClearConsonants_Click(object sender, EventArgs e)
        {
            rtb_Consonants.Text = "";
            ConsonantsList.Clear();
        }

        private void b_ClearVowels_Click(object sender, EventArgs e)
        {
            rtb_Vowels.Text = "";
            VowelsList.Clear();
        }

        private void b_ClearPattern_Click(object sender, EventArgs e)
        {
            rtb_Pattern.Text = "";
            PatternList.Clear();
        }

        private void b_ClearOutput_Click(object sender, EventArgs e)
        {
            rtb_Output.Text = "";
        }

        //Add consonant
        private void b_AddConsonant_Click(object sender, EventArgs e)
        {
            //Adding it to the rich text box display
            rtb_Consonants.Text += tb_Consonants.Text.ToUpper() + System.Environment.NewLine;
            //Adding it to variable storage
            ConsonantsList.Add(tb_Consonants.Text.ToUpper());
            //Clearing input field
            tb_Consonants.Text = "";
            this.ActiveControl = tb_Consonants;
        }

        //Add vowel
        private void b_AddVowel_Click(object sender, EventArgs e)
        {
            //Adding it to the rich text box display
            rtb_Vowels.Text += tb_Vowels.Text.ToUpper() + System.Environment.NewLine;
            //Adding it to variable storage
            VowelsList.Add(tb_Vowels.Text.ToUpper());
            //Clearing input field
            tb_Vowels.Text = "";
            this.ActiveControl = tb_Vowels;
        }

        //Add a consonant to the pattern
        private void b_AddConsonantPattern_Click(object sender, EventArgs e)
        {
            rtb_Pattern.Text += "Consonant" + System.Environment.NewLine;
            PatternList.Add(true);
        }

        //Add a vowel to the pattern
        private void b_AddVowelPattern_Click(object sender, EventArgs e)
        {
            rtb_Pattern.Text += "Vowel" + System.Environment.NewLine;
            PatternList.Add(false);
        }

        //Coming up with an actual name
        private void b_CreateName_Click(object sender, EventArgs e)
        {
            //First checking to make a new pattern
            if (cb_CreateMax.Checked)    { CreateMaxPattern(); }
            if (cb_CreateRandom.Checked) { CreateRandomPattern(); }

            //Go through the whole pattern
            foreach (bool LetterItem in PatternList){
                if (LetterItem) //If the letter item returns true, then it it is a consonant
                {
                    try { OutputName += ConsonantsList[rng.Next(ConsonantsList.Count)]; } catch (Exception ex) { }                    
                }
                else //Since it did not return true, this letter item is a vowel
                {
                    try { OutputName += VowelsList[rng.Next(VowelsList.Count)]; } catch (Exception ex) { }
                }
            }

            rtb_Output.Text += OutputName + System.Environment.NewLine;
            OutputName = "";
        }
        
        //Create pattern buttons
        private void bt_CreatePattern_Click(object sender, EventArgs e)
        {
            CreateMaxPattern();
        }

        
        private void b_CreateRandomSize_Click(object sender, EventArgs e)
        {
            CreateRandomPattern();
        }

        //Creating a random pattern
        public void CreateMaxPattern()
        {
            //Clearing the current pattern
            rtb_Pattern.Text = "";
            PatternList.Clear();

            //Finding out the length
            try
            {
                PatternLength = Int32.Parse(tb_PatternLength.Text);
            }
            catch (Exception ex)
            {
                rtb_Pattern.Text += "Error: That is not a valid pattern length" + System.Environment.NewLine;
                PatternLength = -1;
            }

            //Preventing too long of names
            if (PatternLength >= 1001 && PatternLength > 0)
            {
                rtb_Pattern.Text += "Error: That is not a valid pattern length" + System.Environment.NewLine;
            }
            else
            {
                //While there is still a number of letters left, add cons & vowels
                while (PatternLength >= 0)
                {
                    if (rng.Next(2) == 1)
                    {
                        //Adding consonant
                        rtb_Pattern.Text += "Consonant" + System.Environment.NewLine;
                        PatternList.Add(true);
                    }
                    else
                    {
                        //Adding vowel
                        rtb_Pattern.Text += "Vowel" + System.Environment.NewLine;
                        PatternList.Add(false);
                    }

                    PatternLength--;
                }
            }
        }

        //Creating a pattern of a random length
        public void CreateRandomPattern()
        {
            //Clearing the current pattern
            rtb_Pattern.Text = "";
            PatternList.Clear();

            //Finding out the length
            try
            {
                PatternLength = Int32.Parse(tb_PatternLength.Text);
            }
            catch (Exception ex)
            {
                rtb_Pattern.Text += "Error: That is not a valid pattern length" + System.Environment.NewLine;
                PatternLength = -1;
            }

            //Randomizing the length
            PatternLength = rng.Next(PatternLength);

            //Preventing too long of names
            if (PatternLength >= 1001 && PatternLength > 0)
            {
                rtb_Pattern.Text += "Error: That is not a valid pattern length" + System.Environment.NewLine;
            }
            else
            {
                //While there is still a number of letters left, add cons & vowels
                while (PatternLength >= 0)
                {
                    if (rng.Next(2) == 1)
                    {
                        //Adding consonant
                        rtb_Pattern.Text += "Consonant" + System.Environment.NewLine;
                        PatternList.Add(true);
                    }
                    else
                    {
                        //Adding vowel
                        rtb_Pattern.Text += "Vowel" + System.Environment.NewLine;
                        PatternList.Add(false);
                    }

                    PatternLength--;
                }
            }
        }

        //Making sure checkbox buttons don't desync
        private void cb_CreateMax_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_CreateMax.Checked) cb_CreateRandom.Checked = false;
        }

        private void cb_CreateRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_CreateRandom.Checked) cb_CreateMax.Checked = false;
        }

        private void menu_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are having trouble figuring out a name for a D&D character, or any character really, then this program might just help you. You give the program a list of consonants, vowels, and a pattern. It takes that, and randomly creates a name.");
        }

        private void menu_Github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SirThominickIV");
        }
    }    
}
