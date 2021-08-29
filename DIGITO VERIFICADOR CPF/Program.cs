using System;
using System.Threading;
using System.Collections.Generic;

namespace digitoVerificadorCpf
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Mini Verificador De CPF Possivelmente Válidos, Para Praticar a Linguagem C# com .Net
          
           var menu = Menu();
           escolha(menu);

        }

        public static string Menu(){

            Console.Clear();
            Console.Write("\t\t                  ===========                   ");
            Console.Write("\n\t\t                   Bem-Vindo                   \n");
            Console.Write("\t\t                  ===========                   \n");

            Console.Write("\t\t|==============================================|\n");
            Console.Write("\t\t*                                              *");
            Console.Write("\n\t\t|            1) Consultar CPF                  |");
            Console.Write("\n\t\t*            2) Verificar DV Verificadores     *");
            Console.Write("\n\t\t|            3) Sair                           |");
            Console.Write("\n\t\t*                                              *\n");
            Console.Write("\t\t|==============================================|");

        
           string opcao = "";
      
           while(opcao != "1" && opcao != "2" && opcao != "3"){

              Console.Write("\n\t\t  Escolha uma opção: ");
               opcao = Console.ReadLine();
           
           }
           
           return opcao;  
        }
        
        static void escolha(string menu){


           int escolhas = Convert.ToInt32(menu);  

           switch(escolhas){

             case 1:
              var cpf_string = CpfVAlido();
              var cpf_int = CpfAutenticados(cpf_string);
             break;

             case 2:

             var cpfCRU= VerifcadorCpf();
             var calculo = CalculoCpf(cpfCRU);
             break;

             case 3:
             Console.Write("\n\t\tEncerrando....");
             Thread.Sleep(1000);
             Console.Write("\n\n\t\tVOLTE SEMPRE (<;");
             Console.ReadKey();
             break;
           }
          
        }
             
        public static string VerifcadorCpf(){

            string cpf;

            Console.Write("\nDigite os 9 Primeiros Digitos Do CPF: ");
             cpf = Console.ReadLine().Trim();

              cpf = cpf.Replace(".", "").Replace("-","").Replace(",", "");

              

              while(cpf.Length > 9 || cpf.Length < 9)
              {
                  if(cpf.Length > 9){
                    Console.Write("\n\n\tPor Favor, Digite Apenas 9 Digitos....");
                     Thread.Sleep(2000);
                      Console.Clear();
                  }
                  if(cpf.Length < 9){

                      Console.Write("\n\n\tPor Favor, Digite 9 Digitos....");
                       Thread.Sleep(2000);
                        Console.Clear();
                  }

                 
               Console.Write("\n\t====================");
               Console.Write("\n\t VERIFICADOR DE CPF\n");
               Console.Write("\t====================");

          
            
              Console.Write("\nDigite os 9 Primeiros Digitos Do CPF: ");
               cpf = Console.ReadLine().Trim();

                cpf = cpf.Replace(".", "").Replace("-","");

               

            }

            return cpf;        
   
        }
        public static int[] CalculoCpf(string cpfCRU){

           
           char[] cpf_P_Converter = cpfCRU.ToCharArray();
           int[] cpfNovo = new int[11];
           int soma= 0;
           int restoDivi1 = 0;
           int restoDivi2 = 0;
            const int dvCPF = 11;

           int controlador = 0;
          
           
           for(int i = 0; i < cpf_P_Converter.Length; i++){

               controlador++;
             
             cpfNovo[i] = Convert.ToInt32(cpf_P_Converter[i].ToString()); 
            
             soma += cpfNovo[i] * controlador;
         
           }
       
            restoDivi1 = soma % dvCPF;

              if(restoDivi1 < 2 || restoDivi1 >= 10)
              {
                   restoDivi1 = 0;
                   cpfNovo[9] = restoDivi1;
              }
               else
               {
                  cpfNovo[9] = restoDivi1;
               }

           
           int controlador2 = 0;
           soma = 0;

            for(int i = 0; i < cpfNovo.Length; i++){

              soma += cpfNovo[i] * controlador2;

              controlador2++;
           }

             restoDivi2 = soma % dvCPF;

             if(restoDivi2 < 2 || restoDivi2 >= 10)
             {
               restoDivi2 = 0;
               cpfNovo[10] = restoDivi2;
             }
              else
              {
                cpfNovo[10] = restoDivi2;
              }

            Console.Write("\n\nVerificando....");
            Thread.Sleep(2000);
            Console.Clear();

             Console.Write("\n\n\t\t     NÚMERO DO CPF\n");

            Console.Write("\n\t\t========================\n");
            Console.Write($"\t\t     {cpfNovo[0]}{cpfNovo[1]}{cpfNovo[2]}.{cpfNovo[3]}{cpfNovo[4]}{cpfNovo[5]}.{cpfNovo[6]}{cpfNovo[7]}{cpfNovo[8]}-{cpfNovo[9]}{cpfNovo[10]}");
            Console.Write("\n\t\t========================\n");
            
            Thread.Sleep(1000);
            RegiaoCpf(cpfNovo);
            Console.ReadKey();
             
            return cpfNovo;
        }
       

        public static string CpfVAlido(){
          
           string cpfVerifi;

            Console.Write("\nDigite os 11 Primeiros Digitos Do CPF: ");
             cpfVerifi = Console.ReadLine().Trim();

              cpfVerifi = cpfVerifi.Replace(".", "").Replace("-","").Replace(",", "");

              while(cpfVerifi.Length > 11|| cpfVerifi.Length < 11)
              {
                  if(cpfVerifi.Length > 11){
                    Console.Write("\n\n\tPor Favor, Digite Apenas 11 Digitos....");
                     Thread.Sleep(2000);
                      Console.Clear();
                  }
                  if(cpfVerifi.Length < 11){

                      Console.Write("\n\n\tPor Favor, Digite 11 Digitos....");
                       Thread.Sleep(2000);
                        Console.Clear();
                  }

                 
               Console.Write("\n\t====================");
               Console.Write("\n\t VERIFICADOR DE CPF\n");
               Console.Write("\t====================");

          
            
              Console.Write("\nDigite os 11 Primeiros Digitos Do CPF: ");
               cpfVerifi = Console.ReadLine().Trim();

                cpfVerifi = cpfVerifi.Replace(".", "").Replace("-","");

               

            }

            return cpfVerifi;

        }

        static int[] CpfAutenticados(string cpfVerifi){

          char[] cpfConvert = cpfVerifi.ToCharArray();//Pega o cpf em string transforma em caracteres e joga pra array
          int[] cpfsConvertidos = new int[11]; //cpfs convertido em inteiro

          int soma =0;
          int soma2 = 0;
          int restoDivi1 = 0;
          int restoDivi2 = 0;
          int controlador = 1;
          int controlador2 = 0;
          
          const int dvCPF = 11;

          for(int i = 0; i < cpfVerifi.Length; i++){
         
            cpfsConvertidos[i] = Convert.ToInt32(cpfConvert[i].ToString());// conversão da array de char para inteiro.
          }

          for(int i = 0; i < 9; i++){
             
            soma += cpfsConvertidos[i] * controlador;
            controlador++;

          }
          
          for(int i = 0; i < 10; i++){

              soma2 += cpfsConvertidos[i] * controlador2;
              controlador2++;
          }

          restoDivi1 = soma % dvCPF;
          restoDivi2 = soma2 % dvCPF;

          
          if(restoDivi1 < 2 || restoDivi1 >= 10){restoDivi1 = 0; }
          if(restoDivi2 < 2 || restoDivi2 >= 10){restoDivi2 = 0; }

          // se o nono decimo digito for igual o resto da divisao, então é um possivel cpf valido
          if(cpfsConvertidos[9] == restoDivi1 && cpfsConvertidos[10] == restoDivi2){

              Console.Write("\n\nVerificando....\n");
              Thread.Sleep(2000);
            
            
          
           Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\n\t\tCPF VÁLIDO..");
            Console.ResetColor();
            RegiaoCpf(cpfsConvertidos);
            Console.ReadKey();
            

          }
            else{

              Console.Write("\n\nVerificando....\n");
              Thread.Sleep(2000);
            
            
                Console.BackgroundColor = ConsoleColor.Red;
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.Write("\n\n\tCPF INVÁLIDO..");
                Console.ResetColor();
                Console.ReadKey();

            }

          return cpfsConvertidos;
        }
         static void RegiaoCpf(int[] cpfNovo){

           //Aqui recebe o 9 digito e verifica possiveis estados

            Console.ForegroundColor = ConsoleColor.DarkCyan; // muda a cor pra DARCYAN
            
           switch(cpfNovo[8]){

             case 1:
              Console.Write("\n\t\tPossivel Origem Do CPF: (DF-GO-MS-MT-TO)");
             break;

             case 2:
              Console.Write("\n\t\tPossivel Origem Do CPF: (AC-AM-AP-PA-RO-RR)");
             break;

             case 3:
              Console.Write("\n\t\tPossivel Origem Do CPF: (CE-MA-PI)");
             break;

             case 4:
             Console.Write("\n\t\tPossivel Origem Do CPF: (AL-PB-PE-RN)");
             break;

             case 5:
             Console.Write("\n\t\tPossivel Origem Do CPF: (BA-SE)");
             break;

             case 6:
             Console.Write("\n\t\tPossivel Origem Do CPF: (MG)");
             break;

             case 7:
             Console.Write("\n\t\tPossivel Origem Do CPF: (ES-RJ)");
             break;

             case 8:
             Console.Write("\n\t\tPossivel Origem Do CPF: (SP)");
             break;

             case 9:
             Console.Write("\n\t\tPossivel Origem Do CPF: (PR-SC)");
             break;

             case 0:
              Console.Write("\n\t\tPossivel Origem Do CPF: (RS)");
             break;

             
           }
        } 
  
    }
    
}
