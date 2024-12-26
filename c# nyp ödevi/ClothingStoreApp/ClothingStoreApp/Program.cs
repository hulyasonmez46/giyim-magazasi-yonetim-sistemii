using System;
using System.Collections.Generic;
using System.Linq;
using ClothingStoreLibrary;

namespace ClothingStoreApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreManager storeManager = new StoreManager();
            int choice;

            do
            {
                Console.WriteLine("\n==== Clothing Store Management ====");
                Console.WriteLine("1. Manage Inventory");
                Console.WriteLine("2. Manage Customers");
                Console.WriteLine("3. Manage Orders");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ManageInventory(storeManager);
                        break;
                    case 2:
                        ManageCustomers(storeManager);
                        break;
                    case 3:
                        ManageOrders(storeManager);
                        break;
                    case 4:
                        Console.WriteLine("Exiting... Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            } while (choice != 4);
        }

        static void ManageInventory(StoreManager storeManager)
        {
            int choice;
            do
            {
                Console.WriteLine("\n=== Inventory Management ===");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. List Items");
                Console.WriteLine("3. Search Item");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Item ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Item Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Size: ");
                        string size = Console.ReadLine();
                        Console.Write("Enter Category: ");
                        string category = Console.ReadLine();
                        Console.Write("Enter Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        Console.Write("Is in Stock (true/false): ");
                        bool inStock = bool.Parse(Console.ReadLine());

                        storeManager.AddItemToInventory(new Item
                        {
                            ItemId = id,
                            Name = name,
                            Size = size,
                            Category = category,
                            Price = price,
                            InStock = inStock
                        });
                        Console.WriteLine("Item added successfully!");
                        break;

                    case 2:
                        storeManager.ListInventory();
                        break;

                    case 3:
                        Console.Write("Enter Item ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        var item = storeManager.SearchItem(searchId);
                        if (item != null)
                            Console.WriteLine(item.GetDetails());
                        else
                            Console.WriteLine("Item not found!");
                        break;

                    case 4:
                        Console.WriteLine("Returning to Main Menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            } while (choice != 4);
        }

        static void ManageCustomers(StoreManager storeManager)
        {
            List<Customer> customers = new List<Customer>();
            int choice;

            do
            {
                Console.WriteLine("\n=== Customer Management ===");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. List Customers");
                Console.WriteLine("3. Search Customer by ID");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Customer ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Customer Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Customer Contact: ");
                        string contact = Console.ReadLine();

                        customers.Add(new Customer
                        {
                            CustomerId = id,
                            Name = name,
                            Contact = contact
                        });

                        Console.WriteLine("Customer added successfully!");
                        break;

                    case 2:
                        Console.WriteLine("\nList of Customers:");
                        foreach (var custome in customers)
                        {
                            Console.WriteLine(custome.GetCustomerInfo());
                        }
                        break;

                    case 3:
                        Console.Write("Enter Customer ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        var customer = customers.FirstOrDefault(c => c.CustomerId == searchId);
                        if (customer != null)
                            Console.WriteLine(customer.GetCustomerInfo());
                        else
                            Console.WriteLine("Customer not found!");
                        break;

                    case 4:
                        Console.WriteLine("Returning to Main Menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            } while (choice != 4);
        }


        static void ManageOrders(StoreManager storeManager)
        {
            int choice;

            do
            {
                Console.WriteLine("\n=== Order Management ===");
                Console.WriteLine("1. Create New Order");
                Console.WriteLine("2. List Orders");
                Console.WriteLine("3. Cancel Order");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Customer ID: ");
                        int customerId = int.Parse(Console.ReadLine());
                        var customer = new Customer { CustomerId = customerId, Name = "Customer" + customerId }; // Temporary customer creation.

                        Console.Write("Enter number of items to add to order: ");
                        int itemCount = int.Parse(Console.ReadLine());
                        var order = new Order { Customer = customer };

                        for (int i = 0; i < itemCount; i++)
                        {
                            Console.Write("Enter Item ID: ");
                            int itemId = int.Parse(Console.ReadLine());
                            var item = storeManager.SearchItem(itemId);
                            if (item != null)
                            {
                                order.AddItem(item);
                                Console.WriteLine($"Item {item.Name} added to the order.");
                            }
                            else
                            {
                                Console.WriteLine("Item not found!");
                            }
                        }

                        storeManager.PlaceOrder(order);
                        Console.WriteLine($"Order created successfully with ID: {order.OrderId}");
                        break;

                    case 2:
                        Console.WriteLine("\nList of Orders:");
                        storeManager.ListOrders();
                        break;

                    case 3:
                        Console.Write("Enter Order ID to cancel: ");
                        int orderId = int.Parse(Console.ReadLine());
                        var existingOrder = storeManager.Orders.FirstOrDefault(o => o.OrderId == orderId);
                        if (existingOrder != null)
                        {
                            storeManager.Orders.Remove(existingOrder);
                            Console.WriteLine($"Order {orderId} canceled successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Order not found!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Returning to Main Menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            } while (choice != 4);
        }

    }
}
