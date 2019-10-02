using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet b1 = new Buffet();
            Ninja tim = new Ninja();
            tim.Eat(b1.Serve());
            tim.Eat(b1.Serve());
            tim.Eat(b1.Serve());
            tim.Eat(b1.Serve());
        }
    }

    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string nam, int cal, bool spi, bool swe){
            Name = nam;
            Calories = cal;
            IsSpicy = spi;
            IsSweet = swe;
        }
    }

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
                new Food("Soda", 10000000, false, true)
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0,5)];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        public int CalorieIntake{
            get{
                return calorieIntake;
            }
            set{
                calorieIntake = value;
            }
        }
        public List<Food> FoodHistory;
        // add a constructor
        public Ninja(){
            CalorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull(){
            if(CalorieIntake > 1200){
                return true;
            } else {
                return false;
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            if(IsFull()){
            Console.WriteLine("Ninja can't eat anymore and is close to bursting!");
            } else {
                CalorieIntake += item.Calories;
                FoodHistory.Add(item);
                if(item.IsSpicy){
                    Console.WriteLine($"{item.Name} is spicy!");
                } else if(item.IsSweet){
                    Console.WriteLine($"{item.Name} is sweet!");
                }
            }
        }
    }
}
