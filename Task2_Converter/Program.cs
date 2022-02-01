namespace Task2_Converter
{
    class Program
    {
        static void Main()
        {
            #region Задание 2
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // Требуется: 
            // Создать класс Converter. 
            // В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
            // и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
            // Converter(double usd, double eur, double rub). 
            // Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
            // также программа должна производить конвертацию из указанных валют в гривну.
            #endregion

            #region Converter - Encapsulation 

            // Instance the Converter class
            // with the transfer of actual parameters 26.5m, 30.5m, 0.45m into the constructor.
            // Get a link to the address of the converter instance on the heap.
             
            Converter myConverter = new (usd:26.5m, euro:30.5m, rub:0.45m);

            // Display the results of the Converter class methods
            // from an object of class Converter through a link
            // which contains the converter instance of the Converter class.

            myConverter.Exchange(amount:1319, fromValue:"HR", toValue:"USD");

            // Delay
            Console.ReadLine();

            #endregion
        }
    }
}

