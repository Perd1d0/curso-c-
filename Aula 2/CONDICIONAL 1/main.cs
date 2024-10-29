using System;

class Program
{
    public static void Main(string[] args)
    {
        const double precoTotal = 20.00;
        double precoFinal = 0;
        //Informando a idade do cliente
        Console.WriteLine("Por favor digite sua idade;: ");
        int idade = int.Parse(Console.ReadLine());

        //Condições de descontos
        if (idade < 5)
        {
            precoFinal = 0;
        }
        else if (idade >= 5 && idade <= 12)
        {
            precoFinal = precoTotal * 0.5;
        } else if (idade >= 13 && idade <= 60){
            precoFinal = precoTotal;
        } else if (idade > 60) {
            precoFinal = precoTotal * 0.7;
        }
        Console.WriteLine($"O valor do ingresso é: {precoFinal:F2}");
    }
}