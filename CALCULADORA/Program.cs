using System;


namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool sair = false;

            while(!sair)
            {
                Console.WriteLine("\tSeja Bem Vindo Ao CALC ");
                Console.WriteLine("\n\t1- Soma\n\t2- Subtração\n\t3- Divisão\n\t4- Multiplicaão\n\t5- Potência\n\t6- Raiz\n\t7- Sair");
                Console.Write("\nSelecione uma das opções: ");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                Console.Write("\nVocê Escolheu: "+ opcao + "\n");

                switch (opcao) 
                {
                    case Menu.Sair:
                        sair = true;
                        break;

                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Muliplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    default:
                        Console.Write("\nOpcao incorreta...");
                        Console.WriteLine("\nAperte Enter Para Votar Para O Menu");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
                 
            }
        }
        static void Soma()
        {
            double[] somar = new double[2];
            string[] sum = new string[2];

            for (int i =0; i < somar.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° Número: ");
                 sum[i] = Console.ReadLine().Replace(".", ",");

                somar[i] = Convert.ToDouble(sum[i]);

            }
            Console.Write($"\n {somar[0]} + {somar[1]} = {somar[0] + somar[1]}\n");
            Console.WriteLine("\nAperte Enter Para Votar Para O Menu");
            Console.ReadKey();
        }
        static void Subtracao()
        {
            double[] subtrair = new double[2];
            string[] sub = new string[2];

            for (int i = 0; i < subtrair.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° Número: ");
                sub[i] = Console.ReadLine().Replace(".", ",");

                subtrair[i] = Convert.ToDouble(sub[i]);
            }
            Console.Write($"\n {subtrair[0]} - {subtrair[1]} = {subtrair[0] - subtrair[1]}\n");
            Console.WriteLine("\nAperte Enter Para Votar Para O Menu");
            Console.ReadKey();

        }
        static void Divisao()
        {
            double[] divisao = new double[2];
            string[] div = new string[2];

            for (int i = 0; i < div.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° Número: ");
                 div[i] = Console.ReadLine().Replace(".", ",");

                divisao[i] = Convert.ToDouble(div[i]);

            }

            Console.Write($"\n {divisao[0]} / {divisao[1]} = {divisao[0] / divisao[1]}\n");
            Console.WriteLine("\nAperte Enter Para Votar Para O Menu");
            Console.ReadKey();

        }
        static void Muliplicacao()
        {
            double[] multiplicacao = new double[2];
            string[] mult = new string[2];

            for (int i = 0; i < mult.Length; i++)
            {
                Console.Write($"Digite o {i + 1}° Número: ");
                mult[i] = Console.ReadLine().Replace(".", ",");

                multiplicacao[i] = Convert.ToDouble(mult[i]);

            }
            Console.Write($"\n { multiplicacao[0]} * { multiplicacao[1]} = { multiplicacao[0] * multiplicacao[1]}\n");
            Console.WriteLine("\nAperte Enter Para Votar Para O Menu");
            Console.ReadKey();

        }
        static void Potencia()
        {
            Console.Write("Informe a Base: ");
             int base_Pot = int.Parse(Console.ReadLine());

            Console.Write("Informe o Expoente: ");
             int expoente = int.Parse(Console.ReadLine());

            int potencia = 1;
            for(int i = 1; i <= expoente; i++)
            {
                potencia *= base_Pot;


            }
            Console.Write($"\n{base_Pot} elevado a {expoente} é igual a: {potencia}");
            Console.WriteLine("\nAperte Enter Para Votar Para O Menu");
            Console.ReadKey();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um número ");

            Console.Write("Informe um número: ");
            string rar = Console.ReadLine().Replace(".", ",");

            float raizqua = float.Parse(rar);

            float result =(float) Math.Sqrt(raizqua);

            Console.Write($"\nA raiz de {raizqua} é: {result}");
            Console.WriteLine("\nAperte Enter Para Votar Para O Menu");
            Console.ReadKey();
        }
    }
}
