

// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class
class Converter
{
    // Private(accessible only within this class) - encapsulation(hiding the implementation).
    // Declare with readonly to initialize in constructor only
    // Several variables on one line to reduce the vulnerability window.
    private decimal _exchRateHRtoUSD, _exchRateHRtoEuro, _exchRateHRtoRub;

    // Declaration of a custom method of the constructor of the class object.
    // Initialize the fields of the created object.
    public Converter(decimal usd, decimal euro, decimal rub)
    {
        _exchRateHRtoUSD = usd;
        _exchRateHRtoEuro = euro;
        _exchRateHRtoRub = rub;
    }


    /// <summary>
    /// Calcs Exchange Amount, using private methods of the Converter class.
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="fromValue"></param>
    /// <param name="toValue"></param>
    public void Exchange(decimal amount, string fromValue, string toValue)
    {
        if (fromValue == "HR")
        {
            if (toValue == "USD") { Console.WriteLine("Amount = {0:F2} USD", GetUSDfromHR(amount)); }
            else if (toValue == "Euro") { Console.WriteLine("Amount = {0:F2} Euro", GetEurofromHR(amount)); }
            else if (toValue == "Rub") { Console.WriteLine("Amount = {0:F2} Rub", GetRubfromHR(amount)); }
        }

        if (fromValue == "USD") { Console.WriteLine("Amount = {0:F2} HR", GetHRfromUSD(amount)); }
        else if (fromValue == "Euro") { Console.WriteLine("Amount = {0:F2} HR", GetHRfromEuro(amount)); }
        else if (fromValue == "Rub") { Console.WriteLine("Amount = {0:F2} HR", GetHRfromRub(amount)); }
    }

    // Declaration of the custom GetHRfromUSD() method of the class object
    // close for access from outside the class..
    /// <summary>
    /// Calculates HR from USD
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>decimal HR</returns>
    private decimal GetHRfromUSD(decimal amountUSD)
    {
        return amountUSD * _exchRateHRtoUSD;
    }

    // Declaration of the custom GetUSDfromHR() method of the class object
    // close for access from outside the class.
    /// <summary>
    /// Calculates USD from HR
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>decimal USD</returns>
    private decimal GetUSDfromHR(decimal amountHr)
    {
        return amountHr / _exchRateHRtoUSD;
    }

    // Declaration of the custom GetHRfromEuro() method of the class object
    // close for access from outside the class.
    /// <summary>
    /// Calculates HR from Euro
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>decimal HR</returns>
    private decimal GetHRfromEuro(decimal amountEuro)
    {
        return amountEuro * _exchRateHRtoEuro;
    }

    // Declaration of the custom GetEurofromHR() method of the class object
    // close for access from outside the class.
    /// <summary>
    /// Calculates Euro from HR
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>decimal Euro</returns>
    private decimal GetEurofromHR(decimal amountHr)
    {
        return amountHr / _exchRateHRtoEuro;
    }

    // Declaration of the custom GetHRfromRub() method of the class object
    // close for access from outside the class.
    /// <summary>
    /// Calculates HR from Rub
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>decimal HR</returns>
    private decimal GetHRfromRub(decimal amountRub)
    {
        return amountRub * _exchRateHRtoRub;
    }

    // Declaration of the custom GetRubfromHR() method of the class object
    // close for access from outside the class.
    /// <summary>
    /// Calculates Rub from HR
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>decimal Rub</returns>
    private decimal GetRubfromHR(decimal amountHr)
    {
        return amountHr / _exchRateHRtoRub;
    }
}

