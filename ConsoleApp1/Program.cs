using System;
using System.IO;
namespace OOPPart1
{
    class Program
    {
        class Dog
        {
            string name;
            int sports;
            double happiness;

            public Dog(string _name, int _sports)
            {
                name = _name;
                sports = _sports;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {sports} has been created.");
            }

            public string Name
            {
                get { return Name; }
            }
            public int Sports
            {
                get { return Sports; }
            }
            public double Happiness
            {
                get { return happiness; }
            }

            public void barks()
            {
                Console.WriteLine("woof, woof");
                happiness += 0.2; //happiness = happiness + 0.2
            }

            public void WagTail()
            {
                Console.WriteLine("wiggle-wiggle");
            }

            public void Rename(string newName)
            {
                name = newName;
            }



            static void Main(string[] args)
            {
                Dog myDog = new Dog("Koer", 15);
                //myDog.happiness = 10;
                //myDog.name = "Good dog";

                while (myDog.happiness != 1)
                {
                    myDog.barks();
                }

                myDog.WagTail();
                Console.WriteLine("Rename your dog");
                string userInput = Console.ReadLine();
                myDog.Rename(userInput);
                Console.WriteLine($"Name{myDog}");
                Console.WriteLine($"Level of happiness {myDog.happiness}");
            }
        }
        
    }
}
