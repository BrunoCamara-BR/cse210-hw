using System.Net.Http.Headers;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();


    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product item)
    {
        _products.Add(item);
    }

    public double TotalOrderCost()
    {

        double total = 0.0;
        foreach (Product i in _products)
        {
            total += i.Total();
        }

        return total + ShippingCost();
    }
    private double ShippingCost()
    {
        double shippingCost = 0.0;
        if (_customer.IsFromUS())
        {
            shippingCost = 5.00;
        }
        else
        {
            shippingCost = 35.00;
        }
        return shippingCost;
    }
    public string PackingLabel()
    {
        string FullPackingLabel = "\t\t--- Packing Label ---\n";
        foreach (Product i in _products)
        {
            FullPackingLabel += $"Product:{i.GetName()}\tID:{i.GetID()}\n";
        }
        return FullPackingLabel;
    }
    public string ShippingLabel()
    {
        string FullShippingLabel = "\t\t--- Shipping Label ---\n";
        FullShippingLabel += $"Customer:\n\tName:{_customer.GetName()}\n\tAddress:{_customer.GetAddress()}\n";

        return FullShippingLabel;
    }
}