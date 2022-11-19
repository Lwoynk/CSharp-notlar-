//Örnek 1

//for (int i = 5; i <= 14; i = i + 3) 
//{
//    for (int j = 3; j < 8;  j++) 
//    {
//        Console.WriteLine(i + "x" + j + "= " + i * j);
//    }
//}



//Örnek 2


//int s = Convert.ToInt32(Console.ReadLine());
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= n; i = i + 1)
//{
//    for (int j = 1; j <= n; j = j + 1 ) 
//    {
//        if (i == j)
//            Console.Write(s);
//        else
//            Console.Write("0");
//    }
//    Console.WriteLine();
//}




//Örnek 4

//int i = 9, j = 9;
//while (i > 0)
//{
//    while (j > 0)
//    {
//        Console.Write(j);
//        j--;
//    }
//    Console.WriteLine();
//    i = i - 2;
//    j = i;
//}


//for (int i = 9; i > 0; i = i - 2)
//{
//    for (int j = i; j > 0; j--)
//        Console.Write(j);
//    Console.WriteLine();
//}



//Örnek 3

//int x = Convert.ToInt32(Console.ReadLine());

//double mult = 1, result = 0;

//for(int i = 1; i <= 20; i++)
//    {
//    mult = 1;
//    for (int j = 0; j < (2 * i - 1); j++)
//    {
//        mult *= x;
//    }
//    result += mult / (2 * i - 1);
//}
//Console.WriteLine(result);




//Örnek 5

//double result = 1, mul = 1;
//for (int i = 1; i < 10; i++) 
//{
//    mul *= (2 * i - 1) / (double)(2 * i);
//    if (i % 2 == i) 
//    {
//        result = result - (4 * i + 1) * Math.Pow(mul, 3);
//    }
//    else
//    {
//        result += (4 * i + 1) * Math.Pow(mul, 3);
//    }
//}
//Console.WriteLine(result);




//Örnek 6