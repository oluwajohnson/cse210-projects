public class Product
{
    private string _name;
    private int _productId;
    private int _price;
    private int _quantity;

    public Product()
    {
        _name = "";
        _productId = 0;
        _price = 0;
        _quantity = 0;
    }

    public Product(int quantity, int price)
    {

        _quantity = quantity;
        _price = price;
    }



}