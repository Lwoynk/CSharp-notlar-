// --Örnek1--

//int side = 0;
//Console.WriteLine("Enter side:");
//side = Convert.ToInt32(Console.ReadLine());

//switch(side)
//{
//    case 5:
//        Console.WriteLine("Pentagon ");
//        break;

//    case 6:
//        Console.WriteLine("Hexagone ");
//        break;

//    case 7:
//        Console.WriteLine("Heptagone ");
//        break;

//    case 8:
//        Console.WriteLine("Octagone ");
//        break;

//    default:
//        Console.WriteLine("Invalid side");
//            break;
//}




// --Örnek2--

//int i = 0;
//for (i = 3; i <= 87; i = i + 7) 
//{
//    Console.Write(i + " ");
//}

//Console.ReadLine();




// --Örnek3--

//int i = 3;

//while (i<=87)
//{
//    Console.Write(i + " ");
//    i = i + 7;
//}




// --Örnek4--

//int i = 1;
//Console.WriteLine("12 Midnight");
//for (i = 1; i <= 11; i++) 
//{
//    Console.WriteLine(i + "am");
//}

//Console.WriteLine("12 noon");
//for (i = 1; i <= 11; i++) 
//{
//    Console.WriteLine(i + "pm");
//}




//--Örnek5--

//double n = 1;
//Console.WriteLine("enter n:");
//n = Convert.ToInt32(Console.ReadLine());

//double a = 1;
//double result = 0;

//while (a <= n)
//{
//    result = result + (1 / a);
//    a++;
//}
//Console.WriteLine("result: " + result);




//--Örnek6--

//int i = 0;
//int t = 1;

//Random zar = new Random();
//int dice, counter = 0;

//do
//{
//    dice = zar.Next(1, 7);
//    counter++;
//    Console.WriteLine(counter + ". try " + dice);
//}
//while (dice != 6);




//--Örnek7--

int n = 7;
int min = 9999;

Console.WriteLine("enter numbers:");

for (int i = 1; i <= n; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 == 1)
        if (number < min)
            min = number;

}
Console.WriteLine(min);

