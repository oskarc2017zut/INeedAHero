using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesCore.Character.CharacterDetails
{
    class PersonalDetails
    {
        public ushort Age { get; set; }
        public string Gender { get; set; }
        public string EyeColor { get; set; }
        public ushort Weight { get; set; }
        public string HairColor { get; set; }
        public ushort Height { get; set; }
        public string StartSign { get; set; }
        public string Birthpleace { get; set; }
        public List<string> DistinguishingMarks { get; set; }
    }
}
