using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class Senha
    {
        public static void Executar()
        {
            Console.Write("Digite a Senha : ");
            var senha = int.Parse(Console.ReadLine());
            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida, Digite novamente : ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido !");
        }
    }
}
