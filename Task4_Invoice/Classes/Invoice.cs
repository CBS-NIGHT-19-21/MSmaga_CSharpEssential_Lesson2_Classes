// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!
class Invoice
{
    // Private (accessible only within this class) - encapsulation (hiding the implementation)
    // declare with readonly to initialize in constructor only
    // several variables on one line to reduce the vulnerability window.
    private readonly int _account;
    private readonly string _customer, _provider;

    // Initialize fields as they are not formal parameters
    // object constructor which will be initialized.
    private string? _article;
    private int _quantity;
    private decimal _totalCost, _vat;

    // Declaring a constant field.
    private const decimal VAT = 0.35m;

    // Declaration of a custom method of the constructor of the class object.
    // Initialize the fields of the created object.
    public Invoice(int account, string customer, string provider)
    {
        _account = account;
        _customer = customer;
        _provider = provider;
    }

    // Create object properties as an interface for accessing private fields
    // encapsulation (hiding the implementation)
    // Read only.
    public string Article { get { return _article!; } }
    public int Quantity { get { return _quantity; } }
    public int Account { get { return _account; } }
    public string Customer { get { return _customer; } }
    public string Provider { get { return _provider; } }
    public decimal VAT_COST { get { return _vat; } }
    public decimal TotalCost { get { return _totalCost; } }


    // Declaration of the custom GetPrice () method of the class object
    // closed for access from outside the class
    // encapsulation (hiding the implementation).

    /// <summary>
    ///Selects the price per unit of goods
    /// </summary>
    /// <param name="article"></param>
    /// <returns>decimal Price</returns>
    private decimal GetPrice()
    {
        switch (_article)
        {
            case "Hat": return 50;
            case "Shirt": return 100;
            case "Jince": return 120;
            case "Boots": return 150;
            default:
                Console.WriteLine("The article is wrong!");
                return 0;
        }
    }

    // Declaration of the custom GetTotalCost method of the class object
    // open for access from outside the class.
    /// <summary>
    /// Calculates the total price of the item.
    /// </summary>
    /// <param name="article"></param>
    /// <param name="quantity"></param>
    public void GetTotalCost(string article, int quantity)
    {
        _article = article;
        _quantity = quantity;
        _totalCost = quantity * this.GetPrice();
    }

    // Declaration of the custom GetVAT () method of the class object
    // open for access from outside the class.
    /// <summary>
    /// Calculates the VAT of the total price of the item
    /// </summary>
    public void GetVAT() => _vat = _totalCost* VAT;

    // Declaration of the custom Show () method of the class object
    // open for access from outside the class
    /// <summary>
    /// Displays instance Properties
    /// </summary>
    public void Show()
    {
        Console.WriteLine("Account: {0} Customer: {1} Provider: {2}",
                           Account, Customer, Provider);
        Console.WriteLine("Article: {0} Quantity: {1} TotalCost: {2} VAT_COST: {3}",
                           Article, Quantity, TotalCost, VAT_COST);

        Console.WriteLine(new String('=', 66) + "\n");
    }
}


