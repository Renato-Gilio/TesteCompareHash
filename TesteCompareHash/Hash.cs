using System;
using System.Security.Cryptography;
using System.Text;

namespace TesteCompareHash
{
    public class Hash
    {
        public static string HashDeSenha(string senha, HashAlgorithm algoritmo)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        public static bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Cadastre uma senha.");

            return senhaCadastrada == senhaDigitada ? true : false;
        }
    }

}

