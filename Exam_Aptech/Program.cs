using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Aptech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            ProductService productService = new ProductService();
            int luachon;
            double price;
            string name, id;
            while (true)
            {
                Console.WriteLine("=============MENU=============");
                Console.WriteLine("1. Nhập dữ liệu cho Product");
                Console.WriteLine("2. Hiển thị toàn bộ Product");
                Console.WriteLine("3. Tìm kiếm theo Product theo giá");
                Console.WriteLine("4. Tìm kiếm theo Product theo tên");
                Console.WriteLine("5. Xóa Product theo Id");
                Console.WriteLine("6. Sửa thông tin Product.");
                Console.WriteLine("7. Thoát");
                Console.WriteLine("Nhập lựa chọn của bạn: ");
                luachon = int.Parse(Console.ReadLine());

                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("Nhập thông tin sản phẩm: ");
                        productService.InputData();
                        break;
                    case 2:
                        Console.WriteLine("Tất cả thông tin các sản phẩm là: ");
                        productService.Display();
                        break;
                    case 3:
                        Console.WriteLine("Nhập giá cần tìm: ");
                        price = double.Parse(Console.ReadLine());

                        var PriceProduct = productService.Search(price);
                        foreach (var item in PriceProduct)
                        {
                            Console.WriteLine($"Id của sản phẩm là: {item.Id}");
                            Console.WriteLine($"Tên của sản phẩm là: {item.Name}");
                            Console.WriteLine($"Giá tiền của sản phẩm là: {item.Price}");
                            Console.WriteLine($"Số lượng sản phẩm là: {item.Quantity}");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhập tên sản phẩm muốn tìm: ");
                        name = Console.ReadLine();

                        var NameProduct = productService.Searsch(name);
                        foreach (var item in NameProduct)
                        {
                            Console.WriteLine($"Id của sản phẩm là: {item.Id}");
                            Console.WriteLine($"Tên của sản phẩm là: {item.Name}");
                            Console.WriteLine($"Giá tiền của sản phẩm là: {item.Price}");
                            Console.WriteLine($"Số lượng sản phẩm là: {item.Quantity}");
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Nhập id muốn xóa: ");
                        id = Console.ReadLine();
                        productService.Remove(id);
                        break;
                    case 6:
                        productService.Update();
                        break;
                    case 7:
                        Console.WriteLine("Bạn đã thoát chương trình!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

















//Console.Write("Nhập giá trị n: ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}

//int start = 5;
//int increment = 5; 
//int numbersPerRow = 5; 

//int totalRows = 4;

//for (int row = 0; row < totalRows; row++)
//{
//    for (int col = 0; col < numbersPerRow; col++)
//    {
//        Console.Write((start + (row * numbersPerRow + col) * increment) + " ");
//    }
//    Console.WriteLine();
//}

//Console.Write("Nhập giá trị n: ");
//int n = int.Parse(Console.ReadLine());

//for (int i = n; i > 0; i--)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}


