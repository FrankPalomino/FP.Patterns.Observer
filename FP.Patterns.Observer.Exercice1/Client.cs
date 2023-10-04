namespace FP.Patterns.Observer.Exercice1
{
    internal class Client: IObserver
    {
        public void Update(Product product)
        {
            if (product.Stock > 1)
            {
                Console.WriteLine($"Client: {product.Name} is in Stock  ");
            }
        }

        public void AddProductObserver(Product product)
        {
            product.Subscribe(this);
        }
    }
}
