using System;
using System.Linq;
class Program
{
  public static void Main(string[] args)
  {
    //while

    // int i = 0;

    // while (i <= 5)
    // {
    //   Console.WriteLine($"{i}");
    //   i++;
    // }

    //do/while

    // int i = 0;
    // do
    // {
    //   Console.WriteLine($"Text");

    // } while (i != 0);

    //for + nested loop
    // for (int i = 0; i <= 5; i++)
    // {
    //   for (int j = 1; j < 5; j++)
    //   {
    //     Console.WriteLine($"{i} - {j}");
    //   }
    // }

    //break, continue

    // for (int i = 0; i < 5; i++)
    // {

    //   if (i == 3)
    //   {
    //     // i++;
    //     continue; //bỏ qua 3 và tiếp tục sang 4
    //     // break; // dừng vòng lặp nếu i chạm 3
    //   }
    //   Console.WriteLine($"Hello {i}");

    // }


    /* Array */
    // cú pháp khai báo 1 array: <Type>[] name; || <>[] name = {}; nếu muốn assign giá trị ngay từ ban đầu

    // string[] cars;
    // string[] cars2 = ["1", "2", "3"];

    // foreach (string car in cars2)
    // {
    //   Console.WriteLine($"{car}");

    // }

    // cars2[2] = "BMW"; // thay đổi giá trị 2 -> BMW
    // Console.WriteLine($"{cars2.Length} cars"); //độ dài mảng từ 0 -> n
    // Console.WriteLine($"{cars2[2]}"); // truy caajp phaafn tuwr cura marng

    // int[] numbers;
    // numbers = [1, 2, 3, 4]; //thêm giá trị

    // for (int i = 0; i < numbers.Length; i++)
    // {
    //   Console.WriteLine($"{numbers[i]}");
    // }


    //các phương thức hỗ trợ (dùng System.Linq)
    int[] nums;

    nums = [1, 2, -3, -4, 5, 7, -7];

    // Console.WriteLine(nums.Max());
    Console.WriteLine(nums.Sum());
    

    // Array.Sort(nums);
    // for (var i = 0; i < nums.Length; i++)
    // {
    //   Console.WriteLine($"{nums[i]}");

    // }




  }
}