using System;

namespace Labguide_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int[] array = new int[10];
            while (true)
            {
                Console.WriteLine("\n1-Khởi tạo một mảng 1 chiều số nguyên gồm 10 phần tử.");
                Console.WriteLine("2-Tìm phần tử nhỏ nhất của mảng.");
                Console.WriteLine("3-Đảo ngược mảng.");
                Console.WriteLine("4-Sắp xếp mảng tăng hoặc giảm.");
                Console.WriteLine("5-Tìm phần tử là số nguyên tố.");
                Console.WriteLine("6-In ra số lượng các số dương liên tiếp nhiều nhất.");
                Console.WriteLine("7-Tính trung bình cộng các phần tử dương.");
                Console.WriteLine("8-Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không?.");
                Console.WriteLine("9-Thoát.");
                int choose;
                Console.WriteLine("CHỌN CHỨC NĂNG:");
                choose = Convert.ToInt16(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        for (int i = 1; i < 11; i++)
                        {
                            Console.WriteLine("Nhập phần tử mảng thứ "+i+":");
                            array[i - 1] = (int)Convert.ToInt64(Console.ReadLine());
                        }
                        Console.WriteLine("Success!");
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write(array[i]+"\t");
                        }
                        break;
                    case 2:
                        if (array.Length>10)
                        {
                            int min = array[0];
                            for (int i = 0; i < array.Length; i++)
                            {
                                min = (min > array[i]) ? array[i] : min;
                            }
                            Console.WriteLine("Phần tử nhỏ nhất của mảng là: " + min);
                            break;
                        }
                        Console.WriteLine("ERROR! Chưa có phần tử nào trong mảng.");
                        break;
                    case 9:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Vui lòng chọn từ 1 đến 9.");
                        break;
                }
            }
        }
    }
}
