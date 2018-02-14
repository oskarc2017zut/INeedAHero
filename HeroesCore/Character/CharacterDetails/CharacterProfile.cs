using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesCore.Character.CharacterDetails
{
    class CharacterProfile
    {
        public MainAbilities StartingMainAbilities { get; private set; }
        public MainAbilities CurrentMainAbilities { get; private set; }

        public SecondaryAbilities StartingSecondaryAbilities { get; private set; }
        public SecondaryAbilities CurrentSecondaryAbilities { get; private set; }
    }
}
