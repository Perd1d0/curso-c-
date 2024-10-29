using System;

class Program {
  public static void Main (string[] args) {
    //Solicitando a nota que tirou
    Console.WriteLine("Insira sua nota (0 a 100): ");
    int nota = int.Parse(Console.ReadLine());

    //Verificando se a nota é válida
    if(nota >= 0 && nota <= 100){
      //Verificando se a nota é azul
      if(nota >= 60){
        Console.WriteLine("Parabéns, você está ótimo !!!");
      } else {
        Console.WriteLine("Estude mais, melhore sua nota !!!");
      } 
    } else {
      Console.WriteLine("Nota inválida, Insira outra nota !!!");
    }
  } 
}