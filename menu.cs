using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Escolha uma opção:");
    Console.WriteLine ("1. Bora");
    Console.WriteLine ("2. Bill");
    Console.WriteLine ("3. Receba");
    Console.WriteLine ("4. Sair");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao) {
      case 1:
        Console.WriteLine ("Você escolheu Bora");
        break;
      case 2:
        Console.WriteLine ("Você escolheu Bill");
        break;
      case 3:
        Console.WriteLine ("Você escolheu Receba");
        break;
      case 4:
        Console.WriteLine ("Saindo do programa...");
        break;
      default:
        Console.WriteLine ("Opção inválida!");
        break;
    }
  }
}