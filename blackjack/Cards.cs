using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Cards
    {
        public string name;
        public int number;
        public int value;
        public string color;
        public string type;

        public Cards(string nameOfCard, int numberOfCard, int valueOfCard, string colorOfCard, string typeOfCard) 
        {
            name = nameOfCard;
            number = numberOfCard;
            value = valueOfCard;
            color = colorOfCard;
            type = typeOfCard;
        }
    }
}
