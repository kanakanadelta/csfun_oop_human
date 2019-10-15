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

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
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

        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = hp;
        }

        public int Attack(Human target)
        {
            target.Health = target.Health - Strength;
            System.Console.WriteLine($"{Name} attacks {target.Name}");
            return target.Health;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Human has arrived!");
            Human guy = new Human("guy", 5, 5, 5, 100);
            Human dude = new Human("dude");
            guy.Attack(dude);
            System.Console.WriteLine($"{dude.Name} has {dude.Health}hp");
        }
    }
}
