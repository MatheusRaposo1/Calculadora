using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            Console.Write("Digite o primeiro número ");
            double num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número ");
            double num2 = int.Parse(Console.ReadLine());

            Console.Write("Escolha as operacoes (+ - X /):");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro , operacao inválida");
                    break;
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O reulstado da soma é: " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O reulstado da subtracao é: " + resultado);
                    break;
                case 'x':
                case 'X':
                    resultado = num1 * num2;
                    Console.WriteLine("O reulstado da multiplicacao é: " + resultado);
                    break;
                case '/':
                case ':':
                    if(num2 == 0) {
                        Console.WriteLine("Não é possível dividir por 0.");
                    }
                    else
                    {
                    resultado = num1 / num2;
                    Console.WriteLine("O reulstado da divisao é: " + resultado);

                    }
                    break;
            }
            Console.Write("Continuar calculando (s / n)? ");
            string opcao = Console.ReadLine();
            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }
            Console.ReadKey();
        }
    }
}
