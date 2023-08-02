using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class PracticeDelegate
    //{
    //    public delegate bool CheckNums(int num);

    //    public bool CheckOddNums(int number)
    //    {
    //        return number % 2 == 1; 
    //    }
    //    public void ExecuteMethod()
    //    {
    //        SumOfOddNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckOddNums);
    //    }

    //    private void SumOfOddNumbers(List<int> numbers, CheckNums func)
    //    {
    //        int sum = 0;

    //        foreach (int number in numbers)
    //        {
    //            if(func(number))
    //            {
    //                sum += number;
    //            }
    //        }
    //        Console.WriteLine(sum);
    //    }

    //    private void SumOfEvenNumbers(List<int> numbers)
    //    {
    //        int sum = 0;

    //        foreach (int number in numbers)
    //        {
    //            if (number % 2 != 1)
    //            {
    //                sum += number;
    //            }
    //        }
    //        Console.WriteLine(sum);
    //    }


    //    private void SumOfGreaterFourNumbers(List<int> numbers)
    //    {
    //        int sum = 0;

    //        foreach (int number in numbers)
    //        {
    //            if (number > 4)
    //            {
    //                sum += number;
    //            }
    //        }
    //        Console.WriteLine(sum);
    //    }




    {
        //public delegate bool CheckNums(int num);

        //public bool CheckGreaterFiveNums(int number)
        //{
        //    return number > 5;
        //}

        //public bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public bool CheckOddNums(int number)
        //{
        //    return number % 2 == 1;
        //}

        //public delegate void CangeStr(string str);

        //public delegate int CheckhLenght(string str);

        //public void StrTolower(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}


        public int GetLenght(string text, int num)
        {
            return text.Length + num;
        }

        public void ExecuteMethod()
        {
            //List<int> numbers = new List<int> { 1,2, 3, 5, 7, 9, 12};

            //var result = numbers.Where(m => m % 2 == 1).Sum(m => m);

            //var data = numbers.FirstOrDefault(m => m > 5);

            //Console.WriteLine(result);

            //SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, m => m % 2 == 1);
            //SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckOddNums);
            //SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckEvenNums);
            //SumNumbers(new List<int> { 1, 2, 3, 5, 7, 9, 12 }, CheckGreaterFiveNums);

            //GetString("Salam", StrToUpper);

            //    Action<string> func = new Action<string>(StrToUpper);

            //    func += StrTolower; 

            //    func.Invoke("Salamlar");

            //GetStringLenght("salam", GetLenght);


            //GetStringLenght("salam", GetLenght);

            Func<string, int, int> func = GetLenght;

            Console.WriteLine(func.Invoke("salam", 100));
        }

        //private void GetStringLenght(string str, Func<string, int, int> func)
        //{
        //    Console.WriteLine(func(str, 12));
        //}


        //private void GetStringLenght(string str, CheckhLenght func)
        //{
        //    Console.WriteLine(func(str));
        //}

        //private void GetStringLenght(string str)
        //{
        //    Console.WriteLine(str.Length);
        //}


        //private void GetString(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}


        //private void GetString(string str)
        //{
        //    Console.WriteLine(str.ToLower());
        //}

        //private void GetString(string str, CangeStr func)
        //{
        //    func(str);
        //}



        //private void GetString(string str, Action<string> func)
        //{
        //    func(str);
        //}



        //private void SumNumbers(List<int> numbers, CheckNums<int> func)
        //private void SumNumbers(List<int> numbers, Predicate<int> func)
        //{
        //    int sum = 0;

        //    foreach (int number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            sum += number;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}
    }
}

