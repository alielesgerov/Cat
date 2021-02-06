using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT
{
    class Cat
    {
        public string Nickname { get; set; }
        public string Gender { get; set; }
        int age;
        int energy;
        double price;
        int meal_quantity;
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if(value<0)
                    throw new InvalidOperationException("Age must be more than 0!");
                age = value;
            }
        }
        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                if (value < 0||value>100)
                    throw new InvalidOperationException("Energy must be more than 0 and less than 100!");
                energy = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                    throw new InvalidOperationException("Price must be more than 0!");
                price = value;
            }
        }
        public int MealQuantity
        {
            get
            {
                return meal_quantity;
            }
            set
            {
                if(value<0)
                    throw new InvalidOperationException("Meal Quantity must be more than 0 and less than 100!");
                meal_quantity = value;
            }
        }

        public Cat(in string nickname, in int age, in int energy, in double price, in int mealQuantity, in string gender)
        {
            Nickname = nickname;
            Age = age;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
            Gender = gender;
        }

        public void Eat()
        {
            if (Energy>0&&Energy < 100)
            {
                Energy += 10;
                MealQuantity+=100;
            }
            else if (Energy == 0)
            {
                Console.WriteLine("Your cat want to sleep");
                System.Threading.Thread.Sleep(1000);
                return;
            }
        }
        public void Sleep()
        {
            Energy = 100;
        }
        public void Play()
        {
            if (Energy != 0)
                Energy -= 10;
            else
            {
                Console.WriteLine("Your cat want to sleep");
                System.Threading.Thread.Sleep(1000);
                return;
            }
        }

        public void ShowCatInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Nickname: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Nickname);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Gender: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Gender);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Age: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Age);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Energy: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Energy);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Meal Quantity: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{MealQuantity}g");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Price: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Price}$");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
