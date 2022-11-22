using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace onbir_kasım_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***Örnek 1***

            //string[] names = { "ali", "ayşe", "ayşe", "sibel", "zeynep", "ayşe", "can", "zeynep" };
            //Console.WriteLine("Searched name: ");
            //string name = Console.ReadLine();

            //int counter = 0;
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (name == names[i])
            //    {
            //        counter++;
            //        Console.WriteLine(counter);
            //    }
            //}



            //***Örnek 2***

            //String[] English = { "apple", "pear", "cherry", "banana" };
            //String[] Turkish = { "elma", "armut", "kiraz", "muz" };

            //string name = Console.ReadLine();

            //for(int i = 0; i < English.Length; i++ )
            //{
            //    if (English[i] == name)
            //    {
            //        Console.WriteLine(Turkish[i]);
            //    }
            //}



            //***Örnek 4***

            //double result = 0;
            //int counter = 0;
            //double avarage;
            //int[] numbers = { -1, 5, 6, 2, 9, -6, 4, 3, 8, 0 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    result = numbers[i] + result;
            //}
            //avarage = result / numbers.Length;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > avarage)
            //    {
            //        counter++; // kaç tane ortalamadan büyük sayı olduğunu tutuyor
            //        Console.WriteLine(numbers[i] + " ");
            //    }
            //}
            //double percentage = (double)counter / numbers.Length * 100;
            //Console.WriteLine("\n" + percentage);



            //***Örnek 5***

            //string[] a = { "derya", "deniz", "nehir", "ırmak", "su", "yağmur" };

            //for (int i = 1; i <= a.Length; i = i + 2)
            //{
            //    string temp = a[i - 1];
            //    a[i - 1] = a[i];
            //    a[i] = temp;
            //}

            //for (int i = 0; i <= a.Length; i = i + 1)
            //{
            //    Console.Write(a[i] + " ");
            //}



            //***Örnek 6***

            //int[] numbers = { 1, 7, 7, 12, 1, 5, 1, 1, 12, 12, 12, 7, 1, 1 }; // ***sınavda bu tarz gelebilir.***
            //bool[] taken = new bool[numbers.Length];

            //for (int i = 0; i < taken.Length; i = i + 1)
            //{
            //    taken[i] = true;
            //}

            //for (int i = 0; i <= numbers.Length; i = i + 1)
            //{
            //    if (taken[i] == true)
            //    {
            //        Console.WriteLine(numbers[i] + " ");
            //    }
            //    for (int j = i + 1; j < numbers.Length; j = j + 1d)
            //    {
            //        if (numbers[i] == numbers[j])
            //        {
            //            taken[j] = false;
            //        }
            //    }

            //}



            //***Örnek 7***

            //char[] arr1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            //char[] arr2 = { 'b', 'e', 'g' };

            //int counter = 0;

            //for (int i = 0; i < arr2.Length; i = i + 1)
            //{
            //    for (int j = 0; j < arr1.Length; j = j + 1)
            //    {
            //        if (arr2[i] == arr1[j])
            //        {
            //            counter++;
            //            break;
            //        }
            //    }
            //}

            //if (counter == arr2.Length)
            //{
            //    Console.Write("true");
            //}
            //else
            //    Console.Write("false");
        }
    }
}
