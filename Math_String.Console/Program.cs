class Program
{
  public static void Main(string[] args)
  {

    /* 
      Math.Max/Min(param1, p2, ...)
      Math.Sqrt(param)
      Math.Abs(param)
      Math.Round(param with type double is rcmd)
    */

    //Strin

    // string firstName = "John";
    // string lastName = "Doe";
    // string name = $"My full name is: {firstName} {lastName}";

    // Console.WriteLine(name.Length);//.ToUpper, .ToLower, 
    // Console.WriteLine(name[0]); // index access trả về value -> M
    // Console.WriteLine(name.IndexOf("D")); //trả về vị trí


    string name = "Đỗ\"s Nguyên Giáp";

    //Concat(strin1, string2) -> keest noi 2 chuoi tương tự như +

    int letter = name.IndexOf("ê");
    string firstName = name.Substring(0, letter); //trả về phần còn lại của chuỗi bị sub từ index sang phải, thêm 0 để ngược lại

    Console.WriteLine(firstName); //index of là ê -> trả về phần sau ê -> ên Giáp, truyền 0 và sub thì trả về phần trước ê -> Đỗ nguy






  }
}