using System;

namespace SenhaFixaURI1114
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer a leitura de uma senha, caso ela seja diferente de 2002
            //Exibir a mensagem: Senha Invalida. Caso a senha estiver correta: acesso permitido
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}
