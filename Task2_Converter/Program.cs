using System;

namespace Task2_Converter
{
    class Program
    {
        static void Main(string[] args)
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

            // Create an instance of converter1 of the Converter class
            // with the transfer of actual parameters 26.5, 30.5, 0.45 to the constructor.
            // Get a link to the address of the converter1 instance on the heap.
            
            Converter converter1 = new Converter(26.5, 30.5, 0.45);

            // Display the results of the Converter class methods
            // from an object of class Converter through a link
            // which contains the converter1 instance of the Converter class.
            Console.WriteLine("USD  = {0:F2}", converter1.GetHRfromUSD(133));
            Console.WriteLine("Euro = {0:F2}", converter1.GetHRfromEuro(133));
            Console.WriteLine("Rub  = {0:F2}", converter1.GetHRfromRub(133));
            Console.WriteLine(new String('=', 15));

            Console.WriteLine("USD  = {0:F2}", converter1.GetUSDfromHR(193));
            Console.WriteLine("Euro = {0:F2}", converter1.GetEurofromHR(193));
            Console.WriteLine("Rub  = {0:F2}", converter1.GetRubfromHR(193));
            Console.WriteLine(new String('=', 15));

            #endregion
        }
    }
}

