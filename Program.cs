namespace Example1;

class Program
{
    static void Main(string[] args)
    {
        // *iterating each line
       Console.WriteLine($"What the mass of the body?");
       string? Mass = Console.ReadLine();
       double mass = Convert.ToDouble(Mass);

       Console.WriteLine($"What the tension body?");
       string? Tension = Console.ReadLine();
       double tension = Convert.ToDouble(Tension);

       Console.WriteLine($"What the time body?");
       string? Time = Console.ReadLine();
       int time = Convert.ToInt16(Time);

        // ? Declaring the formular 
        double percentage = (mass * tension) / time;   

        // !Printing out the result to the console
        Console.WriteLine($"The weight of the body is accumulated to {percentage}");
    }
}
