using System;
using System.Collections.Generic;

namespace projeto
{

    public class Ficha
    {

        public string nome;
        public int idade;
        public double altura;

        public void escrever()
        {
            Console.WriteLine("Ola, " + nome + " voce tem " + idade + " anos e " + altura + "cm de altura!");
        }

    }



    class projeto
    {
        static void main (string[] args)
        {


            Ficha professor = new Ficha();

            professor.nome = Console.ReadLine();
            professor.idade = Convert.ToInt32(Console.ReadLine());
            professor.altura = Convert.ToDouble(Console.ReadLine());
            professor.escrever();





            Ficha aluno = new Ficha();

            aluno.nome = "Jose Carlos";
            aluno.idade = 65;
            aluno.altura = 2.15D;
            aluno.escrever();

            Console.ReadLine();

        }
    }





}
