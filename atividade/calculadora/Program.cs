using System;

double firstvalue = 0d;
double secondvalue = 0d;
double result = 0d;
int opcao = 0;

// Primeiro valor e conversão para double
Console.WriteLine("--------------- CALCULADORA ---------------");
Console.Write("Para começar, informe o primeiro número: ");
firstvalue = Convert.ToDouble(Console.ReadLine());

// // Setando a variavel que recebe opcao e conversão para int (para utilizar switch)
Console.WriteLine("--------------- CALCULADORA ---------------");
Console.WriteLine("Agora, informe a operação a ser realizada. ");
Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
opcao = Convert.ToInt32(Console.ReadLine());

// Segundo valor e conversão para double
Console.WriteLine("--------------- CALCULADORA ---------------");
Console.Write("Por último, informe o segundo número: ");
secondvalue = Convert.ToDouble(Console.ReadLine());

// Operação no console.
Console.Write($"A operação realizada será {firstvalue}"+(opcao==1 ? " + " : opcao==2? " - ": opcao==3? " x ": " / ")+$"{secondvalue}");
Thread.Sleep(3000);
 
// Operação na variável de resultado
switch(opcao){
    case 1:
        result = firstvalue+secondvalue;
        break;
    case 2:
        result = firstvalue-secondvalue;
        break;
    case 3:
        result = firstvalue*secondvalue;
        break;
    case 4:
        result = firstvalue/secondvalue;
        break;
    default:
        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
        Thread.Sleep(3000);
        break;
}


Console.Write($"O resultado final é: {result}");