using FP.Patterns.Observer.Exercice1;

Product product = new Product();

Client client = new Client();

client.AddProductObserver(product);

product.Name = "Product 1";
product.AddStock(10);