using System.Globalization;

namespace Assignment
{
    //class MyClass
    //{
    //    public int Value { get; set; }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int a = 5;
            //Console.WriteLine($"Before passing by value: {a}");
            //PassByValue(a);
            //Console.WriteLine($"After passing by value: {a}");

            //int b = 5;
            //Console.WriteLine($"Before passing by reference: {b}");
            //PassByReference(ref b);
            //Console.WriteLine($"After passing by reference: {b}");
            #endregion

            #region Q2
            //MyClass obj1 = new MyClass { Value = 5 };
            //Console.WriteLine($"Before passing by value: {obj1.Value}");
            //PassByValue(obj1);
            //Console.WriteLine($"After passing by value: {obj1.Value}");

            //MyClass obj2 = new MyClass { Value = 5 };
            //Console.WriteLine($"Before passing by reference: {obj2.Value}");
            //PassByReference(ref obj2);
            //Console.WriteLine($"After passing by reference: {obj2.Value}");
            #endregion

            #region Q3
            //Console.WriteLine("Enter four numbers:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //var result = addTwoSubstractTwo(a, b, c, d);
            //Console.WriteLine($"Sum: {result.sum} And Difference: {result.diff}");
            #endregion

            #region Q4
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum of digits: {addDigits(num)}");
            #endregion

            #region Q5
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Is prime: {IsPrime(num)}");
            #endregion

            #region Q6
            //int[] numbers = { 1,8,5,7,3,9,8,7,2 };
            //int[] minMax = getMinMax(numbers);

            //Console.WriteLine($"Min: {minMax[0]}");
            //Console.WriteLine($"Max: {minMax[minMax.Length-1]}");

            #endregion

            #region Q7
            Console.Write("Enter the number you want: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {num} is: {getFactorial(num)}");
            #endregion
        }

        #region Value Type Methods
        //static void PassByValue(int x)
        //{
        //    x = 10;
        //}

        //static void PassByReference(ref int x)
        //{
        //    x = 10;
        //}
        #endregion

        #region Reference Type Methods
        //static void PassByValue(MyClass obj)
        //{
        //    obj.Value = 10;
        //    obj = new MyClass { Value = 20 };
        //}

        //static void PassByReference(ref MyClass obj)
        //{
        //    obj.Value = 10;
        //    obj = new MyClass { Value = 20 };
        //}
        #endregion

        #region Q3
        //static (int sum, int diff) addTwoSubstractTwo(int a, int b, int c, int d)
        //{
        //    int sum = a + b;
        //    int diff = c - d;
        //    return (sum, diff);
        //}
        #endregion

        #region Q4
        //static int addDigits(int num)
        //{
        //    string word = num.ToString();
        //    int sum = 0;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        sum += int.Parse(word[i].ToString());
        //    }
        //    return sum;
        //}
        #endregion

        #region Q5
        //static bool IsPrime(int num)
        //{
        //    if (num < 2)
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
        #endregion

        #region Q6
        //static int[] getMinMax(int[] numbers)
        //{
        //    int min = 0;
        //    int max = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            min = numbers[i];
        //            max = numbers[i];
        //        }
        //        else
        //        {
        //            if (numbers[i] < min)
        //            {
        //                min = numbers[i];
        //            }
        //            if (numbers[i] > max)
        //            {
        //                max = numbers[i];
        //            }
        //        }
        //    }
        //    return new int[] { min, max };
        //}
        #endregion

        #region Q7
        static int getFactorial(int num)
        {
            int result = 1;
            for (int i = 0; i < num; i++)
            {
                result = result * (i + 1);
            }
            return result;
        }
        #endregion
    }
}
