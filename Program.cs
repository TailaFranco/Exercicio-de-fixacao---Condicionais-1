using System;

namespace Exercício_1___Votar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ler o ano atual e o ano de nascimento de uma pessoa. 
            //Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
            int nascimento;
            int ano_atual;
            int idade;
            Console.WriteLine("Digite o seu ano de nascimento:");
            nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual:");
            ano_atual = int.Parse(Console.ReadLine());
            idade = ano_atual - nascimento;
            if(idade>=16)
            {
                Console.WriteLine("Você poderá votar este ano.");
                if(idade >= 18 && idade <=70)
                {
                    Console.WriteLine("Não se esqueça, pela sua idade você é obrigado a votar!\n Se não puder comparecer, lembre-se de justificar.");
                }
                else
                {
                    Console.WriteLine("Pela sua idade você não é obrigado a votar, contudo exerça sua cidadania, vote!!!");
                }
            }
            else{
                Console.WriteLine("Você NÃO poderá votar este ano, aguarde até completar a idade apropriada.");
            }
        }
    }
}
