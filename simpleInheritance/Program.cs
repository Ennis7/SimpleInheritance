using System;
using System.Xml.Linq;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }
    // derived class of Animal Class B
    class Dragon : Animal
    {
        public double age;
        public double weight;
        public double height;

        // constructor
        public Dragon()
                : base()
        {
            age = 0;
            weight = 0;
            height = 0;
        }
        //parameterized constructor
        public Dragon(string name, double age, double weight, double height)
            : base(name)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
        }
        public void getName()
        {
            Console.WriteLine($"Name: {name}");
        }
        public void getAge()
        {
            Console.WriteLine($"Age: {age}");
        }
        public void getWeight()
        {
            Console.WriteLine($"Weight: {weight} pounds");
        }
        public void getHeight()
        {
            Console.WriteLine($"Height: {height} inches tall");
        }
        public void Display()
        {
            Console.WriteLine("Dragon Information:");
        }
        // derived class of Animal Class C
        class Centaur : Animal
        {
            public double age;
            public double weight;
            public double height;

            // constructor
            public Centaur()
                    : base()
            {
                age = 0;
                weight = 0;
                height = 0;
            }
            //parameterized constructor
            public Centaur(string name, double age, double weight, double height)
                : base(name)
            {
                this.age = age;
                this.weight = weight;
                this.height = height;
            }
            public void getName()
            {
                Console.WriteLine($"Name: {name}");
            }
            public void getAge()
            {
                Console.WriteLine($"Age: {age}");
            }
            public void getWeight()
            {
                Console.WriteLine($"Weight: {weight} pounds");
            }
            public void getHeight()
            {
                Console.WriteLine($"Height: {height} inches tall");
            }
            public void Display()
            {
                Console.WriteLine("Centaur Information:");
            }



            class Program
            {
                static void Main(string[] args)
                {
                    // object of base class
                    Animal myPet = new Animal();
                    myPet.name = "Sparky";
                    myPet.display();
                    Console.WriteLine();
                    // derived class object using default constructor

                    Dragon baby = new Dragon();
                    baby.name = "Toothless";
                    baby.age = 1;
                    baby.weight = 5983;
                    baby.height = 192;
                    baby.Display();
                    baby.getName();
                    baby.getAge();
                    baby.getWeight();
                    baby.getHeight();
                    Console.WriteLine();

                    // derived class object using default constructo
                    Centaur calf = new Centaur();
                    calf.name = "Chiron";
                    calf.age = 122;
                    calf.weight = 3360;
                    calf.height = 96;
                    calf.Display();
                    calf.getName();
                    calf.getAge();
                    calf.getWeight();
                    calf.getHeight();
                    Console.WriteLine();

                    //derived class object using parameterized constructor
                    Dragon Toothless = new Dragon("Stormfly", 2, 6587, 323);
                    Toothless.Display();
                    Toothless.getName();
                    Toothless.getAge();
                    Toothless.getWeight();
                    Toothless.getHeight();
                    Console.WriteLine();

                    //derived class object using parameterized constructor
                    Centaur Chiron = new Centaur("Firenze", 145, 2879, 89);
                    Chiron.Display();
                    Chiron.getName();
                    Chiron.getAge();
                    Chiron.getWeight();
                    Chiron.getHeight();
                    Console.ReadLine();
                }

            }
        }
    }
}