Console.Write("Введите имя ползователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "антон")
{
  Console.Write("Ура, это же АНТОН!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}