using CursoNelioAlves.ConstrutoresTHIS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    class ModificadorRef
    {
        public static void Executar()
        {
            double a = 10;
            AuxiliarConstrutor.Calculadora(ref a); //no parametro e na variavel, tornando o parametro referencia 
            Console.WriteLine(a);                 // para a variavel <<<<<<
        }
    }
}
