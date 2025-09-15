using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Brown_jaylen
{   //makes game class with veriables
    internal class Game
    {
        public string Title { get; }
        public char Esrb { get; }
        public string Genre { get; }
        //sets variables
        public Game(string titleParm, char esrbParam, string genreParam) 
        { 
            Title = titleParm;
            Esrb = esrbParam;
            Genre = genreParam;
        }

    }
}
