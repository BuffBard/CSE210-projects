class Program
{
    static void Main(string[] args)
    {
        List<Address> addresses = [
            new Address("321 E 3rd S","El Paso","TX","USA"),
            new Address("4th and Elm","Calidor","Calamine","Phyrexia")
        ];
        List<Customer> customers = [
            new Customer("Greg",addresses[0]),
            new Customer("Jin Gitaxes",addresses[1])
        ];
        List<Product> products = [
            new Product("Hair Gel","AD6004189",9.89,3),
            new Product("Bugs Bunny Plushies","BG4190023",4.59,200),
            new Product("iMac Mini","AG1000957",999.99,1),
            new Product("Comically Large Piano","BE6589303",12.51,6),
            new Product("Mind Control Helmet","MR2122002",40.99,1200)
        ];
        List<Order> orders = [
            new Order([products[0],products[2]],customers[0]),
            new Order([products[1],products[3],products[4]],customers[1])
        ];
        foreach(Order order in orders)
        {
            order.FindTotalPrice();
            order.PackingLabel();
            order.ShippingLabel();
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}\n");
        }
    }
}