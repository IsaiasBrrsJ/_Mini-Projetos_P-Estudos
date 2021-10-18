using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaEstaticaDesordenada1._0
{
    class Program
    {
        #region Struct e Enum
        enum Menu { Cadastrar = 1, Remover, Listar, Consultar, Atualizar, Sair}

        struct Aluno
        {

            public string nome;
            public int matricula;
            public float media;
        }

        const int qtdMaxima = 2;
        static Aluno[] cadastroDeAluno = new Aluno[qtdMaxima];
        static int contadorDe_AlunoCadastrado = 0;

        #endregion

        static void Main(string[] args)
        {
            #region Programa Principal
            while (true)
            {
                Console.Clear();

                Linha();
                Console.Write("\n\t      ESCOLA-ASAS-DO-SABER\n");
                Linha();
                Console.WriteLine(" ");

                Console.WriteLine("\n1- Cadastrar\n2- Remover\n3- Listar\n4- Consultar\n5- Atualizar\n6- Sair");
                Console.Write("\nSelecione uma opção: ");
                int opc = int.Parse(Console.ReadLine());

                Menu opcaSelecionada = (Menu)opc;

                if (opc > 0 && opc < 7)
                {
                    switch (opcaSelecionada)
                    {
                        case Menu.Cadastrar:

                            AdcionarAluno();
                            break;
                        case Menu.Remover:

                            RemoverALuno();
                            break;

                        case Menu.Listar:


                            ListarAlunos();
                            break;
                        case Menu.Consultar:

                            ConsultarAluno();
                            break;
                        case Menu.Atualizar:

                            AtualizarAluno();
                            break;
                        case Menu.Sair:
                            return;
                    }
                }
                if(opc != 1 && opc != 5)
                 Console.ReadKey();
              
            }
            #endregion
        }

        #region Linhas
        static void Linha()
        {
            int i = 0;
            for(i = 0; i < 50; i++)
            {
                if (i == 0)
                    Console.Write("+");

                Console.Write("-");

                if (i == 49)
                    Console.Write("+");

            }
        }
        #endregion

        #region Mostrar Aluno
        static void Mostrar(int i)
        {
            Console.Clear();
            Linha();
            Console.Write("\n\t        EXIBINDO ALUNO\n");
            Linha();
            Console.WriteLine("\n\n");

            Console.WriteLine("NOME\t        MATRICULA\t    MÉDIA");
            Console.WriteLine("+-------------------------------------------+");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" {cadastroDeAluno[i].nome}\t\t   {cadastroDeAluno[i].matricula}\t\t      {cadastroDeAluno[i].media}");
            Console.ResetColor();
            Console.WriteLine("+-------------------------------------------+");

           
        }
        #endregion

        #region Procurar Aluno

        static int ProcurarAluno(int i)
        {
            int achou = -1;

            for (int procurando = 0; procurando < qtdMaxima; procurando++)
            {
                if(i == cadastroDeAluno[procurando].matricula)
                {
                     achou = procurando;
                }
            }

            if(achou != -1)
                return achou;

            return -1;
        }
        #endregion

        #region Adcionar Aluno
        static void AdcionarAluno()
        {
            Console.Clear();
            Linha();
            Console.Write("\n\t        ADCIONANDO ALUNO\n");
            Linha();
            Console.WriteLine("\n\n");

            int cad_aluno = contadorDe_AlunoCadastrado;

            if (contadorDe_AlunoCadastrado < qtdMaxima)
            {
                if (contadorDe_AlunoCadastrado == 0)
                {
                    ++contadorDe_AlunoCadastrado;
                }

                for (int i = cad_aluno; i < qtdMaxima; i++)
                {

                    Console.Write("\nNome: ");
                    cadastroDeAluno[i].nome = Console.ReadLine();

                    Console.Write("\nMatricula: ");
                    cadastroDeAluno[i].matricula = int.Parse(Console.ReadLine());

                    Console.Write("\nMédia: ");
                    cadastroDeAluno[i].media = float.Parse(Console.ReadLine().Replace(".", ","));

                    Console.Write("\n\nDeseja Adcionar Mais Alunos (1-Sim / 2-Nâo)? ");
                    int adcionarMaisAlunos = int.Parse(Console.ReadLine());


                    if (adcionarMaisAlunos == 1 && contadorDe_AlunoCadastrado < qtdMaxima)
                    {
                        contadorDe_AlunoCadastrado++;
                    }
                    else
                        break;
                }
               
            }

            if (contadorDe_AlunoCadastrado >= qtdMaxima) 
            { 
                Console.Write("\n\nTurma Cheia....");
                Console.ReadKey();
                return;
            }
        }

        #endregion

        #region Consultar Aluno

        static void ConsultarAluno()
        {

            Console.Clear();
            Linha();
            Console.Write("\n\t        CONSULTANDO ALUNO\n");
            Linha();
            Console.WriteLine("\n\n");
            if (contadorDe_AlunoCadastrado == 0)
                Console.WriteLine("\nAINDA NÃO HOUVE CADASTRO DE ALUNO..");
            else
            {

                Console.Write("\nInforme o número de matricula: ");
                int numMat = int.Parse(Console.ReadLine());

                var achou = ProcurarAluno(numMat);

                if (achou != -1)
                    Mostrar(achou);
                else
                {
                    Console.WriteLine("\nALUNO NÃO CADASTRADO, OU NÚMERO DE MATRICULA INCORRETO......");
                    return;
                }
            }
        }
        #endregion

        #region Listar Alunos
        static void ListarAlunos()
        {

            Console.Clear();
            Linha();
            Console.Write("\n\t        LISTANDO ALUNO\n");
            Linha();
            Console.WriteLine("\n\n");

            if (contadorDe_AlunoCadastrado != 0)
            {
               for(int listagem =0; listagem < contadorDe_AlunoCadastrado; listagem++)
                {
                    Console.WriteLine($"\nNome: {cadastroDeAluno[listagem].nome}\nMatricula: {cadastroDeAluno[listagem].matricula}" +
                        $"\nMédia: {cadastroDeAluno[listagem].media}\n========================");
                }
            }
            else
            {
                Console.WriteLine("\nAINDA NÃO HOUVE CADASTRO DE ALUNO..");
                return;
            }
        }

        #endregion

        #region Atualizar Aluno

        static void AtualizarAluno()
        {
            Console.Clear();
            Linha();
            Console.Write("\n\t        ATUALIZANDO ALUNO\n");
            Linha();
            Console.WriteLine("\n\n");


            if (contadorDe_AlunoCadastrado != 0)
            {
                Console.Write("\nInforme o número de matricula: ");
                int numMat = int.Parse(Console.ReadLine());

                var achou = ProcurarAluno(numMat);

                if (achou != -1)
                {
                    Mostrar(achou);

                    Console.Write($"\nCerteza que deseja alterar o: {cadastroDeAluno[achou].nome} ? (1- Sim / 2 - Não): ");
                    int opcSelecionada = int.Parse(Console.ReadLine());

                    if (opcSelecionada == 1)
                    {
                        Console.Write("\nNome: ");
                        cadastroDeAluno[achou].nome = Console.ReadLine();

                        Console.Write("\nMédia: ");
                        cadastroDeAluno[achou].media = float.Parse(Console.ReadLine().Replace(".",","));

                        Console.Clear();

                        Console.WriteLine("\n\nAtualizado Com Sucesso...");

                        Mostrar(achou);

                        Console.ReadKey();

                        Console.Write($"\n\nContinuar Alterando ? (1- Sim / 2 - Não): ");
                         opcSelecionada = int.Parse(Console.ReadLine());

                        if(opcSelecionada == 1)
                        {
                            AtualizarAluno();
                        }
                        else { return; }
                    }
                    else { return; }
                }
            }
            else
            {
                
                Console.WriteLine("\nAINDA NÃO HOUVE CADASTRO DE ALUNO..");
                Console.ReadKey();
                return;
            }
            
        }
        #endregion

        #region Remover Aluno

        static void RemoverALuno()
        {
            Console.Clear();
            Linha();
            Console.Write("\n\t        REMOVENDO ALUNO\n");
            Linha();
            Console.WriteLine("\n\n");

            if (contadorDe_AlunoCadastrado != 0)
            {
                Console.Write("\nInforme número da matricula: ");
                int numMat = int.Parse(Console.ReadLine());

                var achou = ProcurarAluno(numMat);

                if(achou != -1)
                {
                    Console.Clear();
                     Mostrar(achou);

                    Console.Write($"\n\nCerteza Que Deseja Remover o {cadastroDeAluno[achou].nome} ? (1-Sim / 2- Não): ");
                    int opcRemover = int.Parse(Console.ReadLine());

                    if (opcRemover == 1)
                    {
                        cadastroDeAluno[achou] = cadastroDeAluno[contadorDe_AlunoCadastrado];
                        contadorDe_AlunoCadastrado--;

                        Console.Write("\n\nREMOVIDO COM SUCESSO....");

                        if (contadorDe_AlunoCadastrado != 0)
                        {
                            Console.Write($"\n\nContinuar Removendo? (1-Sim / 2- Não): ");
                            opcRemover = int.Parse(Console.ReadLine());
                        }

                        if (opcRemover == 1 && contadorDe_AlunoCadastrado != 0)
                        {
                            RemoverALuno();


                            return;
                        }
                        else
                            return;

                    }
                    else 
                        return;
                }
            }
            else
            {
                Console.WriteLine("\nAINDA NÃO HOUVE CADASTRO DE ALUNO..");
;                return;
            }
        }

        #endregion
    }
}
