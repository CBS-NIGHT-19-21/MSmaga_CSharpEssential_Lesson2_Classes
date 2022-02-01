namespace Task4_Invoice
{
    class Program
    {
        static void Main()
        {
            #region Задание 4
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // Требуется: 
            // Создать класс Invoice. 
            // В теле класса создать три поля int account, string customer, string provider, которые должны 
            // быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их 
            // дальнейшего изменения. 
            // В теле класса создать два закрытых поля string article, int quantity 
            // Создать метод расчета стоимости заказа с НДС и без НДС. 
            // Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС. 
            #endregion

            #region Invoice - Encapsulation
            // Create an instance of invoice1 of the Invoice class
            // with passing the actual parameters 1131911010, "Tom Henks", "Hortons and Bro" to the constructor.
            // Get a link to the address of the invoice1 instance on the heap.
            Invoice invoice1 = new (1131911010, "Tom Henks", "Hortons and Bro");

            // Create an instance of invoice1 of the Invoice class
            // with passing the actual parameters "Boots", 4 to the constructor
            // Get a link to the address of the invoice1 instance on the heap.
            invoice1.GetTotalCost("Boots", 4);

            // Call the GetVAT () and Show () methods of the Invoice class
            // from a class object through a link
            // which contains an instance of invoice1 of the Invoice class.
            invoice1.GetVAT();

            invoice1.Show();


            // Create an instance of invoice2 of the Invoice class
            // passing the actual parameters 234234234, "Tom Hardy", "Jonson and Jonson" to the constructor
            // Get a link to the address of the invoice2 instance on the heap.
            Invoice invoice2 = new (234234234, "Tom Hardy", "Jonson and Jonson");

            // Create an instance of invoice2 of the Invoice class
            // with passing the actual parameters "Shirt", 13 to the constructor
            // Get a link to the address of the invoice2 instance on the heap.
            invoice2.GetTotalCost("Shirt", 13);

            // Call the GetVAT () and Show () methods of the Invoice class
            // from a class object through a link
            // which contains an instance of invoice2 class Invoice constructor
            // Get a link to the address of the invoice2 instance on the heap.
            invoice2.GetVAT();

            invoice2.Show();

            #endregion
        }
    }
}

