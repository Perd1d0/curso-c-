using System;

class Program {
  public static void Main (string[] args) {
    Random random = new Random();
    int numSecreto = random.Next(0, 101);
    int tentativas = 0;
    bool acertou = false;

    //Iniciando o jogo
    Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
    
    //Enquanto o usuario não acertar
    while(!acertou){
      Console.WriteLine("Digite um número entre 0 e 100: ");
      string input = Console.ReadLine();

    //Verificando se o input é um número
    if(int.TryParse(input, out tentativas)){
        if(tentativas < 0 || tentativas > 100){
          Console.WriteLine("Digite um número entre 0 e 100 !!!");
        } else if(tentativas < numSecreto){
          Console.WriteLine("O número secreto é maior !!!");
        } else if(tentativas > numSecreto){
          Console.WriteLine("O número secreto é menor !!!");
        } else {
          Console.WriteLine("Parabéns, você acertou o número secreto !!!");
          acertou = true;
        }
      } else {
        Console.WriteLine("Entrada inválida !!! Digite outro número !!!");
      }    
    }
  }
}