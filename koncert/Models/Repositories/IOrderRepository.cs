using koncert.Models.Entities;

namespace koncert.Models.Repositories;

public interface IOrderRepository
{
    void CreateOrder (Order order);
}
