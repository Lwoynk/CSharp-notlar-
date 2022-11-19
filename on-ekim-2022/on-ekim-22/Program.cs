using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_ekim_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. örnek


            //double x;
            //double result;

            //Console.WriteLine("enter a number for x:");
            //x = Convert.ToDouble(Console.ReadLine());

            //result = Math.Abs(x);
            //Console.WriteLine("result abs: " + result);

            //result = Math.Pow(x,1/4);
            //Console.WriteLine("result pow: " + result);

            //result = Math.Exp(x);
            //Console.WriteLine("result exp: " + result);


            //Console.ReadLine();



            //2. örnek

            //double x1, x2, y1, y2;
            //double distance;

            //Console.WriteLine("x1:");
            //x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("y1:");
            //y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("x2:");
            //x2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("y2:");
            //y2 = Convert.ToDouble(Console.ReadLine());

            //distance = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            //Console.WriteLine("distance: " + distance);
            //Console.ReadLine();


            //3. örnek

            //Int32 a1, a2, a3, a4, a5, a6;

            //Random rastgele = new Random();
            //a1 = rastgele.Next(1, 50);
            //a2 = rastgele.Next(1, 50);
            //a3 = rastgele.Next(1, 50);
            //a4 = rastgele.Next(1, 50);
            //a5 = rastgele.Next(1, 50);
            //a6 = rastgele.Next(1, 50);

            //Console.WriteLine(a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + a6);
            //Console.ReadLine();


            //4. örnek

            //double pacman;
            //double angle = 40;
            //double r = 3;

            //pacman = Math.PI * Math.Pow(r, 2) - (Math.PI * Math.Pow(r, 2) * (angle / 360));

            //Console.WriteLine("area: " + pacman);
            //Console.ReadLine();



            //5. örnek

            //double degree;
            //double radian;
            //double sign;
            //double circle;

            //Console.WriteLine("enter degree: ");
            //degree = Convert.ToDouble(Console.ReadLine());

            //radian = (6.28318 / 360) * degree;
            //Console.WriteLine(degree + " is " + radian + " radian");

            //sign = (12.0 / 360.0) * degree;
            //Console.WriteLine(degree + " is " + sign + " sign");

            //circle = ((double)1 / 360) * degree;

            //Console.WriteLine(degree + " is " + circle + " circle");

            //Console.ReadLine();



            //6. örnek


            //int units, tens, number, sum;
            //Console.WriteLine("enter number between 1-99: ");
            //number = Convert.ToInt32(Console.ReadLine());

            //units = number % 10;

            //tens = (number - units) / 10;

            //sum = units + tens;

            //Console.WriteLine("the sum of the digits is: " + sum);
            //Console.ReadLine();



            //7. örnek


            double a, b, x, result;

            Console.WriteLine("enter number a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter number b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter number x: ");
            x = Convert.ToDouble(Console.ReadLine());

            result = 2 * Math.Sqrt(Math.Pow((a * x + b),3)) / (3 * a);
            Console.WriteLine("result: " + result);

            Console.ReadLine();
        }
    }
}
