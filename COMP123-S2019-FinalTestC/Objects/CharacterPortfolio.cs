﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Student name:Chuyun Yang
 * Student Id:301038102
 * description: This is the main container class for the applcation.
 */

namespace COMP123_S2019_FinalTestC.Objects
{
    public class CharacterPortfolio
    {
        //Identity
        public Identity Identity { get; set; }

        //characteristics
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }


        //Skill List
        List<Skill> Skills;

        //constructor
        CharacterPortfolio()
        {
            Skills = new List<Skill>();
            this.Identity = new Identity();
        }
    }
}
