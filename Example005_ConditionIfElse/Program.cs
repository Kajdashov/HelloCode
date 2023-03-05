Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "владимир"){

    Console.WriteLine("Ура, это же Вова!!!");

}
    else{

        Console.Write("Привет, ");
        Console.WriteLine(username);

    }
