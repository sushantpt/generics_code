using GenericsExample.Interface;

namespace GenericsExample.Classes
{
    public class Cloth : IProductService
    {
        private string _type { get; set; }
        private int? _price { get; set; }

        public Cloth(string type, int price)
        {
            _type = type;
            _price = price;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"A cloth product of type:{_type}");
        }

        public int GetProductPrice()
        {
            return _price ?? 0;
        }
    }
}


