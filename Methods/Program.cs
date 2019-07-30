using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 33);
            SayHi("John", 19);
            SayHi("Tom", 56);
            //Calling the method from below mulitple times. 

            Console.ReadLine();
        }

       

        static void SayHi(String name, int age) //task of method is to say hi to user //Parameters adding in name from user 
        {
            Console.WriteLine("Hello " + name + " you are "  + age);

        }
    }
}
