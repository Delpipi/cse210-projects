public class Order
{

    private Customer _customer;
    private List<Product> _products;

    //Constructors
    public Order()
    {
        _products = new List<Product>();
    }

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    //Members Functions
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double sum = _products.Sum(product => product.GetTotalCost());

        //Add shipping coast
        sum += GetShippingCost();
        return sum;
    }

    private double GetShippingCost()
    {
        return _customer.IsLiveAtUSA() ? 5.0 : 35.0;
    }

    public string GetPackingLabel()
    {
        string ids = string.Join(',', _products.Select(product => product.GetProductId()));
        string products = string.Join(',', _products.Select(product => product.GetName()));

        return $"Products: [{products}] - Ids: [{ids}]";
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_customer.GetName()} , Address: {_customer.GetSippingAddress()}";
    }
}