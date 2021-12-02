

// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class
class Converter
{
    // Private(accessible only within this class) - encapsulation(hiding the implementation).
    // Declare with readonly to initialize in constructor only
    // Several variables on one line to reduce the vulnerability window.
    private readonly double _exchRateHRtoUSD, _exchRateHRtoEuro, _exchRateHRtoRub;

    // Declaration of a custom method of the constructor of the class object.
    // Initialize the fields of the created object.
    public Converter(double usd, double eur, double rub)
    {
        _exchRateHRtoUSD = usd;
        _exchRateHRtoEuro = eur;
        _exchRateHRtoRub = rub;
    }

    // Declaration of the custom GetHRfromUSD() method of the class object
    // open for access from outside the class..
    /// <summary>
    /// Calculates HR from USD
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>double HR</returns>
    public double GetHRfromUSD(double amountUSD)
    {
        return amountUSD * _exchRateHRtoUSD;
    }

    // Declaration of the custom GetUSDfromHR() method of the class object
    // open for access from outside the class.
    /// <summary>
    /// Calculates USD from HR
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>double USD</returns>
    public double GetUSDfromHR(double amountHr)
    {
        return amountHr / _exchRateHRtoUSD;
    }

    // Declaration of the custom GetHRfromEuro() method of the class object
    // open for access from outside the class.
    /// <summary>
    /// Calculates HR from Euro
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>double HR</returns>
    public double GetHRfromEuro(double amountEuro)
    {
        return amountEuro * _exchRateHRtoEuro;
    }

    // Declaration of the custom GetEurofromHR() method of the class object
    // open for access from outside the class.
    /// <summary>
    /// Calculates Euro from HR
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>double Euro</returns>
    public double GetEurofromHR(double amountHr)
    {
        return amountHr / _exchRateHRtoEuro;
    }

    // Declaration of the custom GetHRfromRub() method of the class object
    // open for access from outside the class.
    /// <summary>
    /// Calculates HR from Rub
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>double HR</returns>
    public double GetHRfromRub(double amountRub)
    {
        return amountRub * _exchRateHRtoRub;
    }

    // Declaration of the custom GetRubfromHR() method of the class object
    // open for access from outside the class.
    /// <summary>
    /// Calculates Rub from HR
    /// </summary>
    /// <param name="amountUSD"></param>
    /// <returns>double Rub</returns>
    public double GetRubfromHR(double amountHr)
    {
        return amountHr / _exchRateHRtoRub;
    }
}

