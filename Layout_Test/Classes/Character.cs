using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layout_Test
{
    public class Character
    {
        public List<Character> lstChar = new List<Character>();
        public List<Character> Get_lstChar() { return lstChar; }

        public string charName { get; set; }
        public string player { get; set; }
        public CharacterClass charClass { get; set; }
        public int experience { get; set; }
        public string alignment { get; set; }

        public int charCarryWeight { get; set; }

            public class CharacterClass 
            {
                public string name { get; set; }
                public string blurb { get; set; }
                public string race { get; set; }
                public List<Attribute> attributes { get; set; }

                public class Attribute
                {
                    public int attribute { get; set; }
                    public int modifier { get; set; }
                    public List<Attribute> subAttributes { get; set; }
                }
            }
    }


}
