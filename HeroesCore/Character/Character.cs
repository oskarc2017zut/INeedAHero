using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesCore.Character.CharacterDetails;
using UniversumCore.Items;
using UniversumCore;

namespace HeroesCore.Character
{
    class Character
    {
        //core
        public string Name { get; private set; }
        public Race Race { get; private set; }

        public uint CurrentExp { get; private set; }
        public uint TotalExp { get; private set; }

        public PersonalDetails PersonalDeaDetails { get; private set; }
        public CharacterProfile CharacterProfile { get; private set; }
        public List<Weapon> Weapons { get; private set; }
        public CharacterProfile Armour { get; private set; }

        public List<Skill> Skills { get; private set; }
        public List<Talent> Talents { get; private set; }
    }
}
