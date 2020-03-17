using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace bubblegumMachine
{
    class Dispenser
    {
        Bubblegum blueberry = new Bubblegum("Blueberry","Blue");
        Bubblegum blackberry = new Bubblegum("Blackberry", "Black");
        Bubblegum tuttifrutti = new Bubblegum("TuttiFrutti", "Yellow");
        Bubblegum orange = new Bubblegum("Orange", "Orange");
        Bubblegum strawberry = new Bubblegum("Strawberry", "Red");
        Bubblegum apple = new Bubblegum("Apple", "Green");

        public List<Bubblegum> Bubblegum = new List<Bubblegum>();

        private int blueberryAmount = 14;
        private int blackberryAmount = 7;
        private int tuttifruttiAmount = 11;
        private int orangeAmount = 10;
        private int strawberryAmount = 7;
        private int appleAmount = 6;

        Random rand = new Random();
        private int count = 55;
        public Bubblegum DrawRandomGum()
        {   
            int drawGum = rand.Next(0, count);
            Bubblegum gum = Bubblegum[drawGum];
            Bubblegum.RemoveAt(drawGum);
            count--;
            return gum;
            
        }

        public int CountBubblegum()
        {
            int count = Bubblegum.Count;
            return count;

        }
        
        public void FillDispenser()
        {
            FillBlueberry();
            FillBlackberry();
            FillTuttifrutti();
            FillOrange();
            FillStrawberry();
            FillApple();
        }


        public void FillBlueberry()
        {
            for (int i = 0; i < blueberryAmount; i++)
            {
                Bubblegum.Add(blueberry);
            }
        }

        public void FillBlackberry()
        {
            for (int i = 0; i < blackberryAmount; i++)
            {
                Bubblegum.Add(blackberry);
            }
        }

        public void FillTuttifrutti()
        {
            for (int i = 0; i < tuttifruttiAmount; i++)
            {
                Bubblegum.Add(tuttifrutti);
            }
        }

        public void FillOrange()
        {
            for (int i = 0; i < orangeAmount; i++)
            {
                Bubblegum.Add(orange);
            }
        }

        public void FillStrawberry()
        {
            for (int i = 0; i < strawberryAmount; i++)
            {
                Bubblegum.Add(strawberry);
            }
        }

        public void FillApple()
        {
            for (int i = 0; i < appleAmount; i++)
            {
                Bubblegum.Add(apple);
            }
        }
    }
}