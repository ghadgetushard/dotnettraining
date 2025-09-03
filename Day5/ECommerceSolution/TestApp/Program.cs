using CatalogLib;

Console.WriteLine("Hello, World!");

Product latestOnDemandingProduct = new Product();
latestOnDemandingProduct.Name = "Dell laptop";
latestOnDemandingProduct.Description = "laptop";
latestOnDemandingProduct.Price = 1200.00m;

var product = new Product
{
    Id = 1,
    Name = "Test",
    Price = 19.99m,
    Description = "This is sample product",
};

Console.WriteLine(product);