using LoginPageDBoevning;

//var uM = new UserManager();
//loggar in användaren, testar om det fungerade då jag skapade 2st användare genom sql tidigare.
//Console.WriteLine("Ange ditt användarnamn: ");
//string userName = Console.ReadLine();

//Console.WriteLine("Ange ditt lösenord: ");
//string password = Console.ReadLine();

//using (var context = new AppDbContext())
//{
//    var user = context.Users.FirstOrDefault(u => u.Username == userName && u.PasswordHash == password);

//    if (user != null)
//    {
//        Console.WriteLine($"Du loggades in, välkommen {userName}");
//    }
//    else
//    {
//        Console.WriteLine("Du har angivit fel uppgifter.");
//    }
//}


//lägga till användare till databasen

Console.WriteLine("Välj ditt username: ");
string userInput = Console.ReadLine();

Console.WriteLine("Välj ditt lösenord: ");  //Testa o Hasha detta senare
string pwInput = Console.ReadLine();
//uM.CreateUserAcc(userInput, pwInput);