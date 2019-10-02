using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human tim = new Human("Tim");
            Human josh = new Human("Josh", 5, 5, 6, 5000);
            tim.Attack(josh);
            Console.WriteLine(josh.Health);
        }
    }
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health{
            get{
                return health;
            }
            set{
                health = value;
            }
        }
        public Human(string name){
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int str, int intell, int dex, int hp){
            Name = name;
            Strength = str;
            Intelligence = intell;
            Dexterity = dex;
            Health = hp;
        }
        // add a public "getter" property to access health
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        // Add a constructor to assign custom values to all fields
        // Build Attack method
        public int Attack(Human target)
        {
            target.Health -= 5*this.Strength;
            return target.Health;
        }
    }
}
