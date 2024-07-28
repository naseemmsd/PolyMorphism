using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //class Program
    //{
    //    //void sum(int a, int b
    //    void sum(int a ,float b)
    //    {
    //        Console.WriteLine(a  + b);   //compile time polymorphis using overloading Method
    //    }                               //difreent type of parameters
        //void sum( float a, float b)
       // void sum(int a,int b, int c) // different Numbers of parameter
    //   void sum (float a ,int b) // different sequence  of parameter 
    //    { 
    //        Console.WriteLine(a + b );
    //    }

    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();
    //        obj.sum(20.3f, 80);

    //    }
    //}
    class Animal
    {
        public void Eat()
        {
            System.Console.WriteLine("Dog  is Eating");
        }
    }
    class Dog : Animal
    {
        public void Eat()                                //Method overriding
        {
            System.Console.WriteLine("Dog is Eating");
        }
        public static void Main(string[] args)
        {
            Dog tommy = new Dog();
            tommy.Eat();
            Console.ReadLine();
        }

    }
}
