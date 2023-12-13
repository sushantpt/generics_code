using GenericsExample.Interface;

namespace GenericsExample.Classes
{
    public class Warehouse<T> where T : IProductService
    {
        private List<T> _items;

        public Warehouse()
        {
            _items = new List<T>();
        }

        public void AddItem(T item)
        {
            _items.Add(item);
            Console.WriteLine("Item added successfully.");
        }

        public void RemoveItem(T item)
        {
            _items.Remove(item);
            Console.WriteLine("Item removed.");
        }

        public void TotalItems()
        {
            int itemsCount = _items.Count;
            Console.WriteLine($"Total items in the ware house: {itemsCount}");
        }

        public void DisplayAllProductDetails()
        {
            foreach(T item in _items)
            {
                item.DisplayProductDetails();
            }
        }
    }
}
