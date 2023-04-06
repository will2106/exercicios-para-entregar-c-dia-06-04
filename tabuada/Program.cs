Console.WriteLine(@"

 ----------------------------
|                            |
|      -Programa Tabuada-    |
|                            |
 ----------------------------

");




// vamos usar o comando de repeticao For para fazer uma tabuada  a partir do valor digitado pelo usuario!


Console.WriteLine("Olá seja bem vindo por favor digite um numero! ");

//entrada do numero que deseja saber sua tabuada

int numero=int.Parse(Console.ReadLine());
Console.WriteLine($"voce digitou o numero {numero}!");
Console.WriteLine($"Veja como é a tabuada do {numero}!");

//Processamento dos valores de entrada

for (int i = 0; i <11; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
    
}
