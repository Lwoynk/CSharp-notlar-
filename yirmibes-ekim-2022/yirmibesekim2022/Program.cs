//Örnek 1

//int a, b;

//a = Convert.ToInt32(Console.ReadLine());
//b = Convert.ToInt32(Console.ReadLine());

//if (a == b)
//    Console.WriteLine("a is equal to b");
//else;
//Console.WriteLine("a is not equal to b");

//Console.ReadLine();




//Örnek2

//int a;
//a = Convert.ToInt32(Console.ReadLine());


//Boolean result;

//if (a % 5 == 0)
//    result = true;

//else
//    result = false;

//Console.Write("is " + a + " divided by 5? " + result);

//Console.Read();




//Örnek3

//int a, b;

//Console.Write("a için saat girin:");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("b için dakika girin:");
//b = Convert.ToInt32(Console.ReadLine());

//if (a < 12 && a >= 0 && b > 0 && b < 60)
//    Console.WriteLine(a + "." + b + " A.M.");

//else if (a > 12 && a <= 24 && b>0 && b<60)
//    Console.WriteLine((a - 12) + "." + b + " P.M.");

//else
//    Console.WriteLine("enter correct number");

//Console.Read();




//Örnek4

//Console.WriteLine("enter wight: ");
//double weight = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("enter height");
//double height = Convert.ToDouble(Console.ReadLine());

//double bmi = weight / (Math.Pow(height, 2));

//string result;

//if (bmi < 18.5)
//    result = "thin";

//else if (bmi < 25)
//    result = "normal";

//else if (bmi < 30)
//    result = "fat";

//else
//    result = "obese";

//Console.WriteLine("you are " + result);




//Örnek5

//int m, n;

//Console.Write("enter m:");
//m = Convert.ToInt32(Console.ReadLine());

//Console.Write("enter n:");
//n = Convert.ToInt32(Console.ReadLine());

//if ((m + n) % 2 == 1)
//    Console.WriteLine(0);

//else 
//{
//    double result = (double) (2 * m) / ((m * m) - (n * n));
//    Console.WriteLine(result);
//}




//Örnek6

//Console.WriteLine("enter a, b, c");

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//if (a != b && a != c && b != b) 
//Console.WriteLine("3 distinct values");

//else if (a == b && b != c) 
//Console.WriteLine("2 distinct values");

//else if (c == b && a != b) 
//Console.WriteLine("2 distinct values");

//else if (c == a && b != c) 
//Console.WriteLine("2 distinct values");

//else
//    Console.WriteLine("1 distinst value");




//Örnek7

Console.Write("enter month and day ");
    int m = Convert.ToInt32(Console.ReadLine());
    int d = Convert.ToInt32(Console.ReadLine());

if ((m == 3 && d >= 21) || m == 4 || m == 5 || (m == 6 && d <= 20)) 
Console.WriteLine("spring");

