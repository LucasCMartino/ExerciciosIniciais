using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    class Params
    {
        public static int Sum(params int[] numeros)//Usado pra passa a qtd q quiser em paramentros pra soma
        {
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sum += numeros[i];
            }
            return sum;
        }

        //Exemplo int resultado = Params.Sum(10,20,30,40 ......);
    }
}
