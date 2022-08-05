Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "мак")
{
    Console.WriteLine("Аве, цезарь МАК!!! Какая встреча!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}