#region Задание Дополнительное
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: 
// Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата 
// заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз 
// (при создании экземпляра данного класса) без возможности его дальнейшего изменения. 
// Реализуйте вывод на экран информации о пользователе. 
#endregion

#region User - Encapsulation

User user1 = new User("Admin", "Bill", "Gates", 66);

// Call the Show () method of the User class from the class object through a link
// which contains an instance of user1 of the User class.
user1.Show();

// Create an instance of user2 of the User class
// with passing the actual parameters "User", "Steve", "McConnell", 54 to the constructor
// Get a link to the address of the user2 instance on the heap.
User user2 = new User("User", "Steve", " McConnell", 54);

// Call the Show () method of the User class from the class object through a link
// which contains an instance of user2 of the User class.
user2.Show();

#endregion