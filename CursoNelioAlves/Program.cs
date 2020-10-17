using CursoNelioAlves.ConstrutoresTHIS;
using CursoNelioAlves.Parte_7;
using CursoNelioAlves.Parte_7._1;
using System;

namespace CursoNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("Opção 1 : Exercício 1");
            Console.WriteLine("Opção 2 : Exemplo de Casting");
            Console.WriteLine("Opção 3 : Equação de Segundo Grau");
            Console.WriteLine("Opção 4 : Exemplo de Vetor");
            Console.WriteLine("Opção 5 : Hora Atual");
            Console.WriteLine("Opção 6 : Número positivo ou negativo");
            Console.WriteLine("Opção 7 : Número par ou ímpar");
            Console.WriteLine("Opção 8 : Multiplos ou não");
            Console.WriteLine("Opção 9 : Duração do Jogo");
            Console.WriteLine("Opção 10 : Cardápio da lancheria");
            Console.WriteLine("Opção 11 : Cardápio da lancheria");
            Console.WriteLine("Opção 12 : Quadrante");
            Console.WriteLine("Opção 13 : Maior entre 3");
            Console.WriteLine("Opção 14 : Raiz Quadrada com While");
            Console.WriteLine("Opção 15 : Senha");
            Console.WriteLine("Opção 16 : Coordenadas");
            Console.WriteLine("Opção 17 : Combustível");
            Console.WriteLine("Opção 18 : Soma com For");
            Console.WriteLine("Opção 19 : Impares entre X");
            Console.WriteLine("Opção 20 : Dentro ou Fora");
            Console.WriteLine("Opção 22 : Divisão Exata");
            Console.WriteLine("Opção 23 : Fatorial ");
            Console.WriteLine("Opção 24 : Divisores  ");
            Console.WriteLine("Opção 25 : Mais Velho  ");
            Console.WriteLine("Opção 26 : Maior Salário ");
            Console.WriteLine("Opção 27 : Produtos   ");
            Console.WriteLine("Opção 28 : Challenger ");
            Console.WriteLine("Opção 29 : Calcular Salário ");
            Console.WriteLine("Opção 30 : Aluno ");
            Console.WriteLine("Opção 31 : Convertendo Moeda ");
            Console.WriteLine("Opção 32 : Com Construtores ");
            Console.WriteLine("Opção 33 : Challenger    ");
            Console.WriteLine("Opção 34 : Vetor ");
            Console.WriteLine("Opção 35 : Vetor Classe   ");
            Console.WriteLine("Opção 36 : Vetor Challenger ");
            Console.WriteLine("Opção 38: Challneger Lista");
            Console.WriteLine("Opção 39: Challenger  Matriz");

            Console.WriteLine("\nOpção 100 : Sair");

            Console.Write("Digite a opão Desejada : ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1) Exercicio1.Executar();
            if (opcao == 2) ExemploCasting.Executar();
            if (opcao == 3) EquacaoSegundoGrau.Executar();
            if (opcao == 4) Vetor.Executar();
            if (opcao == 5) HoraAtual.Executar();
            if (opcao == 6) NegativoOuPositivo.Executar();
            if (opcao == 7) NumeroPar.Executar();
            if (opcao == 8) Multiplos.Executar();
            if (opcao == 9) Duracao.Executar();
            if (opcao == 10) Cardapio.Executar();
            if (opcao == 11) QualIntervalo.Executar();
            if (opcao == 12) Quadrante.Executar();
            if (opcao == 13) MaiorEntre.Executar();
            if (opcao == 14) RaizQuadradaEterno.Executar();
            if (opcao == 15) Senha.Executar();
            if (opcao == 16) Coordenadas.Executar();
            if (opcao == 17) Combustivel.Executar();
            if (opcao == 18) SomaFor.Executar();
            if (opcao == 19) ImparesEntreX.Executar();
            if (opcao == 20) DentroFora.Executar();
            if (opcao == 21) MediaPonderada.Executar();
            if (opcao == 22) DivisaoExata.Executar();
            if (opcao == 23) Fatorial.Executar();
            if (opcao == 24) Divisores.Executar();
            if (opcao == 25) MaisVelho.Executar();
            if (opcao == 26) MaiorSalario.Executar();
            if (opcao == 27) Produtos.Executar();
            if (opcao == 28) Challenger.Executar();
            if (opcao == 29) CalculandoSalario.Executar();
            if (opcao == 30) Aluno.Executar();
            if (opcao == 31) ConversorMoeda.Executar();
            if (opcao == 32) ProdutoConstrutor.Executar();
            if (opcao == 33) AbrirConta.Executar();
            if (opcao == 34) VetorStruct.Executar();
            if (opcao == 35) VetorClass.Executar();
            if (opcao == 36) ChallengerVetor.Executar();
            if (opcao == 37) ModificadorRef.Executar();
            if (opcao == 38) ChallengerLista.Executar();
            if (opcao == 39) ChallengerMatriz.Executar();
            if (opcao == 40) SwitchCase.Executar();
            if (opcao == 41) StringFunc.Executar();
            if (opcao == 42) DateTimeSimples.Executar();
            if (opcao == 43) TimeSpanSimples.Executar();
            if (opcao == 44) ExercicioDateTime.Executar();
            if (opcao == 45) ExercicioTimeSpan.Executar();

        }
    }
}
