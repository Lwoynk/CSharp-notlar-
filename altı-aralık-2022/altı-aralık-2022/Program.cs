using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altı_aralık_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*****Örnek 1******

            //string str = "bügün hava çok güzel";

            //for (int i = 0; i < str.Length; i=i+3)
            //{
            //    Console.Write(str[i] + " ");
            //}





            //*******Örnek 2*********

            //string s1 = "computer";
            //string s2 = "programming";

            //Console.Write("enter a number for index: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //x = x - 1;

            //string ch1 = s1.Substring(x, 1);
            //string ch2 = s2.Substring(x, 1);

            //string news1 = s1.Substring(0, x) + ch2 + s1.Substring(x + 1, s1.Length - 1 - x);
            //string news2 = s2.Substring(0, x) + ch1 + s2.Substring(x + 1, s2.Length - 1 - x);

            //Console.WriteLine(news2);
            //Console.WriteLine(news1);





            //*******Örnek 3**********

            //Console.Write("enter a sentences: ");
            //string sentences = Convert.ToString(Console.ReadLine());

            //string[] words = sentences.Split(' ');

            //int max = 0;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length > max)
            //    {
            //        max = words[i].Length;
            //    }
            //}

            //Console.WriteLine(max);



            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length == max)
            //    {
            //        Console.WriteLine(words[i]);
            //    }
            //}





            //******Örnek4*******

            //Console.Write("enter a sentences: ");
            //string sentences = Convert.ToString(Console.ReadLine());

            //string[] words = sentences.Split(' ');
            //string output = "";

            //for (int i = 0; i < words.Length; i++)
            //{
            //    string rev = "";
            //    for (int j = words[i].Length - 1; j >= 0; j--)
            //    {
            //        rev += words[i][j];
            //    }
            //    output = output + rev + " ";
            //}
            //Console.WriteLine(output);




            //********Örnek 5*******

            string str = "KaOH, NaOH, POH, CaOH";
            str = str.Replace(',', ' ');

            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                //Console.WriteLine(words[i] + i); eger assagida <words[i].Length > 1> bunu koymazsan splitte virgül yerine boşluk konulduğundan
                //boşluklar wordse dönüşür ve uzunluğu bir olanda ikilik satır arayamazsın anlamak için bunu çalıştır
                if (words[i].Length > 1 && words[i].Substring(words[i].Length - 2, 2) == "OH")
                {
                    Console.WriteLine(words[i] + " ");
                }
            }






            //*********Örnek 6*******

            //string str = "ECE ve EGE deeeeeeeeeeermişim";
            //str = str.ToLower();

            //char[] chatacter = new char[str.Length];
            //int[] occurence = new int[str.Length];

            //int len = str.Length;

            //for (int i = 0; i < len; i++)
            //{
            //    if (!chatacter.Contains(str[i]))
            //    {
            //        chatacter[i] = str[i];
            //        occurence[i]++;
            //    }
            //    else
            //    {
            //        for (int j = 0; j < chatacter.Length; j++)
            //        {
            //            if (chatacter[j] == str[i])
            //            {
            //                occurence[j]++;
            //                break;
            //            }
            //        }
            //    }
            //}

            //for (int t = 0; t < occurence.Length; t++)
            //{
            //    if (occurence[t] > str.Length / 2)
            //    {
            //        Console.WriteLine(chatacter[t] + " " + occurence[t]);
            //        break;
            //    }
            //}



        }
    }
}
