using COMP123_S2019_FinalTestC.Objects;
using COMP123_S2019_FinalTestC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Student name:Chuyun Yang
 * Student Id:301038102
 * description: The project that generates the first few pages of a Role-Playing Game Character..
 */
namespace COMP123_S2019_FinalTestC
{
    public static class Program
    {
        //static members
        public static CharacterGeneratorForm characterForm;
        public static CharacterPortfolio character;
        public static Identity identity;
        public static Skill skill;
        public static AboutForm aboutForm;




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //instanticate all forms here
            characterForm = new CharacterGeneratorForm();
            identity = new Identity();
            skill = new Skill();
            character = new CharacterPortfolio();
            aboutForm = new AboutForm();
            Application.Run(characterForm);
        }
    }
}
