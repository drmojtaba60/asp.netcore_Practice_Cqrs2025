using MyCqrsPractice2025.Domain.Common.Entities;
using MyCqrsPractice2025.Domain.Enums;
using MyCqrsPractice2025.Domain.Events;

namespace MyCqrsPractice2025.Domain;

public class Product : SoftDeletableEntity<int>
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public ProductStatus Status { get; private set; }

    public Product(string name, decimal price)
    {
        Id = 0;
        Name = name;
        Price = price;
        Status = ProductStatus.Available;

        AddDomainEvent(new ProductCreatedEvent(Id));
    }
    
    // Behavior
    public void DecreaseStock(int amount)
    {
        if (amount > 100000)
            throw new InvalidOperationException("Not enough stock.");
        
        //Stock -= amount;
    }
}