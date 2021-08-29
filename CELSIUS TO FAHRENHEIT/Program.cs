using System;
using System.Threading;

namespace projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Mini Projeto Conversor de Temperatura Para Fins De Aprendizado*/

            Conversor();
            
            Voltar();
            
        }

        static void Conversor(){

         int opcao =0;
        
        try{
         while(opcao != 1 && opcao != 2){

            Console.Write("\n\t   Bem -Vindo ao Conversor de Temperaturas 1.0\n");
            
            Console.Write("\n\t\t=================================");
            Console.Write("\n\t\t  1 - Celsius -> Fahrenheit\n\t\t  2 - Fahrenheit -> Celsius");
            Console.WriteLine("\n\t\t=================================");

           
            Console.Write("\n\n\t\tEscolha Uma Opção: ");
             opcao = int.Parse(Console.ReadLine());
             
             if(opcao != 1 && opcao != 2 ){
                 
               Console.Clear(); //So vai limpar a tela se não atender as condições.
             }

            }
        }catch{

            //Caso caia no exeption ele retorna todo o programa.
            Console.Clear();
            Conversor();
        

        }
          
            
             try{
             switch (opcao){
                 

                case 1:
               
                Console.Write("\n\t\tInforme os graus °C: ");
                 string celsius =Console.ReadLine().Replace(".", ",");//aqui caso a pessoa digite '1.8' ele converte para '1,8'.
                
                 
                 float celsiusConvertido = float.Parse(celsius);//converte celsius para float.

                 float calculoCelsius =(float) ( celsiusConvertido * 1.8) + 32;

                 //Temporizador para fins de perfumaria(estetica).
                 Console.Write("\n\t\tConvertendo....\n");
                  Thread.Sleep(1000); //

                 Console.Write("\n\t\t=========================");   
                  Console.Write($"\n\t\t  {celsiusConvertido} °C em °F = {calculoCelsius.ToString("F1")}");
                 Console.Write("\n\t\t=========================");  
                
               

                break;
            
                
                case 2:

                Console.Write("\n\t\tInforme os graus °F: ");
                 string fahrenheit =Console.ReadLine().Replace(".", ",");
                 
                 float fahrenheitConvertido = float.Parse(fahrenheit);

                 double calculoFahrenheit = (fahrenheitConvertido - 32 ) / 1.8;

                 Console.Write("\n\t\tConvertendo....\n");
                  Thread.Sleep(1000);

                 Console.Write("\n\t\t=========================");   
                  Console.Write($"\n\t\t  {fahrenheitConvertido} °F em °C = {calculoFahrenheit.ToString("F1")}");
                 Console.Write("\n\t\t=========================");  
                 
                 
                break;
              

            }
             }catch{

                 Console.Write("\n\t\tIncorreto....");
                 Console.Clear();
                 Conversor();
             }
                       
        }
        static void Voltar(){

            // opcão de fazer uma nova conversão

             char esco = 'S';
             try{
             while(esco == 'S'){
                 Console.Write("\n\n\t\tDeseja Fazer outra conversão (S) para sim (N) para não: ");
                  esco = char.Parse(Console.ReadLine().ToUpper());

                if(esco== 'S'){
                    Console.Clear();
                    Conversor();
                }
                else{

                    Console.Clear();
                    Console.Write("\n\t\tVolte Sempre (;");
                    Console.ReadKey();
                }
             }
             }catch{

                 Voltar();
             }

        }
    }
}
