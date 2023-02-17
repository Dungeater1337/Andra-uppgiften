using System; 

class Program
{
    static void Main(string[] agrs)
    {
        Console.WriteLine("Inmata 1. eller 2. för att välja en av det två alternativen.");
        Console.WriteLine("1: Omvandla från Celsius till Farenheit.");
        Console.WriteLine("2: Omvandla från Farenheit till Celsious");
        int val = int.Parse(Console.ReadLine());

        switch (val)
        {
            case 1:
                Console.WriteLine("Skriv in antal grader föt Celsius");
                int C = int.Parse(Console.ReadLine());

                double grader = CTILLF(C);
                Console.WriteLine("I farenheit blir det " + grader);



                break;

            case 2:
                Console.WriteLine("Skriv in antal grader för Farenheit");
                int F = int.Parse(Console.ReadLine());

                double grader2 = FTILLC(F);
                Console.WriteLine("I Celsius blir det " + grader2);
                break;
        }
    }

    static double CTILLF(double C)
    {
        double F = 32 + C * 1.8;
        return F;
    }

    static double FTILLC(double F)
    {
        double C = (F - 32) / 1.8;
        return C;
    }
}