using System;
using System.Security.Cryptography;


namespace TesteCompareHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string digSenha = "Paralelpipedode";
            Console.Write("Digite sua senha: ");
            string senhaD   = Console.ReadLine();
   
            Console.WriteLine($"Senha: {digSenha}");
            string senhaEncr = Hash.HashDeSenha(digSenha, MD5.Create());

            //Validação
            bool val = Hash.VerificarSenha(Hash.HashDeSenha(senhaD, MD5.Create()), senhaEncr);
            string check = val ? "correta" : "errada";
            Console.WriteLine($"Validação: {check}");

            Console.WriteLine($"Hash1: {senhaEncr}");
            Console.WriteLine($"Hash2: {Hash.HashDeSenha(senhaD, MD5.Create())}");
            Console.ReadKey();
        }
    }
}
