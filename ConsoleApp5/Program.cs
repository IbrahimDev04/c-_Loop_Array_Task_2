//________________________________________________________________{Sinifdəki tapşırıqlar}________________________________________________________________



//_____________________________________________________Task1______________________________________________________





//int num = Convert.ToInt32(Console.ReadLine());
//if (num < 15)
//{
//    Console.WriteLine("Hava soyuqdur");
//}
//else
//{
//    Console.WriteLine("Hava istidir");
//}




//_____________________________________________________Task2______________________________________________________




//console.writeline("ay daxil et:");
//string mounth = convert.tostring(console.readline());

//switch(mounth)
//{
//    case "yanvar":
//    case "mart":
//    case "may":
//    case "iyul":
//    case "avqust":
//    case "oktyabr":
//    case "dekabr":
//        console.writeline("31");
//        break;

//    case "aprel":
//    case "iyun":
//    case "sentyabr":
//    case "noyabr":
//        console.writeline("30");
//        break;
//    case "fevral":
//        console.writeline("29");
//        break;
//}




//_____________________________________________________Task3______________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());
//int res = 1;

//if (num % 2 == 0)
//{
//    for (int i = 0; 0 < num; num--)
//    {
//        res *= num;
//    }
//    Console.WriteLine(res);
//}
//else
//{
//    Console.WriteLine("Musbet deyil");
//}




//_____________________________________________________Task4______________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());
//bool res = false;

//if (2 > num)
//{
//    Console.WriteLine("Ne sade Ne murekkeb");
//}
//else
//{
//    for (int i = 2; i*i <= num; i++)
//    {
//        if (num % i == 0)
//        {
//            res = true;
//            break;
//        }


//    }
//    if (res)
//    {
//        Console.WriteLine("murekkebdir");
//    }
//    else
//    {
//        Console.WriteLine("Sade");
//    }
//}




//_____________________________________________________Task5______________________________________________________




//int[] arr = { 32, 56, 5, 9, 1, 3 };
//int res = 0;

//for(int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 != 0)
//    {
//        res += arr[i];
//    }
//}

//Console.WriteLine(res);




//_____________________________________________________Task6______________________________________________________




//int[] arr = { 32, 56, 5, 9, 1, 3 };
//int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (max < arr[i])
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(max);




//_____________________________________________________Task7______________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());

//int first = num;
//int second = num;
//int count = 0;

//while (first % 10 != 0)
//{
//    while (second % 10 != 0)
//    {
//        if (first%10 == second%10)
//        {
//            count++;
//        }
//        second = second / 10;
//    }
//    first = first / 10;
//}
//if (count == num.ToString().Length)
//{
//    Console.WriteLine("tekrar");
//}
//else
//{
//    Console.WriteLine("deyil");
//}




//_____________________________________________________Task8______________________________________________________



//int num = Convert.ToInt32(Console.ReadLine());

//int count = 0;
//int res = 1;

//while (res * 2 <= num)
//{
//    res *= 2;
//    count++;
//}

//if (num == res)
//{
//    Console.WriteLine(count);
//}
//else if (num - res < res * 2 - num)
//{
//    Console.WriteLine(count);
//}
//else
//{
//    Console.WriteLine(count + 1);
//}



//_____________________________________________________Task9______________________________________________________



//int num = Convert.ToInt32(Console.ReadLine());
//int res = 0;

//while (num % 10 != 0)
//{
//    res = (num % 10) + res;
//    num/= 10;
//}
//Console.WriteLine(res);




//_____________________________________________________Task10______________________________________________________




//int[] arr = { 13, 6, 54, 91, 12, 345,42,2 };
//int min = arr[0];

//for (int i = 0; i < arr.Length; i++)
//{
//    if (min > arr[i])
//    {
//        min = arr[i];
//    }
//}

//Console.WriteLine(min);




//_____________________________________________________Task11______________________________________________________




//int[] arr = { 13, 6, 54, 91, 12, 345, 42, 2, 9, 1 };
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < 10)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);




//_____________________________________________________Task12______________________________________________________




//int num = 36;

//if (num % 10 > num / 10)
//{
//    Console.WriteLine("Teklik boyukdur");
//}
//else if (num % 10 == num / 10)
//{
//    Console.WriteLine("Beraberdir");
//}
//else
//{
//    Console.WriteLine("Onluq boyukdur");
//}




