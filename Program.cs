using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int healthProp
        {
            get
            {
                return health;
            }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Human has arrived!");
        }
    }
}
