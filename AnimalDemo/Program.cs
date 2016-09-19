using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDemo
{
    class Animal
    {
        public Animal() { Console.WriteLine("Animal created"); }
        public Animal(string foo) { Console.WriteLine("Animal created with " + foo); }
        public virtual void Eat() { Console.WriteLine("I can eat anything.."); } //virtual means it could be overriden or hidden by child's same-name-method
    }

    class Bird : Animal
    {
        public Bird(string name) { Console.WriteLine(name + " was created"); }
        public override void Eat() { Console.WriteLine("I love worms.."); } //overridden method cannot be cast back into parent's method BUT hidden one can be.
    }

    class Cat : Animal
    {
        public Cat() : base("Meeaaaaoooo") { Console.WriteLine("Cat Created..."); }
        new public void Eat() { Console.WriteLine("I want meat.."); } //new means it'll just HIDE parent's method, NOT override it. And to use parent's method instead, just use cast.
        //Even without "new" it'll hide BUT compiler'll give a warning.
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal();

            //Cat c = new Cat();
            //c.Eat();
            //((Animal)c).Eat(); //"hidden" method become exposed after "casting" so it'd use parent's features/members.


            //Bird b = new Bird("Tweety Bird");
            //b.Eat();
            //((Animal)b).Eat(); //"overriden" method doesn't work even after "casting" to parent's features/members.


        }
    }
}
