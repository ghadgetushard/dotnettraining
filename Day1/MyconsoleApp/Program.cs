using Catalog;

int count = 45;
count++;
if (count > 50)
{
    Console.WriteLine("Count is more than 50");
}
else
{
    Console.WriteLine(count +" count is within the Limit");
}
Console.WriteLine(count);

Console.WriteLine("MyConsoleApp >> Hello, World!");

Product product = new Product("Laptop", 10m);
Console.WriteLine($"Product Name : {product.GetName()}, Price : {product.GetPrice()}");
