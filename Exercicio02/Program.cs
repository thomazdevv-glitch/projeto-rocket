using System.Runtime.CompilerServices;

Console.Write("Olá! Digite seu PRIMEIRO nome: ");

string primeiroNome = Console.ReadLine();

Console.Write("Agora digite seu sobrenome: ");

string segundoNome = Console.ReadLine();

string nomecompleto = primeiroNome + " " + segundoNome;

Console.Write($"Seu nome completo é: {nomecompleto}");
