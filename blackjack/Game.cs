using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Game
    {
        public bool winOrLost;
        public int score;

        public Game()
        { 
            this.score = 0;
            this.winOrLost = false;
        }

        public void StartGame()
        {
            //hier moet de alle code komen om de blackjack werkend te hebben   
        }


        //wanneer de speler hit typt dan moet de speler een kaart erbij krijgen, wanneer de score van de dealer kleiner of gelijk is aan
        //16 moet de dealer hitten en de speler mag hitten wanneer zijn score onder de 21 is
        public void hitCard()
        {

        }


        //wanneer de speler pass typt gaat de beurt naar de dealer, als de score van de dealer boven 17 is moet de dealer passen
        public void passCard()
        {

        }

        //hier moet mijn functie komen die bepaald wie de winnaar is, de speler of de dealer
        public void WinOrLost()
        {

        }

        //misschien doe ik mijn
    }
}
