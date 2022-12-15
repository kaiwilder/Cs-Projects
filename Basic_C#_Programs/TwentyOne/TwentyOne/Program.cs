﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new TwentyOneGame(); //polymorphism
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Jill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();

            Deck deck = new Deck();
            deck.Shuffle(3);

            //int timesShuffled = 0;
            //deck = Shuffle(deck, out timesShuffled, times: 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0} ", timesShuffled);
            Console.ReadLine();
        }

        
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++) 
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
