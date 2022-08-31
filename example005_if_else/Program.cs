Console.Write("ВВедите имя пользователя: ");
string username=Console.ReadLine();

if(username.ToLower()=="маша") //ToLower позволяет все буквы первести в нижний регистр, тогда как ни напиши МАша или МАША, будет выдавать правильный ответ
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет,");
    Console.Write(username);
}