public delegate int Calculater(int method1, int method2);
internal class Program
{  
    //method 1
    static int Add(int num1, int num2)
    {

        return (num1 + num2);
    }

    //method 2
    static int Sub(int num1, int num2)
    {

        return (num1 - num2);
    }

    private static void Main(string[] args)
    {
        int value1 = 5; //field 1
        int value2 = 10;  //field 2

        Calculater newCalculater = new Calculater(Add);
        Calculater newCalculater1 = new Calculater(Sub);

        Console.WriteLine(value1 + " + " + value2 + " = " +
         newCalculater(value1, value2));

        Console.WriteLine("----------------------");

        Console.WriteLine(value2 + " - " + value1 + " = " +
         newCalculater1(value2, value1));

    }
}