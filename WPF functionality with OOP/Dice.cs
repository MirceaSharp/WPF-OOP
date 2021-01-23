using System;

namespace WPF_functionality_with_OOP
{
    class Dice
    {
        private int _numberOfSides;
        private int _value;
        private Random _randomNumber;

        public int NumberOfSides { get; set; }
        
            


        public int Value { get; set; }
        

        public Random RandomNumber { get; set; }

        public Dice(int numberOfSides, Random r)
        {
            NumberOfSides = numberOfSides;
            Value = 1;
            RandomNumber = r;

        }

        public Dice(Random r)
        {
            NumberOfSides = 6;
            Value = 1;
            RandomNumber = new Random();

        }


        public void Roll()
        {
            Value = RandomNumber.Next(1, NumberOfSides + 1);
        }




    }
}
