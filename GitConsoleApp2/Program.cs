using System;

namespace GitConsoleApp2 { 


    class Animal
    {
        private int legs = 4;

        public Animal(int legs)
        {
            this.legs = legs;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal(4);
            Console.WriteLine("Hello World!");
        }
    }
}
