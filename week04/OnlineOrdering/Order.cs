public class Order(Customer customer)
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = customer;
    private int _usaShipping = 5;
    private int _worldShipping = 35;

    // Calculate the total cost of the order
    public double GetTotalCost()
    {
        // Total cost of each product plus a one-time shipping cost.
        double orderTotal;
        // Subtotal without the shipping
        double productsTotal = 0;
        // Calculate subtotal
        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }
        // Determine the shipping tax
        if (_customer.LiveInUSA())
        {
            orderTotal = _usaShipping + productsTotal;
        }
        else
        {
            orderTotal = _worldShipping + productsTotal;
        }

        return orderTotal;
    }

    // Add a new product
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Return a string for the packaging label
    public List<string> GetPackagingLabel()
    {
        List<string> packagingLabel = new List<string>();
        // name and product id of each product
        foreach (Product product in _products)
        {
            packagingLabel.Add($"{product.GetName()} - {product.GetId()}");
        }
        return packagingLabel;
    }

    // Return a shipping label string
    public string GetShippingLabel()
    {
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress().GetAddressText();
        // the name and address of the customer
        return $"{customerName} | {customerAddress}";
    }
}