namespace Assignment
{
    class MyClass
    {
        public int Value { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int a = 5;
            Console.WriteLine($"Before passing by value: {a}");
            PassByValue(a);
            Console.WriteLine($"After passing by value: {a}");

            int b = 5;
            Console.WriteLine($"Before passing by reference: {b}");
            PassByReference(ref b);
            Console.WriteLine($"After passing by reference: {b}");
            #endregion

            #region Q2
            MyClass obj1 = new MyClass { Value = 5 };
            Console.WriteLine($"Before passing by value: {obj1.Value}");
            PassByValue(obj1);
            Console.WriteLine($"After passing by value: {obj1.Value}");

            MyClass obj2 = new MyClass { Value = 5 };
            Console.WriteLine($"Before passing by reference: {obj2.Value}");
            PassByReference(ref obj2);
            Console.WriteLine($"After passing by reference: {obj2.Value}");
            #endregion
        }

        #region Value Type Methods
        static void PassByValue(int x)
        {
            x = 10;
        }

        static void PassByReference(ref int x)
        {
            x = 10;
        }
        #endregion

        #region Reference Type Methods
        static void PassByValue(MyClass obj)
        {
            obj.Value = 10;
            obj = new MyClass { Value = 20 };
        }

        static void PassByReference(ref MyClass obj)
        {
            obj.Value = 10;
            obj = new MyClass { Value = 20 };
        }
        #endregion
    }
}
