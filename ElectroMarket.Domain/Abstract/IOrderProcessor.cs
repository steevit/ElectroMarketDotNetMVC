using ElectroMarket.Domain.Entities;

namespace ElectroMarket.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
