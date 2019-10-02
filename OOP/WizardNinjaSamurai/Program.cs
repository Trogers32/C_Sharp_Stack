using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard w1 = new Wizard("Tom");
            Wizard w2 = new Wizard("Tim");
            Ninja n1 = new Ninja("Frank");
            Samurai s1 = new Samurai("Josh");
            // w1.Attack(w2);
            s1.Attack(w1);
            n1.Attack(s1);
        }
    }
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        public int health
        {
            get { return Health; }
            set { Health = value; }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
    class Wizard : Human{
        public Wizard(string name) : base(name,3,25,3,50){}
        public override int Attack(Human target){
            int dmg = Intelligence * 5;
            health += dmg;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and healed for {dmg}!");
            return target.health;
        }
        public int Heal(Human target){
            int hea = Intelligence * 10;
            target.health += hea;
            Console.WriteLine($"{target.Name} was healed for {hea} points of damage!");
            return target.health;
        }
    }
    class Ninja : Human{
        public Ninja(string name) : base(name, 3,3,175,100){
        }
        public override int Attack(Human target){
            Random rand = new Random();
            int r = rand.Next(1, 100);
            int dmg;
            if(r>20){
                dmg = Dexterity * 5;
            } else {
                dmg = Dexterity * 5 + 10;
            }
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public void Steal(Human target){
            target.health -= 5;
            health += 5;
            Console.WriteLine($"{Name} stole 5 health from {target.Name}!");
        }
    }
    class Samurai : Human{
        public Samurai(string name) : base(name, 3,3,3,200){
        }
        public override int Attack(Human target){
            base.Attack(target);
            if(target.health < 50){
                target.health = 0;
                Console.WriteLine($"{target.Name} was executed!");
            } else {
                Console.WriteLine(target.health);
            }
            return target.health;
        }
        public void Meditate(){
            health = 200;
            Console.WriteLine($"{Name} meditated and put themselves to full health!");
        }
    }
}
