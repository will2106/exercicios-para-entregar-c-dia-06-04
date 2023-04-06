
Console.WriteLine (@"

----------------------------
|          Programa        |
|     -Digite um numero-   |
|         de 0 a 10        |
|                          |
|                          |
----------------------------

Text");





Console.WriteLine($"Digite um numero de 0 a 10, apos digitar o numero aperte a tecla enter: ");
int numero= int.Parse(Console.ReadLine());

if (numero<10)
{

   Console.WriteLine($"voce digitou o numero {numero}!");
    

}
else
{
    Console.WriteLine($"voce digitou o numero {numero}, ele nao corresponde ao que foi solicitado! ");
    
}



while (numero > 10 )
{
    
Console.WriteLine($"Por favor ,digite um numero válido!");
numero= int.Parse(Console.ReadLine());


}

