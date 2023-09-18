Console.Write("Type usermane: ");
string username = Console.ReadLine();

if (username.ToLower() == "user")
{
    Console.WriteLine("Yuppi, that's you!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}