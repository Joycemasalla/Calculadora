// See https://aka.ms/new-console-template for more information

double valorA;
double valorB;


Console.WriteLine("Insira dois valores: ");
Console.Write("Valor A: ");
valorA = Convert.ToInt32(Console.ReadLine());

Console.Write("Valor B: ");
valorB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escolha uma operação matemática: \n");
Console.WriteLine("1. Adição ");
Console.WriteLine("2. Subtração ");
Console.WriteLine("3. Multiplicação ");
Console.WriteLine("4. Divisão ");
Console.WriteLine("-----------------------------");

int OperacaoEscolhida = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------");

double resultadoSoma = valorA + valorB;
double resultadoSubtração = valorA - valorB;
double resultadoMultiplicação = valorA * valorB;
double resultadoDivisão = valorA / valorB;

switch (OperacaoEscolhida)
{
    case 1:
        Console.WriteLine("Resultado da operação de Soma é: " + resultadoSoma);
        break;
    case 2:
        Console.WriteLine("Resultado da operação de Subtração é: " + resultadoSubtração);
        break;
    case 3:
        Console.WriteLine("Resultado da operação de Multiplicação é: " + resultadoMultiplicação);
        break;
    case 4:
        Console.WriteLine("Resultado da operação de Divisão é: " + resultadoDivisão);
        break;
};
