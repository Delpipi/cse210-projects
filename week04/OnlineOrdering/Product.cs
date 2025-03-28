public class Product
{

    //Members Variables
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    //Constructors
    public Product() { }

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //Members Functions
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    //Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public int GetProductId()
    {
        return _productId;
    }
    public void SetProductId(int productId)
    {
        _productId = productId;
    }

    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

}