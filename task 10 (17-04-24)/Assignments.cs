//assingment No 1 - Count no of words
//Console.WriteLine("Enter the string");
//string str = Console.ReadLine();
//string[] arr = str.Split(" ");
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i].Length > 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("No of words are " + count);




//assignment No 2 - Show data and time
//TimeZoneInfo zone = TimeZoneInfo.Local;
//Console.WriteLine(zone.DisplayName);


//assignment No 3 - Average of 3 numbers
//Console.WriteLine("Enter 3 numbers");
//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());
//int ans = (num1 + num2 + num3) / 3;
//Console.WriteLine("The average of 3 numbers is " + ans);

//assignment No 4 - Simple Interest
//Console.WriteLine("Enter the principle amount");
//int p = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the no of years");
//int t = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the rate of interest");
//int r = Convert.ToInt32(Console.ReadLine());

//int i = p * r * t / 100;
//Console.WriteLine("The simple interest is " + i);

//assignment-5 - Find the biggest number
//Console.WriteLine("Enter 3 numbers");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//if (a > b && a > c)
//{
//    Console.WriteLine(a + " is biggest");
//}
//else if (b > a && b > c)
//{
//    Console.WriteLine(b + " is biggest");
//}
//else if (c > a && c > b)
//{
//    Console.WriteLine(c + " is biggest");
//}

//assignment no 6 - Remove duplicate arrays
//Console.WriteLine("Enter the size of array");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Enter no for index " + i);
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}
//int[] arr1 = arr.Distinct().ToArray();
//Array.ForEach(arr1, e => Console.WriteLine(e));
//int duplicateCount = 0;
//for (int i = 0; i < n - 1; i++)
//{
//    for (int j = i + 1; j < n - duplicateCount; j++)
//    {
//        if (arr[i] == arr[j])
//        {
//            duplicateCount++;
//            int k = j;
//            while (k < arr.Length - duplicateCount)
//            {
//                arr[k] = arr[k + 1];
//                k++;
//            }
//        }
//    }
//}

//Console.WriteLine("Array after removing duplicates :");
//for (int i = 0; i < arr.Length - duplicateCount; i++)
//{
//    Console.Write(arr[i] + " ");
//}