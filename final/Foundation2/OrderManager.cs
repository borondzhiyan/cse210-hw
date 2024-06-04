using System;

public class OrderManager {
   private List<Order> _orders;

    public OrderManager(){
        _orders=new List<Order>();
    }
    public void AddProduct(Order order){
        Console.WriteLine("Please introduce a product name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please introduce a product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please introduce a price: ");
        float price = float.Parse(Console.ReadLine());
        Console.WriteLine("Please introduce a quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        Product product = new Product(name, id, price, quantity);
        order.AddProduct(product);
    }

    public void CreateOrder(){
        Console.WriteLine("Write your name: ");
        string name = Console.ReadLine();
        Console.WriteLine ("Write your street: ");
        string street = Console.ReadLine();
        Console.WriteLine ("Write your city: ");
        string city = Console.ReadLine();
        Console.WriteLine ("Write your state: ");
        string state = Console.ReadLine();
        Console.WriteLine ("Write your country: ");
        string country = Console.ReadLine();
        Console.WriteLine ("Are you from the USA: yes - 1 /no - 0 ");
        int isUsaString = Convert.ToInt32(Console.ReadLine());
        bool isUsa=false;
        if (isUsaString==1){
            isUsa=true;
        }
        Address address = new Address(street, city, state, country, isUsa);
        Customer customer = new Customer(name, address);
        Order order = new Order (customer);
        bool flag=true;
        while (flag){
            Console.WriteLine("If you want to introduce a product into this order set 1");
            string choice = Console.ReadLine();
            if (choice=="1"){
                AddProduct(order);
            }
            else {flag=false;}
        }
        _orders.Add(order);
    }
        public void GetOrderList(){
        foreach (Order order in _orders){
            Console.WriteLine("Order");
            string orderString=$"{order.GetPackingLabel()}\n{order.GetShippingLabel()}\nPrice: {order.GetTotalPrice()}";
            Console.WriteLine(orderString);
            Console.WriteLine();
        }
        }

    public void Start(){
        while (true){
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create order");
            Console.WriteLine("2.Show the order list");
            Console.WriteLine("3.Quit");
            Console.Write("What is your choice 1-3? ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch(choice){
                case 1:
                CreateOrder();
                break;
                case 2:
                GetOrderList();
                break;
                case 3:
                return;

            }
        }
    }
    
}