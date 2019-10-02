using System;
using System.Collections.Generic;

namespace IronNinja
{
//////////////////////////////////////////////////////////////
    class Program
    {
        static void Main(string[] args)
        {
            Buffet b1 = new Buffet();
            SweetTooth tim = new SweetTooth();
            SpiceHound Josh = new SpiceHound();
            tim.Consume(b1.Serve());
            tim.Consume(b1.Serve());
            tim.Consume(b1.Serve());
            Josh.Consume(b1.Serve());
            Josh.Consume(b1.Serve());
            Josh.Consume(b1.Serve());
            tim.Consume(b1.Serve());
            tim.Consume(b1.Serve());
            tim.Consume(b1.Serve());
            Josh.Consume(b1.Serve());
            Josh.Consume(b1.Serve());
            Josh.Consume(b1.Serve());
        }
    }
//////////////////////////////////////////////////////////////
    interface IConsumable
    {
        string Name {get;set;}
        int Calories {get;set;}
        bool IsSpicy {get;set;}
        bool IsSweet {get;set;}
        string GetInfo();
    }  
//////////////////////////////////////////////////////////////
    class Food : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo()
        {
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }  
//////////////////////////////////////////////////////////////
    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo()
        {
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Drink(string name, int calories, bool spicy, bool sweet = true)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
        
        // Implement a GetInfo Method
        // Add a constructor method
    } 
//////////////////////////////////////////////////////////////
    class Buffet
    {
        public List<Food> Menu;
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Candy", 1000, false, true),
                new Food("Curry", 100, true, false),
                new Food("Bread", 10, false, false),
                new Food("Spit", 10000, true, false),
                new Food("Soda", 10000000, false, true),
                new Food("Candy", 1000, false, true),
                new Food("Curry", 100, true, false),
                new Food("Bread", 10, false, false),
                new Food("Spit", 10000, true, false),
                new Food("Soda", 10000000, false, true)
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0,5)];
        }
    }
//////////////////////////////////////////////////////////////
    abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumptionHistory;
        public Ninja()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull {get;set;}
        public abstract void Consume(IConsumable item);
    }
//////////////////////////////////////////////////////////////
    class SweetTooth : Ninja
    {
        public SweetTooth() : base(){}
        public bool isFull;
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull{get{return isFull;}set{isFull = value;}}
        public override void Consume(IConsumable item)
        {
            if(calorieIntake > 1500){
                IsFull = true;
            } else {
                IsFull = false;
            }
            if(IsFull){
                Console.WriteLine("ST can't eat anymore and is close to bursting!");
            } else {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                if(item.IsSpicy){
                    Console.WriteLine($"{item.Name} is spicy!");
                } else if(item.IsSweet){
                    Console.WriteLine($"{item.Name} is sweet!");
                }
                item.GetInfo();
            }
        }
    }
//////////////////////////////////////////////////////////////
    class SpiceHound : Ninja
    {
        public SpiceHound() : base(){}
        public bool isFull;
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull{get{return isFull;}set{isFull = value;}}
        public override void Consume(IConsumable item)
        {
            if(calorieIntake > 1200){
                IsFull = true;
            } else {
                IsFull = false;
            }
            if(IsFull){
                Console.WriteLine("SH can't eat anymore and is close to bursting!");
            } else {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                if(item.IsSpicy){
                    Console.WriteLine($"{item.Name} is spicy!");
                } else if(item.IsSweet){
                    Console.WriteLine($"{item.Name} is sweet!");
                }
                item.GetInfo();
            }
        }
    }
}

