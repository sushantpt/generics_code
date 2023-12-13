using GenericsExample.Interface;

namespace GenericsExample.Classes
{
    public class Shoe : IProductService
    {
        private string _brand { get; set; }
        private int _size { get; set; }
        private int ? _price { get; set; }

        public Shoe(string brand, int size, int? price)
        {
            _brand = brand;
            _size = size;
            _price = price;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"A shoe product of brand: {_brand} and of size: {_size}");
        }

        public int GetProductPrice()
        {
            return _price ?? 0;
        }
    }
}
