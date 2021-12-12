﻿using System;

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

            // Create an instance of converter of the Converter class
            // with the transfer of actual parameters 26.5m, 30.5m, 0.45m to the constructor.
            // Get a link to the address of the converter instance on the heap.
             
            Converter converter = new Converter(26.5m, 30.5m, 0.45m);

            // Display the results of the Converter class methods
            // from an object of class Converter through a link
            // which contains the converter instance of the Converter class.

            converter.Exchange(1319, "USD", "HR");

            // Delay
            Console.ReadLine();

            #endregion
        }
    }
}

