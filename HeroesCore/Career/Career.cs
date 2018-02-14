using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesCore.Character.CharacterDetails;

namespace HeroesCore.Career
{
    class Career
    {
        public Character.CharacterDetails.MainAbilities ExplicationMainAbilities;
        public Character.CharacterDetails.SecondaryAbilities ExplicatioSecondaryAbilities;

        public List<Skill> Skills;
        public List<Talent> Talents;

        public string Description;

        public List<Career> EntryCareers;
        public List<Career> OutCareers;
    }
}
