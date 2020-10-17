using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves
{
    class Combustivel
    {
        public static void Executar()
        {
            Console.WriteLine("Qual combustivel deseja colocar ? ");
            Console.WriteLine("Digite 4 para sair!");
            var opcao = int.Parse(Console.ReadLine());
            var alcool = 0;
            var gasolina = 0;
            var diesel = 0;
            while (opcao != 4)
            {
                Console.Write("Digite Novamente : ");
                opcao = int.Parse(Console.ReadLine());
                if ( opcao == 1)
                {
                    alcool =  opcao;
                }else if( opcao == 2)
                {
                    gasolina =  opcao;
                }else if(opcao == 3)
                {
                    diesel =  opcao;
                }
               
                Console.WriteLine("Digite 4 para sair !");

            }
            Console.WriteLine("Muito Obrigado !");
            Console.WriteLine($"Alcool : {alcool}\nGasolina {gasolina}\nDiesel {diesel}");
        }
    }
}
