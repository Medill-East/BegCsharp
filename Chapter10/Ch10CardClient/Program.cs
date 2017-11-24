using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ch10CardLib;

namespace Ch10CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck mydeck = new Deck();
            mydeck.Shuffle();
            for(int i = 0;i < 52;++i)
            {
                Card tempCard = mydeck.GetCard(i);
                Write(tempCard.ToString());
                if(i!=51)
                {
                    Write(", ");
                }
                else
                {
                    WriteLine();
                }
            }
            ReadKey();
        }
    }
}
