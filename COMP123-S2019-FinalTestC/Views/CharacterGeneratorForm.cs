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

        private void CharacterGeneratorForm_Load(object sender, EventArgs e)
        {
            LoadNames();
            GenerateNames();
        }
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
        private void GenerateNames()
        {
            Random random = new Random();
            int indexOffirstName = random.Next(0, firstNames.Count + 1);
            int indexOfflastName = random.Next(0, lastNames.Count + 1);
            FirstNameDataLabel.Text = firstNames[indexOffirstName];
            LastNameDataLabel.Text = lastNames[indexOfflastName];
        }

        private void CharacterGeneratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
