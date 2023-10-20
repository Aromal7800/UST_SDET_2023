// See https://aka.ms/new-console-template for more information
using Assignment_4_oct_20;




ElectronicProduct[] Eproducts = new ElectronicProduct[3];
for (int i = 0; i < Eproducts.Length; i++)
{
    Console.WriteLine("Enter the product name");
    string productName = Console.ReadLine();
    Console.WriteLine("Enter the product Price");
    int productprice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the product Quantity");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the warranty Period");
    int warrantyPeriod = Convert.ToInt32(Console.ReadLine());
    Eproducts[i] = new ElectronicProduct(productName, productprice, quantity,warrantyPeriod);
    if (i < Eproducts.Length)
    {
        Console.WriteLine("enter the next Electronic product");
    }

}
Console.WriteLine("Electronic Product Details Are ");
for (int i = 0; i < Eproducts.Length; i++)
{
    Eproducts[i].DisplayDetails();
    Eproducts[i].DisplayTotalPrice();
    Eproducts[i].DisplayWarrentyPeriod();
}
DigitalProduct[] Dproducts = new DigitalProduct[3];
for (int i = 0; i < Eproducts.Length; i++)
{
    Console.WriteLine("Enter the product name");
    string productName = Console.ReadLine();
    Console.WriteLine("Enter the product Price");
    int productprice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the product Quantity");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the warranty Period");
    int warrantyPeriod = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the file Formal");
    string fileFormat= Console.ReadLine();
    Dproducts[i] = new DigitalProduct(productName, productprice, quantity, warrantyPeriod,fileFormat);
    if (i < Dproducts.Length)
    {
        Console.WriteLine("enter the next Digital product");
    }

}
Console.WriteLine("Digital Product Details Are ");
for (int i = 0; i < Dproducts.Length; i++)
{
    Dproducts[i].DisplayDetails();
    Dproducts[i].DisplayTotalPrice();
    Dproducts[i].DisplayWarrentyPeriod();
    Dproducts[i].DisplayFileFormat();   
}
ClothingProduct[] Cproducts = new ClothingProduct[3];
for (int i = 0; i < Cproducts.Length; i++)
{
    Console.WriteLine("Enter the product name");
    string productName = Console.ReadLine();
    Console.WriteLine("Enter the product Price");
    int productprice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the product Quantity");
    int quantity = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the warranty Period");
    int warrantyPeriod = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the file Formal");
    string fileFormat = Console.ReadLine();
    Console.WriteLine("Enter cloth Size");
    string size= Console.ReadLine();
    Cproducts[i] = new ClothingProduct(productName, productprice, quantity,size);
    if (i < Cproducts.Length)
    {
        Console.WriteLine("enter the next Digital product");
    }

}
Console.WriteLine("Digital Product Details Are ");
for (int i = 0; i < Cproducts.Length; i++)
{
    Cproducts[i].DisplayDetails();
    Cproducts[i].DisplayTotalPrice();
    Cproducts[i].displaySize();
}