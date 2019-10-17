using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator.Translate
{
    class Word
    {
        string[] Eng { get; }
        string[] Ger { get; }
        string[] Rus { get; }
        public Word(string[] eng, string[] ger, string[] rus)
        {
            Eng = eng;
            Ger = ger;
            Rus = rus;
        }
    }
}
