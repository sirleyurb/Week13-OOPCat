using System;

namespace OOPCat
{
    class programm
    {
        class Cat
        {

            string name;
            string color;
            double hungry;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungry = 0;
                Console.WriteLine($"The cat {name} with {color} has been created.");
            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Hungry
            {
                get { return hungry; }
            }

            public void Sleep()
            {
                Console.WriteLine("zzz");
                hungry += 0.2;
            }

            public void Meow()
            {
                Console.WriteLine("Meow");
            }

            static void Main(string[] args)
            {
                Cat myCat = new Cat("Caroly", "Elise");

                while (myCat.Hungry != 1)
                {
                    myCat.Sleep();
                }
                myCat.Meow();

                Console.WriteLine($"name: {myCat.Name}");
                Console.WriteLine($"Level of hungriness: {myCat.Hungry}");
            }

        }

    }
}
