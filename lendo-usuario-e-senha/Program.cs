


Console.WriteLine(@"

 ------------------------------------------------
|                                                |
|     Programa de entrada de usuario e senha!!!  |
 ------------------------------------------------

");


Console.WriteLine($"digite seu usuario:");
string usuario = Console.ReadLine();


Console.WriteLine($"digite sua senha:");
string senha = Console.ReadLine();


while (usuario == senha )
{
    Console.WriteLine($"usuario e senha nao podem ser iguais!");
    senha=Console.ReadLine();
    
}

Console.WriteLine($"Seja bem vindo {usuario}!!!");

