namespace VendingApp;

/// Конкретный товар, который продаётся через вендинг-автомат.
/// Содержит цену и количество, хранит код и название
public class Food : Item
{
    public decimal Price    { get; private set; }
    public int     Quantity { get; private set; }

    public Food(string code, string name, decimal price, int qty)
    {
        Code     = code;
        Name     = name;
        Price    = price;
        Quantity = qty;
    }

    public bool Dispense()
    {
        if (Quantity == 0) return false;
        Quantity--;
        return true;
    }

    public void Refill(int amount) => Quantity += amount;
}