using System;
using EX1;

Cotacao cotacao = new Cotacao();

Console.WriteLine("Digite a cotação atual do dólar em reais:");

double atual = double.Parse(Console.ReadLine());

cotacao.SetAtual(atual);

Console.WriteLine("Digite o valor em dólares a ser convertido:");

double dolares = double.Parse(Console.ReadLine());

Console.WriteLine("O valor em reais é: " + cotacao.Calcular(dolares));