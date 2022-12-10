//Örnek 1
//int count = 0;

//int[,] a = new int[,] { {5, 4, 0, 2, 8, 0},
//    {0,5,7,1,3,5},
//    { 12,3,6,0,2,0 } };
//for (int i = 0; i < a.GetLength(0); i++)
//{
//    for (int j = 0; j < a.GetLength(1); j++)
//    {
//        if (a[i, j] == 0)
//            count++;
//    }
//}

//Console.WriteLine(count);





//Örnek2  *******Önemli*********

//char[,] a = new char[,] { {'S', 'O', 'S' },
//    {'O','S','O'},
//    {'S','O','S'}};

//bool flag = true;
//for (int i = 0; i < a.GetLength(0); i++)
//{
//    for (int j = 0; j < a.GetLength(1); j++)
//    {
//        if (a[i, j] != 'S' && a[i, j] != 'O')
//        {
//            flag = false;
//            break;
//        }
//    }
//    if (!flag)
//        break;
//}
//Console.WriteLine(flag);





//Örnek3 

//int[,] a = new int[,] {
//    {1,0,0,0,0},
//    {0,1,0,0,0},
//    {0,0,1,0,0},
//    {0,0,0,1,0},
//    {0,0,0,0,1}};

//bool flag = true;

//if (a.GetLength(0) != a.GetLength(1))
//    flag = false;

//else
//{
//    for (int i= 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0; j < a.GetLength(1); j++)
//        {
//            if ((i == j) && Math.Abs(a[i,j]) != 1)
//            {
//                flag = false;
//                break;
//            }
//            if ((i != j) && a[i,j] !=0)
//            {
//                flag = false;
//                break;
//            }
//        }
//        if (!flag)
//            break;
//    }
//}

//Console.WriteLine(flag);





//Örnek 4


//int[,] a = new int[,] {
//    {4,0,0,0,},
//    {0,4,0,0,},
//    {0,0,4,0,},
//    {0,0,0,4,}
//    };

//bool flag = true;

//int temp = a[0, 0];


//if (a.GetLength(0) != a.GetLength(1))
//    flag = false;

//else
//{
//    for (int i = 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0; j < a.GetLength(1); j++)
//        {
//            if ((i == j) && (a[i, j]) != temp)
//            {
//                flag = false;
//                break;
//            }
//            else if ((i != j) && (a[i, j] != 0))
//            {
//                flag = false;
//                break;
//            }
//        }
//        if (!flag)
//            break;
//    }
//}

//Console.WriteLine(flag);





//Örnek 5


//int[,] a = new int[,] {
//    {0,0,0,0,1},
//    {0,0,0,1,0},
//    {0,0,1,0,0},
//    {0,1,0,0,0},
//    {1,0,0,0,0}};

//bool flag = true;


//if (a.GetLength(0) != a.GetLength(1))
//    flag = false;

//else
//{
//    for (int i = 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0; j < a.GetLength(1); j++)
//        {
//            if ((j == (a.GetLength(0) - 1 - i)) && a[i,j] != 1)
//            {
//                flag = false;
//                break;
//            }
//            if ((j == (a.GetLength(0) - 1 - i)) && a[i, j] != 1)
//            {
//                flag = false;
//                break;
//            }
//        }
//        if (!flag)
//            break;
//    }
//}

//Console.WriteLine(flag);






//Örnek 6    ******Önemli******


//int[,] a = new int[,] {
//    {0,2,-1},
//    {-2,0,-4},
//    {1,4,0}};

//bool flag = true;


//if (a.GetLength(0) != a.GetLength(1))
//    flag = false;

//else
//{
//    for (int i = 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0; j < a.GetLength(1); j++)
//        {
//            if (i != j)
//            {
//                int temp = a[i, j];
//                temp = -temp;
//                if(temp != a[j,i])
//                {
//                    flag = false;
//                    break;
//                }

//            }
//        }
//        if (!flag)
//            break;
//    }
//}

//Console.WriteLine(flag);






//Örnek 7

//int[,] a = new int[,] {
//    {1,0,0},
//    {-2,1,0},
//    {1,4,1}};

//bool flag = true;


//if (a.GetLength(0) != a.GetLength(1))
//    flag = false;

//else
//{
//    for (int i = 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0; j < a.GetLength(1); j++)
//        {
//            if ((i < j)&& a[i,j] !=0)
//            {
//                flag = false;
//            }
//        }
//        if (!flag)
//            break;
//    }
//}

//Console.WriteLine(flag);