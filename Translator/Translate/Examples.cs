using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Translate
{
    class Examples
    {
        public List<string[][]> examples = new List<string[][]>
        {
            new string[][]
            {
                new string[] {"beauty", "good looks"},
                new string[] {"Меня восхищает красота нашей природы.",
                              "Красавица гуляла по бульвару."}
            },
            
            new string[][]
            {
                new string[] {"красота", "красавица"},
                new string[] {"Beauty - is the main part of Hollywood stars.",
                              "My sister is beauty."}
            },
         
            new string[][]
            {
                new string[] {"weather" },
                new string[] {"Погода в Париже была дождливой.",
                             "Люблю ветреную погоду."},
                
            },

            
            new string[][]
            {
                new string[] {"погода" },
                new string[] {"The weather is nice.",
                             "Yesterday was the worst weather ever."},

            }


        };

    }
}
