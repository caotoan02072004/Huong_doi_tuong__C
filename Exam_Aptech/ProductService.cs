using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Aptech
{
    internal class ProductService : IProduct
    {
        List<Product> products = new List<Product>();
        public void Display()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Id của sản phẩm là: {item.Id}");
                Console.WriteLine($"Tên của sản phẩm là: {item.Name}");
                Console.WriteLine($"Giá tiền của sản phẩm là: {item.Price}");
                Console.WriteLine($"Số lượng sản phẩm là: {item.Quantity}");
                Console.WriteLine();
            }
        }

        public void InputData()
        {
            int n;

            Console.WriteLine("nhập số lượng sản phẩm muốn thêm: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập Id của sản phẩm: ");
                string id = Console.ReadLine();
                Console.WriteLine("Nhập tên sản phẩm: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhập giá sản phẩm: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số lượng sản phẩm: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                products.Add(new Product(id, name, price, quantity));
            }
        }

        public void Remove(string productId)
        {
            var result = products.FirstOrDefault(x => x.Id == productId);
            products.Remove(result);
            Console.WriteLine("Xóa sản phẩm thành công!");
        }

        public List<Product> Search(double price)
        {
            var result = products.Where((x => x.Price >= price)).ToList();
            return result;
        }

        public List<Product> Searsch(string name)
        {
            var result = products.Where((x => x.Name.Contains(name))).ToList();
            return result;
        }

        public void Update()
        {
            Console.WriteLine("Nhập Id của sản phẩm cần cập nhật: ");
            string id = Console.ReadLine();

            var result = products.FirstOrDefault((x => x.Id == id));

            Console.WriteLine("Nhập tên mới: ");
            result.Name = Console.ReadLine();
            Console.WriteLine("Nhập giá mới: ");
            result.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số lượng sản phẩm mới: ");
            result.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Cập nhật thành công!");
        }
    }
}
