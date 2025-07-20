using MyCqrsPractice2025.Domain.Common.Entities;
using MyCqrsPractice2025.Domain.ValueObjects;

namespace MyCqrsPractice2025.Domain;

public class Customer : SoftDeletableEntity<int>
{
    public string Name { get; private set; }
    public Address Address { get; private set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public Customer() // for ef
    {
        
    }
}