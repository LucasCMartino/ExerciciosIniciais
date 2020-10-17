using System;
using System.Collections.Generic;
using System.Text;

namespace CursoNelioAlves.Parte_7
{
    class Listas
    {
        public static void Executar()
        {
            List<string> list = new List<string>(); //Instanciando a Lista  
            list.Add("Maria"); //Adicionando em ordem normal
            list.Add("Jose");
            list.Add("Mateus");
            list.Add("Anna");
            list.Add("Stefanie");
            list.Insert(2, "Darn");       //Usando Insert, tu pode determina a posição q vai entra o item
            foreach (string nome in list)
            {
                Console.WriteLine(nome);//Lendo os itens da Lista
            }
            Console.WriteLine("Nomes na lista : " + list.Count);        //Count pra ver tamanho
            string first = list.Find(x => x[0] == 'M'); // encontra primeiro predicado satisfeito   
            Console.WriteLine("primeiro com letra M " + first);

            string last = list.FindLast(x => x[0] == 'M'); //encontra o ultimo predicado satisfeito
            Console.WriteLine("ultimo com letra M " + last);

            int pos1 = list.FindIndex(x => x[0] == 'M'); //Encontra a posição do predicado definido
            Console.WriteLine("Primeira posição com letra M " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'M');//ultima posição do predicado definido
            Console.WriteLine("Ultima posição com letra M " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 4); // Listando aqueles q atendem o predicado
            foreach (string nome in list2)
            {
                Console.WriteLine(nome);
            }

            //list.Remove(); Serve pra remover normal
            //list.RemoveAt(2) remove na posição declarada
            //list.RemoveRange(2 , 2) passa apartir de quando remover, depois quantos remover
            //list.RemoveAll( x => x[0] == 'M' Remove todos com algum predicado desde q o mesmo seja satisfeito
        }
    }
}
