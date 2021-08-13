using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> s0 = new Stack<int>(5);
        Stack<int> s1 = new Stack<int>(5);

        s0.Push(5);
        s0.Push(12);
        s0.Push(13);
        //s.Push(10.01);
        //s.Push("A");
        s0.Print();
        int n = s0.Pop();
        s0.Print();

        Stack<double> s3 = new Stack<double>(5);
        Stack<double> s2 = new Stack<double>(5);
        s3.Push(10.01);
        s3.Push(13.3);
        double d = (double)s0.Pop();

        Console.WriteLine(s0.GetType().GetHashCode());
        Console.WriteLine(s1.GetType().GetHashCode());
        Console.WriteLine(s2.GetType().GetHashCode());
        Console.WriteLine(s3.GetType().GetHashCode());

        Stack<int>.Test = 10;
        Console.WriteLine(Stack<double>.Test);
        Stack<Demo> ss = new Stack<Demo>(5);

        int a = 1;
        int b = 2;

        Demo.Swap<int>(ref a, ref b);
        System.Console.WriteLine(a + " " + b);

        // You can also omit the type argument and the compiler will infer it. 
        //The following call to Swap is equivalent to the previous call:
        Demo.Swap(ref a, ref b);

        double d1, d2;
        d1 = 0.1;
        d2 = 0.2;
        Demo.Swap(ref d1, ref d2);
        Console.WriteLine(d1 + " " + d2);
    }
}

class Demo 
{
    public static void Swap<T>(ref T lhs, ref T rhs) where T: struct
    {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}
class ChildDemo : Demo
{
}

class Stack<T> //where T : Demo
{
    T d;
    public static int Test;
    T[] data;
    int top = -1;
    public Stack(int size)
    {
        //d.Foo();
        data = new T[size];
    }
    public void Push(T value)
    {
        top++;
        data[top] = value;
    }
    public T Pop()
    {
        T value = data[top];
        top--;
        return value;
    }
    public T GetTopElement()
    {
        return data[top];
    }
    public void Print()
    {
        for (int i = 0; i <= top; i++)
            Console.WriteLine(data[i]);
    }
}
