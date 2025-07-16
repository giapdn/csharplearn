class Program
{
  public static void Main(string[] args)
  {
    int x = 20;
    int y = 18;
    if (x > y)
    {
      Console.WriteLine("x is greater than y");
    }

    //Toán tử ba ngôi:

    Console.WriteLine((x > y) ? "ok" : "fack");


    //Switch

    switch (x)
    {
      case 20:
        Console.WriteLine($"Text");

        break;

      default:
        Console.WriteLine($"d");

        break;
    }

  }
}