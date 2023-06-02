string name = "  Julio Cesar Momente   ";
Console.WriteLine($"Olá, [{name}]");
string fName = name.Trim();
System.Console.WriteLine($"Este é seu nome sem espaços: [{fName}]");
System.Console.WriteLine($"Seu nome tem {fName.Length} letras.");
System.Console.WriteLine($"Tudo maiúsculo: {fName.ToUpper()} | tudo minúsculo: {fName.ToLower()}");
System.Console.WriteLine($"Trocando os espaços por traços: {fName.Replace(' ','-')}");