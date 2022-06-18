using System;
using System.Collections.Generic;

namespace JobRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("===============");
             Soma();
            Console.WriteLine("===============\n\n");
            Fibonacci();

            DescubraALogicaECompleteOProximoElemento();

            InverterString();
            Distancia();
            Console.ReadKey();
        }
        static void Soma()
        {
            int indice = 13, soma = 0, K = 0;

            while (K < indice)
            {
                K++;
                soma += K;

            }
            Console.WriteLine($"Soma: {soma}");
        }
        static void Fibonacci()
        {
            int seraSePertenceAoFibonacci = 4;
            string pertenceAFibonacci = "";
            int a = 0, b = 1, soma = 0;
            bool pertence = false;


            for (int i = 0; i < 30; i++)
            {

                if (soma.Equals(seraSePertenceAoFibonacci)) // se for igual vai entrar aqui
                {
                    pertence = true; // vai definir como true 
                    pertenceAFibonacci = $"o numero informado ({seraSePertenceAoFibonacci}) existe na sequencia de Fibonnacci\n";
                }
                else
                {
                    if (pertence.Equals(false)) // so vai cair aqui se a variavel pertence continuar como false;
                    {
                        pertenceAFibonacci = $"o numero informado ({seraSePertenceAoFibonacci}) não existe na sequencia de Fibonnacci\n";
                    }
                }

                soma = a + b;
                a = b; // a variavel (a)  vai receber o valor de (b);
                b = soma; //a variavel (b) vai receber o resultado de (a+b);

            }


            Console.WriteLine(pertenceAFibonacci);
        }
        static void DescubraALogicaECompleteOProximoElemento()
        {
            Console.WriteLine("\n====================");
            int a = 1, soma = 0;
            for (int i = 0; i < 5; i++){ 

                //a) 1, 3, 5, 7, ___

                soma = a;
                a += 2;

                Console.Write("|" + soma);
            }

            Console.WriteLine("\n====================");

            const int b = 2; 
            int soma1 = b;
           
            for(int i = 0; i < 7; i++)
            {
                //b) 2, 4, 8, 16, 32, 64, ____

                Console.Write("|" + soma1);
                soma1 *= b; 
            }
            Console.WriteLine("\n====================");


            int impar = 1, soma2 = 0;

            for(int i = 1; i < 9; i++)
            {
                //c) 0, 1, 4, 9, 16, 25, 36, ____

                Console.Write("|"+soma2);
                soma2 += impar;
                impar += 2;
            }
            Console.WriteLine("\n====================");

            int par = 0, soma3 = 0;
            
            for(int i = 0; i < 6; i++)
            {
                //d) 4, 16, 36, 64, ____

                if (i < 5)
                {
                    par += 2;
                    soma3 = par * par;
                    Console.Write("|" + soma3);
                }
            }
            Console.WriteLine("\n====================");
            int num1 = 1, num2 = 1, soma4 = 1;

            for(int i = 0; i < 6; i++)
            {
                //e) 1, 1, 2, 3, 5, 8, ____

                if (i == 0)
                {
                    Console.Write($"{num1}"); 
                }
                Console.Write("|" + soma4);

                soma4 = num1 + num2; 
                num1 = num2;
                num2 = soma4;
            }
            Console.WriteLine("\n=========================");

            // f) 2,10, 12, 16, 17, 18, 19, ____
            Console.Write($"|{2}|{10}|{12}|{16}|{17}|{18}|{19}|{200}");
            Console.Write("\n|D| D| D| D| D| D| D| D");
            Console.WriteLine("\n=========================");
          

        }
        static void Distancia()
        {
            float distanciaCidade = 100f;
            const float velocidadeMediaCarro = 110f;
            const float velocidadeMediaCaminhao = 80f;

            var resultadoCarro = CalculoCarro(velocidadeMediaCarro, distanciaCidade);
            var resultadoCaminhao = CalculoCaminhao(velocidadeMediaCaminhao, distanciaCidade);

            

            Console.WriteLine("\nCarro chegará em: " + resultadoCarro.ToString("0") + " Minuto(s)");
            Console.WriteLine("\nCaminhao chegará em: " + resultadoCaminhao  + " Minuto(s)");

            Console.WriteLine("\nCreio que quando os carros se cruzarem os mesmo vão está na mesma distância, pois ambos estarão em paralelo, lado a lado");
           
        }

        static float CalculoCarro(float velocidadeCarro, float distanciaDaCidade)
        {
            float deltaT = distanciaDaCidade / velocidadeCarro;
            float resultado = deltaT * 60;
            return resultado ;
        }

        static float CalculoCaminhao(float velocidadeCaminhao, float distanciaDaCidade)
        {
            float deltaT = distanciaDaCidade / velocidadeCaminhao;
            float resultado = deltaT * 60;
            float doisPedagiosDeCinco = 10;

            return resultado + doisPedagiosDeCinco;
        }

        static void InverterString()
        {
            //Escreva um programa que inverta os caracteres de um string

            string  nome = "Job Rotation";
            string Invertido = "";

            for(int i = nome.Length; i > 0; i--)
            {
                Invertido += nome[i-1].ToString();
            }

            Console.WriteLine($"\n\nJob Rotation, INVERTIDO: {Invertido}");

        }
    }
}
