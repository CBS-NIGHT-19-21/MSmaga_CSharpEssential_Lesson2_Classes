#region Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: 
//Создать класс Employee. 
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и 
//инициализирует поля, соответствующие фамилии и имени сотрудника. 
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый 
//сбор. 
//Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), 
//оклад и налоговый сбор.
#endregion

#region Employee - Encapsulation
// Create an instance of aStaff1 of the Employee class
// with passing the actual parameters "John", "Smith" to the constructor.
// Get a reference to the address of aStaff1 instance on the heap.
Employee aStaff1 = new Employee("John", "Smith");

// Call the GetSalary () method of the Employee class with passing
// actual parameters "Worker", 8, from the class object through the link
// which contains an instance of aStaff1 of the Employee class.
aStaff1.GetSalary("Worker", 8);

// Call the GetTaxPayment () and Show () methods of the Employee class
// from a class object through a link
// which contains an instance of aStaff1 of the Employee class.
aStaff1.GetTaxPayment();

aStaff1.Show();

// Create an instance of aStaff2 of the Employee class
// with passing the actual parameters "Tim", "Hortons" to the constructor.
// Get a reference to the address of aStaff2 instance on the heap.
Employee aStaff2 = new Employee("Tim", "Hortons");

// Call the GetSalary () method of the Employee class with passing
// actual parameters "Engineer", 3, from the class object through a reference
// which contains an instance of aStaff2 of the Employee class.
aStaff2.GetSalary("Engineer", 3);

// Call the GetTaxPayment () and Show () methods of the Employee class
// from a class object through a link
// which contains an instance of aStaff2 of the Employee class.
aStaff2.GetTaxPayment();

aStaff2.Show();

// Create an instance of aStaff3 of the Employee class
// with passing the actual parameters "James", "Hetfield" to the constructor
// Get a reference to the address of aStaff3 instance on the heap.
Employee aStaff3 = new Employee("James", "Hetfield");

// Call the GetSalary () method of the Employee class with passing
// actual parameters "Head", 5, from the class object via a link
// which contains an instance of aStaff3 of the Employee class.
aStaff3.GetSalary("Head", 5);

// Call the GetTaxPayment () and Show () methods of the Employee class
// from a class object through a link
// which contains an instance of aStaff3 of the Employee class.
aStaff3.GetTaxPayment();

aStaff3.Show();

// Create an instance of aStaff4 of the Employee class
// with passing the actual parameters "Jim", "Carry" to the constructor
// Get a reference to the address of aStaff4 instance on the heap.
Employee aStaff4 = new Employee("Jim", "Carry");

// Call the GetSalary () method of the Employee class with passing
// actual parameters "Director", 1, from the class object through a link
// which contains an instance of aStaff4 of the Employee class.
aStaff4.GetSalary("Director", 1);

// Call the GetTaxPayment () and Show () methods of the Employee class
// from a class object through a link
// which contains an instance of aStaff4 of the Employee class.
aStaff4.GetTaxPayment();

aStaff4.Show();

#endregion
