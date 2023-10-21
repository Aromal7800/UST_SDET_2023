// See https://aka.ms/new-console-template for more information
using Case_Study_1;
using System.Transactions;
int flag = 0;
do
{
    
    Console.WriteLine("Aroo Books");
    Console.WriteLine("1.Enter Book Details :");
    Console.WriteLine("2.Enter the coustomer Details :");
    Console.WriteLine("3.Enter order details and Display order details:");

    Console.WriteLine("4.Search book");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Book book = new Book();
                Console.WriteLine("Enter the book title");
                book.title = Console.ReadLine();
                Console.WriteLine("Enter the ISBN");

                book.ISBN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the book author");

                book.author = Console.ReadLine();
                Console.WriteLine("Enter the book price :");
                book.price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("0.Not Availability 1.Not Available");
                book.availability = Console.ReadLine();
                Console.WriteLine("Enter the book type :");
                book.type = Console.ReadLine();
                //Console.WriteLine("ISBN : {0}\tAuthor : {1}\t title : {2} \t Price : {3} \t availability : {4}\t type {5}", book.ISBN, book.title, book.price, book.availability, book.type);
                book.AddBook(book);
                book.viewBooks();
                break;
            }
        case 2:
            {
                Customer customer = new Customer();
                Console.WriteLine("Enter the customer name");
                customer.name = Console.ReadLine();
                Console.WriteLine("Enter customer id");
                customer.CustomerID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Customer contact details");
                customer.contact_details = Console.ReadLine();
                customer.Add_Customer(customer);
                customer.View_All_customer();
                break;
            }
        case 3:
            {

                Console.WriteLine("Enter Order Date :");
                string order_date = Console.ReadLine();
                Console.WriteLine("Enter total cost :");
                int Total_Cost = Convert.ToInt32(Console.ReadLine());
                Order order = new Order(order_date, Total_Cost);
                order.ViewOrderDetails();
                break;
            }
 
        case 4:
            {
                Console.WriteLine("enter the book isbn");
                int isbn=Convert.ToInt32( Console.ReadLine());
                Book book = new Book();
                book.SearchBook(isbn);
                break;
            }


    }
    Console.WriteLine("Do you want to continue 1.yes 2.no");
    flag = Convert.ToInt32(Console.ReadLine());

} while (flag == 1);





