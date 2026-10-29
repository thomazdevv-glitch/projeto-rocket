
Console.WriteLine("Bem vindo(a) à mini calcuradora");

Console.Write("Digite o primeiro número: ");

double numero1 = double.Parse(Console.ReadLine()!);

Console.Write("Digite o segundo numero: ");

double numero2 = double.Parse(Console.ReadLine()!);


double soma = numero1 + numero2;
double subtracao  = numero1 - numero2;
double multiplicacao = numero1 *  numero2;
double media = (numero1 + numero2) / 2;


Console.WriteLine($"Soma = {soma}");
Console.WriteLine($"Subtração = {subtracao}");
Console.WriteLine($"Multiplicação = {multiplicacao}");


if (numero2 == 0)
{
   Console.WriteLine("Divisão = Não é possivel dividir por 0.");
   
}
else
{
    double divisao = numero1 / numero2;
    Console.WriteLine($"Divisão = {divisao}");
}

Console.WriteLine($"Media = {media}");