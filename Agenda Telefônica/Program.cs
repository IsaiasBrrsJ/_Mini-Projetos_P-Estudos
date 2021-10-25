using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendinhaTreino
{
    class Program
    {   
        struct Agenda
        {
            public string nome;
            public string endereco;
            public string numTelefone;
        }
        const int qtdMaxima = 3;
        static Agenda[] adcionar = new Agenda[qtdMaxima];
        static int contadorAgenda = 0;

        enum Menu { adcionar =1, procurar, listar, sair}
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Linha();
                Console.Write("\n\t        AGENDA TELEFÔNICA\n");
                Linha();
                Console.WriteLine("\n\n");

           
                Console.Write("\n\t1- Adcionar\n\t2- Procurar\n\t3- Listar\n\t4- Sair\n\n\tOpção: ");
                int opc = int.Parse(Console.ReadLine());

                Menu opcaoSelecionada = (Menu)opc;

                if (opc > 0 && opc < 5)
                {
                    switch (opcaoSelecionada)
                    {
                        case Menu.adcionar:
                            Adcionar();
                            break;
                        case Menu.procurar:
                            ExibirAluno();
                            break;
                        case Menu.listar:
                            Listar();
                            break;
                        case Menu.sair:
                            return;
                    }
                }

            }
        }
        #region Adcionar
        static void Adcionar()
        {
            int cont_Adc = contadorAgenda;

            Console.Clear();
            Linha();
            Console.Write("\n\t        ADCIONANDO ALUNO\n");
            Linha();
            Console.WriteLine("\n\n");

            try
            {
                if (contadorAgenda < qtdMaxima)
                {
                    for (int i = cont_Adc; i < qtdMaxima; i++)
                    {
                        Console.Write("Nome: ");
                        adcionar[i].nome = Console.ReadLine().ToLower();

                        Console.Write("Endereco: ");
                        adcionar[i].endereco = Console.ReadLine();

                        Console.Write("Telefone: ");
                        adcionar[i].numTelefone = Console.ReadLine();

                        Console.Write("\nAdcionar mais (1-SIM / 2-NÃO)? ");
                        int continuar = int.Parse(Console.ReadLine());

                        if (continuar == 1 && contadorAgenda < qtdMaxima)
                        {
                            Console.Clear();
                            ++contadorAgenda;
                        }
                        else
                        {
                            ++contadorAgenda;
                            return;
                        }


                    }
                }
                else
                {
                    Console.Write("\nAgenda Cheia...");
                    Console.ReadKey();
                    return;
                }
            }
            catch
            {
                Console.Write("\nErro, preencha as informações corretamente...");
                Console.ReadKey();
                Console.Clear();
                Adcionar();
            }
        }
        #endregion

        #region procurar
        static int procurar (string nome)
        {
            int posicao = -1;
            for(int i = 0; i < qtdMaxima; i++)
            {
                if(nome == adcionar[i].nome)
                {
                    posicao = i;
                    break;
                }
            }
            return posicao;
        }
        #endregion

        #region exibir
        static void ExibirAluno()
        {
            Console.Clear();
            Linha();
            Console.Write("\n\t        EXIBINDO ALUNO(S)\n");
            Linha();
            Console.WriteLine("\n\n");
            Console.Write("Infome o nome: ");
            var nome = Console.ReadLine().ToLower();

            var receberPosic = procurar(nome);

            if(receberPosic != -1)
            {
                Console.WriteLine($"\nNome: {adcionar[receberPosic].nome}\nEndereço: {adcionar[receberPosic].endereco}\nTelefone: {adcionar[receberPosic].numTelefone}");
            }
            else
                Console.Write("\nNão encontrado ou inexistente");    
            

            Console.ReadKey();
        }
        #endregion

        #region listar
        static void Listar()
        {

            Console.Clear();
            Linha();
            Console.Write("\n\t        LISTANDO ALUNO(S)\n");
            Linha();
            Console.WriteLine("\n\n");

            try
            {
                Console.Write("Informe a primeira letra: ");
                char primeiraLetra = char.Parse(Console.ReadLine().ToLower());

                int achou = -1;
                for (int i = 0; i < contadorAgenda; i++)
                {
                    char nome = adcionar[i].nome[0];
                    if (nome == primeiraLetra)
                    {
                        achou++;
                        Console.WriteLine($"\nNome: {adcionar[i].nome}\nEndereço: {adcionar[i].endereco}\nTelefone: {adcionar[i].numTelefone}");
                    }
                }

                if (achou == -1)
                    Console.Write("\nNão encontrado ou inexistente");

                Console.ReadKey();
            }
            catch
            {
                Console.Write("\nErro, preencha as informações corretamente...");
                Console.ReadKey();
                Console.Clear();
                Listar();
            }
        }
        #endregion

        #region Linhas
        static void Linha()
        {
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                if (i == 0)
                    Console.Write("+");

                Console.Write("-");

                if (i == 49)
                    Console.Write("+");

            }
        }
        #endregion
    }
}
