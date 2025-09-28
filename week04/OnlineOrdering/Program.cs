using System;
using System.Collections.Generic;

namespace OrderManagement
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _pricePerUnit;
        private int _quantity;

        public Product(string name, string productId, double pricePerUnit, int quantity)
        {
            _name = name;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        public string GetName() => _name;
        public string GetProductId() => _productId;
        public double GetPricePerUnit() => _pricePerUnit;
        public int GetQuantity() => _quantity;

        public double GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }
    }

    public class Address
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public bool IsInUSA()
        {
            return _country.ToLower() == "usa" || _country.ToLower() == "united states";
        }

        public string GetFullAddress()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }

    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName() => _name;
        public Address GetAddress() => _address;

        public bool LivesInUSA()
        {
            return _address.IsInUSA();
        }
    }

    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalPrice()
        {
            double total = 0;

            foreach (var product in _products)
            {
                total += product.GetTotalCost();
            }

            total += _customer.LivesInUSA() ? 5 : 35;

            return total;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in _products)
            {
                label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
            Customer customer1 = new Customer("Alice Johnson", address1);

            Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Carlos Rodriguez", address2);

            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "P1001", 1200.00, 1));
            order1.AddProduct(new Product("Mouse", "P2001", 25.00, 2));

            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Headphones", "P3001", 150.00, 1));
            order2.AddProduct(new Product("Microphone", "P4001", 90.00, 1));
            order2.AddProduct(new Product("Webcam", "P5001", 80.00, 1));

            List<Order> orders = new List<Order> { order1, order2 };

            foreach (var order in orders)
            {
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
