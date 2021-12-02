// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.
class User
{
    // Create an instance of user1 of the User class
    private readonly string _login, _firstName, _lastName;
    private readonly int _age;

    // Assigned not as a formal parameter, but inside the constructor.
    private readonly DateTime _regDateTime;

    // Declaration of a custom method of the constructor of the class object.
    // Initialize the fields of the created object.
    public User(string login, string firstName, string lastName, int age)
    {
        _login = login;
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _regDateTime = DateTime.Now;
    }

    public string Login { get { return _login; } }
    public string FirstName { get { return _firstName; } }
    public string LastName { get { return _lastName; } }
    public int Age { get { return _age; } }
    public DateTime RegDateTime { get { return _regDateTime; } }

    // Declaration of the custom Show() method of the class object
    // open for access from outside the class
    // displaying instance fields - class object.
    /// <summary>
    /// Displays instance Properties 
    /// </summary>
    public void Show()
    {
        Console.WriteLine("Login:{0}\t First Name:{1}\t Last Name:{2}\t Age:{3}\t Registration: {4}",
                           Login, FirstName, LastName, Age, RegDateTime);
        Console.WriteLine(new String('=', 106) + "\n");
    }
}

