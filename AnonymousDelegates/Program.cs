﻿namespace AnonymousDelegates
{
    //Q. What are Anonymous Delegates in C#?
    //In Anonymous Delegates, You can create a delegate,
    //but there is no need to declare the method associated with it.
    public delegate void Calculator(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calcAdd = delegate (int a, int b)
            {
                //Inline content of the method;
                Console.WriteLine(a + b);
            };

            calcAdd(10, 20);
        }
    }

    //Ouput: 30
}