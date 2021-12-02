
// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!
class Employee
{
    // Private (accessible only within this class) - encapsulation (hiding the implementation)
    // declare with readonly to initialize in constructor only
    // Several variables on one line to reduce the vulnerability window
    private readonly string _firstName, _lastName;

    // Initialize the field as they are not formal parameters
    // object constructor which will be initialized.
    private string _role = string.Empty;

    private int _experience;
    private decimal _salary;
    private decimal _taxPay;

    // Declarate and initial a constant field.
    private const decimal TAX_PAYMENT = 0.35m;

    // Declaration of a custom method of the constructor of the class object
    // Initialize the fields of the created object.
    public Employee(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    // Create object properties as an interface for accessing private fields.
    public string Role { get { return _role; } set { _role = value; } }
    public int Experience { get { return _experience; } set { _experience = value; } }

    //Encapsulation(hiding the implementation) Read only.
    public string FirstName { get { return _firstName; } }
    public string LastName { get { return _lastName; } }
    public decimal Salary { get { return _salary; } }
    public decimal TaxPay { get { return _taxPay; } }

    // Declaration of the custom GetBaseSalary () method of the class object
    // with formal parameter string role closed for access from outside the class
    // encapsulation (hiding the implementation)
    // Select base salary
    /// <summary>
    /// Selects base salary
    /// </summary>
    /// <param name="role"></param>
    /// <returns>decimal Base Salary</returns>
    private decimal GetBaseSalary(string role)
    {
        switch (_role)
        {
            case "Worker": return 1000;
            case "Engineer": return 2000;
            case "Head": return 3000;
            case "Director": return 4000;
            default:
                Console.WriteLine("The role is wrong!");
                return 0;
        }
    }

    // Declaration of the custom GetExperienceCoef() method of the class object
    // with a formal parameter double experience closed for access from outside the class
    // encapsulation (hiding the implementation)
    /// <summary>
    /// Calculats the value of the odds depending on experience
    /// </summary>
    /// <param name="experience"></param>
    /// <returns>decimal Experience Coef</returns>
    private decimal GetExperienceCoef(double experience)
    {
        bool isExper0to3 = _experience <= 3;
        bool isExper3to5 = (_experience >= 3) && (_experience <= 5);
        bool isExper5to10 = (_experience >= 5) && (_experience <= 10);
        bool isExperOver10 = _experience >= 10;

        if (isExper0to3)
        {
            return 1.15m;
        }
        else if (isExper3to5)
        {
            return 1.35m;
        }
        else if (isExper5to10)
        {
            return 1.55m;
        }
        else if (isExperOver10)
        {
            return 1.75m;
        }
        else
        {
            Console.WriteLine("The experience is wrong!");
            return 0m;
        }
    }

    // Declaration of the custom GetSalary () method of the class object
    // with formal parameters string role, int experience open for access from outside the class
    /// <summary>
    /// Calculates the valur of the salary depending on the role and experience
    /// </summary>
    /// <param name="role"></param>
    /// <param name="experience"></param>
    public void GetSalary(string role, int experience)
    {
        _role = role;
        _experience = experience;
        _salary = GetBaseSalary(role) * GetExperienceCoef(experience);
    }

    // Declaration of the custom GetTaxPayment () method of the class object
    // open for access from outside the class.
    /// <summary>
    /// Calculates the tax on the total price of the item.
    /// </summary>
    public void GetTaxPayment()
    {
        _taxPay = _salary * TAX_PAYMENT;
    }

    // Declaration of the custom Show () method of the class object
    // open for access from outside the class
    /// <summary>
    /// Displays instance Properties
    /// </summary>
    public void Show()
    {
        Console.WriteLine("First name: {0} \t Last name: {1}", FirstName, LastName);
        Console.WriteLine(new String('=', 46));

        Console.WriteLine("Role: {0}\t\t Experience: {1} years", Role, Experience);
        Console.WriteLine(new String('=', 46));

        Console.WriteLine("Salary: {0:F2} $ included Tax pay: {1:F2} $", Salary, TaxPay);
        Console.WriteLine(new String('=', 46) + "\n");
    }



}
