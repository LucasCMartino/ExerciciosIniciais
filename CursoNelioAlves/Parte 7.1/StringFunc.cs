using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7._1
{
    class StringFunc
    {
        public static void Executar()
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";
            string s1 = original.ToUpper();// Todos maiúsculos
            string s2 = original.ToLower();//Todos minúsculos
            string s3 = original.Trim();//Retira espaços em branco no final ou antes
            int n1 = original.IndexOf("bc");//primeira posição
            int n2 = original.LastIndexOf("bc");//ultimaposição
            string s4 = original.Substring(3);//Começa apartir de um indice
            string s5 = original.Substring(3, 5);//começa apartir de um indice, e percorre quantos forem info
            string s6 = original.Replace('a', 'x');//altera a string 
            string s7 = original.Replace("abc", "xy");//altera conjuntos mesmo q n seja pelo mesmo tamanho
            bool b1 = String.IsNullOrEmpty(original);//verifica se esta nulo ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original);//verifica se tem espaços em branco

            Console.WriteLine("Original : -" + original + "-");
            Console.WriteLine("ToUpper : -" + s1 + "-");
            Console.WriteLine("ToLower : -" + s2 + "-");
            Console.WriteLine("Trim : -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring : " + s4);
            Console.WriteLine("Substring : " + s5);
            Console.WriteLine("Replace('a', 'x') : " + s6);
            Console.WriteLine("Replace('abc', 'xy') : " + s7);
            Console.WriteLine("IsNullOrEmpty : " + b1);
            Console.WriteLine("IsNullOrWhiteSpace : " + b2);
        }
    }
}
