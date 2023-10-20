// See https://aka.ms/new-console-template for more information
using Assingnment_2_oct_19;



Product[] products = new Product[3];
for(int i = 0; i < products.Length; i++)
{
    Console.WriteLine("Enter the product name");
    string productName=Console.ReadLine();
    Console.WriteLine("Enter the product Price");
    int productprice=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the product Quantity");
    int quantity=Convert.ToInt32(Console.ReadLine());   
    products[i]=new Product(productName, productprice, quantity);
    if (i < products.Length)
    {
        Console.WriteLine("enter the next product");
    }

}
Console.WriteLine("Product Details Are ");
for(int i=0; i < products.Length; i++)
{
    products[i].DisplayDetails();
    products[i].DisplayTotalPrice();
}