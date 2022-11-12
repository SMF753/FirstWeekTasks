using System;

namespace FirstWeekTasks
{
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] twosum = new int[2];
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    if (nums[i] + nums[j]==target)
                    {
                        twosum[0] = i;
                        twosum[1] = j;
                    }
                }
            }
            return twosum;
        }

        static void Main(string[] args)
        {

            //leetcode two sum 
            string s = Console.ReadLine();
             string []s1 = s.Split(',');
            int[] nums = new int[s1.Length];
            for(int i=0;i<s1.Length;i++)
            {
                nums[i] = Convert.ToInt32(s1[i]);
            }
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine(TwoSum(nums,target));
            

            


        }
    }
}
////leetcode string reverse words in a string III
//string s = Console.ReadLine();
//Console.WriteLine(Reverse(s));
//public static string Reverse(string s)
//{
//    string[] s1 = s.Split(' ');
//    string s2 ,s3="";
//    for(int i=0;i<s1.Length;i++)
//    {
//        s2 = "";
//        for(int j = 0; j<s1[i].Length;j++)
//        {
//            s2 = s1[i][j] + s2;
//        }
//        s3 += s2 + ' ';
//    }
//    s2 = "";
//    for(int i=0;i<s3.Length-1;i++)
//    {
//        s2 += s3[i];
//    }
//    return s2;
//}






////10 masala
//int n = 2024; ;
//for(int i=0;i<20;i++)
//{
//    Console.WriteLine(n);
//    n +=4;
//}







////9 masala 
//Random rand=new Random();
//Console.Write("n=");
//int n, m=rand.Next(1,1000);
//for(int i=0;i<10;i++)
//{
//    n = int.Parse(Console.ReadLine());
//    if (n < m) Console.WriteLine("berilgan sondan kichik");
//    else if (n > m) Console.WriteLine("berilgan sondan katta");
//    else Console.WriteLine("Yutdingiz!!!");
//}






////8 masala 
//Console.Write("n=");
//int  n = int.Parse(Console.ReadLine());
//for(int i=2;i<=n;i++)
//{
//    if (i == 2) Console.WriteLine(2);
//    else if (i == 3) Console.WriteLine(3);
//    else
//    {
//        if (IsPrime(i)) Console.WriteLine(i);
//    }
//}
//public static bool IsPrime(int i)
//{

//   for(int j=2;j*j<=i;j++)
//    {
//        if (i % j == 0) return false;
//    }

//    return true;
//}



//7 masala
//   for(int i=1;i<13;i++)
//    {
//        for(int j=1;j<13;j++)
//        {
//            Console.WriteLine(i+"*"+j+"="+i*j);
//        }
//        Console.WriteLine("-------------------------------");
//    }







//// 6 masala
//Console.Write("n sonini kiriting=");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("yig'indini hisoblash uchun 1 ni ko'paytmani hisoblash uchun 2 ni bosing");
//int m= int.Parse(Console.ReadLine());
//int p = 1;
//if(m==1)
//{
//    Console.WriteLine("Yig'indi= "+n*(n+1)/2);
//}
//if(m==2)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        p *= i;
//    }
//    Console.WriteLine("Ko'paytma="+p);
//}


//// 5 masala
//Console.Write("n sonini kiriting=");
//int n = int.Parse(Console.ReadLine());
//for(int i=1;i<=n;i++)
//{
//    if (i % 3 == 0) Console.WriteLine(i);
//    else if (i % 5 == 0) Console.WriteLine(i);
//}

//// 4masala
//Console.Write("n sonini kiriting=");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(n*(n+1)/2);


////3 masala
//string name = "Elis",name2="Bob";
//Console.WriteLine("Assalomu alaykum " + name);
//Console.WriteLine("Assalomu alaykum " + name2);


////2 masala
//Console.WriteLine("Ismingizni kiriting");
//string name = Console.ReadLine();
//Console.WriteLine("Assalomu alaykum "+name);

////1 masala
//Console.WriteLine("Hello World");