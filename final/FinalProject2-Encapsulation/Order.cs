public class Order
{
    private int _orderCost;
    private string _packingLabel;
    private string _shippingLabel;
    private int _shippingCost;

    public Order()
    {
        _orderCost = 0;
        _packingLabel = "Anonymous";
        _shippingLabel = "Unknown";
        _shippingCost = 0;
    }

    public void TotalPriceInUsa(int orderCost)
    {
        _orderCost = orderCost;
        _shippingCost = 5;
        return Console.WriteLine($"Total Price in USA: {_orderCost * _shippingCost}");
    }

    public void TotalPriceOutSideUsa(int orderCost)
    {
        _orderCost = orderCost;
        _shippingCost = 35;
        return Console.WriteLine($"Total Price Outside USA: {_orderCost * _shippingCost}");
    }


}