//_____________________________________________________Task13______________________________________________________





//int[] arr = { 13, 6, 54, 91, 12, 345, 42, 2 };
//int min = 0;
//int max = 0;



//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[min] > arr[i])
//    {
//        min = i;
//    }
//    if (arr[max] < arr[i])
//    {
//        max = i;
//    }

//}

//max = min+max
//arr[min] = arr[max-min];
//arr[max] = arr[min];


//_____________________________________________________Task14______________________________________________________





//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;

//while (num % 10 != 0)
//{
//    count++;
//    num/= 10;
//}

//Console.WriteLine(count);




//_____________________________________________________Task15______________________________________________________




//int num = Convert.ToInt32(Console.ReadLine()) * 10;
//int whl = num;
//int x = 7;

//while (whl != 0)
//{
//    x *= 10;
//    whl /= 10;
//}
//Console.WriteLine((x + num) + 8);



//_____________________________________________________Task16______________________________________________________




//Long yazmağımda səbəb məsələ int ilə yazıldıqda böyük rəqəmlərdən istifadə edildikdə doğru cavab qaytarmamsı idi


//long num = Convert.ToInt64(Console.ReadLine());
//long num1 = num;
//long whl = num;

//while (whl != 0)
//{
//    num = num * 10;
//    whl /= 10;
//}
//Console.WriteLine(num1+num);




//_____________________________________________________Task17______________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());
//int newnum = (num * 10 + 7) * 7 / 100;
//Console.WriteLine(newnum);



//_____________________________________________________Task18______________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("cut");
//}
//else if (num == 0)
//{
//    Console.WriteLine("Ne cut ne tek");
//}
//else
//{
//    Console.WriteLine("Tek");
//}




//_____________________________________________________Task19______________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 21 == 0)
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//}




//_____________________________________________________Task20______________________________________________________




//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine(num1);
//}
//else if (num1 == num2)
//{
//    Console.WriteLine("Beraberdir");
//}
//else
//{
//    Console.WriteLine(num2);
//}




//_____________________________________________________Task21______________________________________________________




//string[] arr = { "fsdsfas", "3df3", "AB106", "safaf1" };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == "AB106")
//    {
//        Console.WriteLine("Var");
//    }
//    else
//    {
//        Console.WriteLine("yoxdur");
//    }
//}




//_____________________________________________________Task22______________________________________________________




//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;

//for (int i = 1; i < num; i++)
//{
//    if (i % 15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);



//________________________________________________________________________________________________________________________________


//Ədədlərdən ibarət İki array verilib. Hər iki arrayda mövcud olan elementleri ekrana çıxaran alqoritm (Məsələn {4,5,9,11,15} ve {1,5,13,15}   hər ikisində 5 və 15 var bunlar ekrana cixmalidir)




//int[] arr1 = { 5, 34, 623, 45, 52, 3 };
//int[] arr2 = { 4, 5, 654, 2, 23, 36, 26, 9, 1, 5, 3 };

//for (int i = 0; i < arr1.Length; i++)
//{
//    for (int j = 0; j < arr2.Length; j++)
//    {
//        if (arr1[i] == arr2[j])
//        {
//            Console.WriteLine(arr2[j]);
//            break;
//        }
//    }
//}







//________________________________________________________________________________________________________________________________







//int[] arr = { 3, 6, 5, 2, 78, 13, 678, 4575 };
//int lenght = arr.Length;


//Console.WriteLine("İlkin vəziyyət");
//for (int i = 0; i < lenght; i++)
//{
//    Console.WriteLine(arr[i]);
//}




//for (int i = 0; i < lenght - 1; i++)
//{
//    int minIndex = i;
//    for (int j = i + 1; j < lenght; j++)
//    {
//        if(arr[j] < arr[minIndex])
//        {
//            minIndex = j;
//        }
        
//    }


//    int subs = arr[minIndex];
//    arr[minIndex] = arr[i];
//    arr[i] = subs;
//}

//Console.WriteLine("_____________________________");
//Console.WriteLine("Sortlandıqdan sonrakı vəziyyət");

//for (int i = 0; i< lenght; i++)
//{
//    Console.WriteLine(arr[i]);
//}








