using System;

class Program
{
  public static void Main(string[] args)
  {
    int x = 0;
    char myChar = 'x';
    string name = "dsds" + "holy";
    double db = 5.4;
    const double myNum = 50.5;
    long sad = 213132L;
    int b, y, z;
    b = y = z = 40;


    //ép kiểu (casting)
    float t = (int)5.5; //mannual casting (ép kiểu thủ công)
    double k = t; //auto casting (kép kiểu tự động)
    Console.WriteLine("" + t);

    //có thể sử dụng buitl-in method để ép kiểu (Convert)
    Console.WriteLine(Convert.ToDouble(t));
    /*
      Convert.ToString(variable)
      Convert.ToDouble(variable)
      Convert.ToInt32(variable)
      Convert.ToInt64(variable)
      Convert.ToBoolean(variable)
    */






  }
}