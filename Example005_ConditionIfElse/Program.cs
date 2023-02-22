Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username == "Гриша")
{
    Console.WriteLine("Ух, ето кто? Гриша?");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}