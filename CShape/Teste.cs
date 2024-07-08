using System;

namespace Calculadora
{
    class Calculadora
    {
        int num1, num2, op;
        public int Somar (){
            return num1 + num2;
        }
        public int Substrair (){
            return num1 - num2;
        }
        public int Dividir(){
            return num1 / num2;
        }
        public int Multiplicar(){
            return num1 * num2;
        }

        static void Main(string[] args)
        {
        int num1, num2, op;

            Console.WriteLine(" ==============CALCULADORA===========\n");
            Console.WriteLine("Primeiro valor (valores inteiros):");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSegundo valor (valores inteiros) : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual operação deseja fazer? ");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtracao");
            Console.WriteLine("3. Divisao");
            Console.WriteLine("4. Multiplicacao");

            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("A soma de " + num1 + " + " + num2 + "e igual a" + (num1 + num2));
            }
            else if (op == 2)
            {
                Console.WriteLine("A soma de " + num1 + " + " + num2 + "e igual a" + (num1 - num2));
            }
            else if (op == 3)
            {
                Console.WriteLine("A soma de " + num1 + " + " + num2 + "e igual a" + (num1 / num2));
            }
            else if (op == 4)
            {
                Console.WriteLine("A soma de " + num1 + " + " + num2 + "e igual a" + (num1 * num2));

                Console.ReadLine();
            }
        }
    }
}
