using System;
//BILLY JOHN JESUTOBILOBA
//EES/18/19/0204
//300LEVEL
namespace EEG_323
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float a,b,c,d,e,f;

            Console.WriteLine("Enter a:");
            a = Convert.ToSingle(Console.ReadLine());

            System.Console.WriteLine("Enter b:");
            b = Convert.ToSingle(Console.ReadLine());

            System.Console.WriteLine("Enter c:");
            c = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter d:");
            d = Convert.ToSingle(Console.ReadLine());

            System.Console.WriteLine("Enter e:");
            e = Convert.ToSingle(Console.ReadLine());

            System.Console.WriteLine("Enter f:");
            f = Convert.ToSingle(Console.ReadLine());
            
            float determinant = (a*d)-(b*c);
            float changeInX = (e*d) - (f*b);
            float changeInY = (a*f) - (e*c);
            if (determinant == 0)
            {
                System.Console.WriteLine("The equation has no solution"); 
            }else
            {
                float x = changeInX/determinant;
                float y = changeInY/determinant;
                Console.WriteLine("The value of \n X is {0} \n Y is {1}", x,y);
            }
           
           


        }
    }
}
        