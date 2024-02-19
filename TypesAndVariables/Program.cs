class Program
{
    static void Main(string[] args)
    {
        //Value Types
       
        decimal number6 = 10;
        double number5 = 10.4; //64 bit
        char character = 'A'; //ASCII
        bool condition = false;
        byte number4 = 255;
        short number3 = 32767;
        int number1 = 2147483647;
        long number2 = 9223372036854775807;
        var number7 = 10;
        number7 = 'A';
        //number7 = "A";

        Console.WriteLine("number1 is {0}", number1);
        Console.WriteLine("number2 is {0}", number2);
        Console.WriteLine("number3 is {0}", number3);
        Console.WriteLine("number4 is {0}", number4);
        Console.WriteLine("Caharacter is : {0}", (int)character);
        Console.WriteLine("number5 is {0}", number5);
        Console.WriteLine("number7 is {0}", number7);
        Console.WriteLine((int)Days.Friday);
        Console.ReadLine();
    }

    enum Days
    {
        Monday=10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday, Sunday
    }
}
