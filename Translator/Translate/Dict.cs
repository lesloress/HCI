using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Translate
{
    class Dict
    {
        public List<string[][]> words = new List<string[][]>
        {
            new string[][]
            {
                new string[] {"beauty", "good looks"},
                new string[] {"schönheit", "schöne", "anmut"},
                new string[] {"красота", "красавица"}
            },
            new string[][]
            {
                new string[] {"light", "shine" },
                new string[] {"leuchten", "scheinen" },
                new string[] {"свет", "освещение" }
            },
            new string[][]
            {
                new string[] {"weather" },
                new string[] {"Wetter"},
                new string[] {"погода"}
            },
            new string[][]
            {
                new string[] {"what is your name" },
                new string[] {"wie heißt du"},
                new string[] { "как тебя зовут" }
            }

        };
        
    }
}
