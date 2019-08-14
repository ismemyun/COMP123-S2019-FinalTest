using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGeneratorForm : COMP123_S2019_FinalTestC.Views.MasterForm
    {
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();


        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        //This is event handler for GenerateNameButton Click event.
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            //List<string> firstNames = new List<string>();
            //List<string> lastNames = new List<string>();
            //try
            //{
            //    //Open the stream for reading
            //    using (StreamReader firstNameInputStream = new StreamReader(
            //        File.Open("../../Data/firstNames.txt", FileMode.Open)))
            //    {
            //        while (firstNameInputStream.ReadLine() != null )
            //        {
            //            firstNames.Add(firstNameInputStream.ReadLine());
            //        }


            //        //cleanup
            //        firstNameInputStream.Close();
            //        firstNameInputStream.Dispose();
            //    }
            //    using (StreamReader lastInputStream = new StreamReader(
            //        File.Open("../../Data/lastNames.txt", FileMode.Open)))
            //    {
            //        while (lastInputStream.ReadLine() != null)
            //        {
            //            lastNames.Add(lastInputStream.ReadLine());
            //        }


            //        //cleanup
            //        lastInputStream.Close();
            //        lastInputStream.Dispose();
            //    }
            //}
            //catch (IOException exception)
            //{
            //    Debug.WriteLine("ERROR:" + exception.Message);
            //    MessageBox.Show("ERROR" + exception.Message, "ERROR",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            ////assign random Firstname and Lastname
            //Random random = new Random();
            //int indexOffirstName = random.Next(0, firstNames.Count + 1);
            //int indexOfflastName = random.Next(0, lastNames.Count + 1);
            //FirstNameDataLabel.Text = firstNames[indexOffirstName];
            //LastNameDataLabel.Text = lastNames[indexOfflastName];

        }

        //This is a event handler for CharacterGeneratorForm_Load event.
        private void CharacterGeneratorForm_Load(object sender, EventArgs e)
        {
            LoadNames();
            GenerateNames();
            Program.identity.FirstName = FirstNameDataLabel.Text;
            Program.identity.LastName = LastNameDataLabel.Text;

            GenerateNumber();
            Program.skill.Name = StrengthLabel.Text;
            Program.skill.Level = Convert.ToInt32(StrengthDataLabel.Text);
            Program.skill.Name = DexterityLabel.Text;
            Program.skill.Level = Convert.ToInt32(DexterityDataLabel.Text);
            Program.skill.Name = EnduranceLabel.Text;
            Program.skill.Level = Convert.ToInt32(EnduranceDataLabel.Text);
            Program.skill.Name = IntellectLabel.Text;
            Program.skill.Level = Convert.ToInt32(IntellectDataLabel.Text);
            Program.skill.Name = EducationLabel.Text;
            Program.skill.Level = Convert.ToInt32(EducationDataLabel.Text);
            Program.skill.Name = SocialStandingLabel.Text;
            Program.skill.Level = Convert.ToInt32(SocialStandingDataLabel.Text);

        }

        //This is LoadNames method for loading firstname and lastname from txt file.
        private void LoadNames()
        {
            //List<string> firstNames = new List<string>();
            //List<string> lastNames = new List<string>();
            try
            {
                //Open the stream for reading
                using (StreamReader firstNameInputStream = new StreamReader(
                    File.Open("../../Data/firstNames.txt", FileMode.Open)))
                {
                    while (firstNameInputStream.ReadLine() != null)
                    {
                        firstNames.Add(firstNameInputStream.ReadLine());
                    }


                    //cleanup
                    firstNameInputStream.Close();
                    firstNameInputStream.Dispose();
                }
                using (StreamReader lastInputStream = new StreamReader(
                    File.Open("../../Data/lastNames.txt", FileMode.Open)))
                {
                    while (lastInputStream.ReadLine() != null)
                    {
                        lastNames.Add(lastInputStream.ReadLine());
                    }


                    //cleanup
                    lastInputStream.Close();
                    lastInputStream.Dispose();
                }
            }
            catch (IOException exception)
            {
                Debug.WriteLine("ERROR:" + exception.Message);
                MessageBox.Show("ERROR" + exception.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //assign random Firstname and Lastname
        }

        //This is GenerateNames method for generating random firstname and lastname.
        private void GenerateNames()
        {
            Random random = new Random();
            int indexOffirstName = random.Next(0, firstNames.Count + 1);
            int indexOfflastName = random.Next(0, lastNames.Count + 1);
            FirstNameDataLabel.Text = firstNames[indexOffirstName];
            LastNameDataLabel.Text = lastNames[indexOfflastName];
        }

        //This is a event handler for CharacterGeneratorForm_FormClosing evetn.
        private void CharacterGeneratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //This is GenerateNumber method for generating random number for abilities.
        private void GenerateNumber()
        {
            Random random = new Random();
            int strengthLevel = random.Next(1, 16);
            StrengthDataLabel.Text = strengthLevel.ToString();
            int dexterityLevel = random.Next(1, 16);
            DexterityDataLabel.Text = dexterityLevel.ToString();
            int enduranceLevel = random.Next(1, 16);
            EnduranceDataLabel.Text = enduranceLevel.ToString();
            int intellectLevel = random.Next(1, 16);
            IntellectDataLabel.Text = intellectLevel.ToString();
            int educationLevel = random.Next(1, 16);
            EducationDataLabel.Text = educationLevel.ToString();
            int socialStandingLevel = random.Next(1, 16);
            SocialStandingDataLabel.Text = socialStandingLevel.ToString();
        }

        //This is a event handler for GenerateAbilityButton_Click event.
        private void GenerateAbilityButton_Click(object sender, EventArgs e)
        {
            GenerateNumber();
        }
    }
}
