using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Aptech
{
    internal interface IProduct
    {
        void InputData();
        void Display();
        List<Product> Search(double price);
        List<Product> Searsch(string name);
        void Remove(string productId);
        void Update();
    }
}
