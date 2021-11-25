using System;

namespace OOP_Cat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungriness;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungriness = 0;                
            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Hungriness
            {
                get { return hungriness; }
            }

            public void Sleeps()
            {
                Console.WriteLine("Z-z-Z-z-Z");
                hungriness += 0.2;
            }

            public void Meows()
            {
                Console.WriteLine("Meow-meow!");
            }

        }

        static void Main(string[] args)
        {
            Cat myCat = new Cat("Nurr", "black");


            while(myCat.Hungriness != 1)
            {
                myCat.Sleeps();
            }

            myCat.Meows();

            Console.WriteLine($"Name: {myCat.Name}");
            Console.WriteLine($"Level of happiness: {myCat.Hungriness}");
        }
    }    
}
