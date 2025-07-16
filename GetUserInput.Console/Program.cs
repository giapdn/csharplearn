
class Program
{
  public static void Main(string[] args)
  {
    // Console.WriteLine($"Enter your name:");
    // string fullName = Console.ReadLine();
    // Console.WriteLine($"Your name is: {fullName}");


    Console.WriteLine($"Enter a number: ");
    double num = Convert.ToDouble(
      Console.ReadLine()
    );

    Console.WriteLine($"Your number is {Math.Abs(num)}");




  }
}
