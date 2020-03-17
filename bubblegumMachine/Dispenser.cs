using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace bubblegumMachine
{
    /// <summary>
    /// denne klasse opretter en dispenser,
    /// som består af 55 bubble gum objekter
    /// </summary>
    class Dispenser
    {
        // her oprettes mine bubblegum objekter
        Bubblegum blueberry = new Bubblegum("Blueberry", "Blue");
        Bubblegum blackberry = new Bubblegum("Blackberry", "Black");
        Bubblegum tuttifrutti = new Bubblegum("TuttiFrutti", "Yellow");
        Bubblegum orange = new Bubblegum("Orange", "Orange");
        Bubblegum strawberry = new Bubblegum("Strawberry", "Red");
        Bubblegum apple = new Bubblegum("Apple", "Green");

        // her oprettes min liste som jeg kan gemme objekter i
        public List<Bubblegum> Bubblegum = new List<Bubblegum>();

        // private in variabler så jeg ved hvor mange af hvert objekt der skal oprettes
        // til brug nede i mine metoder
        private int blueberryAmount = 14;
        private int blackberryAmount = 7;
        private int tuttifruttiAmount = 11;
        private int orangeAmount = 10;
        private int strawberryAmount = 7;
        private int appleAmount = 6;

        Random rand = new Random();
        private int count = 55;
        // denne metode trækker et tilfældigt bubblegum objekt og returnerer det
        public Bubblegum DrawRandomGum()
        {
            int drawGum = rand.Next(0, count);
            Bubblegum gum = Bubblegum[drawGum];
            Bubblegum.RemoveAt(drawGum);
            count--;
            return gum;

        }
        // denne metode returnerer hvor mange bubble gum objekter der er tilbage
        public int CountBubblegum()
        {
            int count = Bubblegum.Count;
            return count;

        }

        // denne metode fylder min liste med bubble gum objekter så der er 55 i alt
        public void FillDispenser()
        {
            FillBlueberry();
            FillBlackberry();
            FillTuttifrutti();
            FillOrange();
            FillStrawberry();
            FillApple();
        }

        // denne metode opretter blueberry objekter
        public void FillBlueberry()
        {
            for (int i = 0; i < blueberryAmount; i++)
            {
                Bubblegum.Add(blueberry);
            }
        }
        // denne metode opretter blackberry objekter
        public void FillBlackberry()
        {
            for (int i = 0; i < blackberryAmount; i++)
            {
                Bubblegum.Add(blackberry);
            }
        }

        // denne metode opretter tuttifrutti objekter
        public void FillTuttifrutti()
        {
            for (int i = 0; i < tuttifruttiAmount; i++)
            {
                Bubblegum.Add(tuttifrutti);
            }
        }

        // denne metode opretter Orange objekter
        public void FillOrange()
        {
            for (int i = 0; i < orangeAmount; i++)
            {
                Bubblegum.Add(orange);
            }
        }

        // denne metode opretter Strawberry objekter
        public void FillStrawberry()
        {
            for (int i = 0; i < strawberryAmount; i++)
            {
                Bubblegum.Add(strawberry);
            }
        }

        // denne metode returnerer Apple objekter
        public void FillApple()
        {
            for (int i = 0; i < appleAmount; i++)
            {
                Bubblegum.Add(apple);
            }
        }
    }
}