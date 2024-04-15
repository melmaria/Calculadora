using System;

class Program
{
    static void Main()
    {
        double num1, num2, resultado; char operator;

        Console.WriteLine("Digite o primeiro número:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o operador(+,-,*,/):");
        operador = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operador)
        {
            case '+': resultado = num1 + num2;
           
            ConsoleWriteLine("Resultado:" + resultado);
            break;

            case '-': resultado = num1 - num2;

            Console.WriteLine("Resultado:" + resultado);

            break;

            case '*': resultado = num1 * num2;

            Console.WriteLine("Resultado:" + resultado);

            break;

            case '/': if (num2 != 0) 
            {
                resultado = num1 / num2;
                Console.WriteLine("Resultado:" + resultado);
            }

            else 
            {
                Console.WriteLine("Não é possível dividir por zero!");
            
            break;
            
            default: Console.WriteLine("Operador inválido!");

            break;
            }
            
            Console.ReadLine();
        }
    }
            
    
}