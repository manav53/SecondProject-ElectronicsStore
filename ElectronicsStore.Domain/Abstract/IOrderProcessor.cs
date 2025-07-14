using ElectronicsStore.Domain.Entities;

namespace ElectronicsStore.Domain.Abstract {

    public interface IOrderProcessor {

        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
