using System;
using System.Threading;
namespace atv2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mais Alguns Ajustes Ele Melhora
            Pintar_A_Parede();

        }
        public static void Pintar_A_Parede(){


             // Sr. João Possui uma loja de tintas , visto que os seus vendedores perdia muito 
            // tempo com o calculo da quantidade de tintas usado na pintura, decidiu contratar um 
            // Desenvolvedor para fazer um programa que calcule a litragem de tinta usado nos cômodos.

            float largParede =0, altuParede = 0, rendimento =0;

            float janelaLargura =0, janelaAltura=0, portaLargura=0, portaAltura=0; // se houver portas e janelas

            float calcPortas = 0, calcJanelas = 0; // calculo das portas de janelas se houver

            float area1 = 0, area2 = 0, area3 = 0, area4 = 0; // calculo das areas

            float litrosDeTinta1 = 0, litrosDeTinta2 = 0, litrosDeTinta3 = 0, litrosDeTinta4 = 0;

            int jan, porta;
            int demao =0;

            Console.Clear(); // Limpa tudo antes de iniciar

         try{
            Console.Write("\nInforme a largura da parede: ");
             largParede =float.Parse(Console.ReadLine());

            Console.Write("\nInforme a altura da parede: ");
             altuParede =float.Parse(Console.ReadLine());

            Console.Write("\nDigite quantas demãos de tinta será necessário: ");
             demao = int.Parse(Console.ReadLine());

            Console.Write("\nInforme a rendimento da tinta conforme o fabricante m²: ");
             rendimento = float.Parse(Console.ReadLine());


            Console.Write("\n\tSeu comodo possui janelas 1-(sim), 2-(não): ");
             jan = int.Parse(Console.ReadLine().ToLower());

            Console.Write("\n\tSeu comodo possui Portas 1-(sim), 2-(não): ");
             porta = int.Parse(Console.ReadLine().ToLower());

            while(jan == 1  || porta == 1 ){

                 if(jan == 1 && porta == 1){
                 
                    Console.Write("\n\tInforme a largura da janela: ");
                     janelaLargura = float.Parse(Console.ReadLine());

                     Console.Write("\n\tInforme a altura da janela: \n");
                      janelaAltura = float.Parse(Console.ReadLine());  

                     calcJanelas = janelaLargura * janelaAltura;

                     Console.Write("\n\tInforme a largura da prota: ");
                     portaLargura = float.Parse(Console.ReadLine());

                     Console.Write("\n\tInforme a altura da porta: \n");
                      portaAltura = float.Parse(Console.ReadLine());  
                     
                     calcPortas = portaLargura * portaAltura;

                     break;  //Caso tenha ambos
                 } 

                     else if(porta == 1){

                       Console.Write("\n\tInforme a largura da porta: ");
                        portaLargura = float.Parse(Console.ReadLine());

                       Console.Write("\n\tInforme a altura da porta: ");
                        portaAltura = float.Parse(Console.ReadLine());  
                      
                       calcPortas = portaLargura * portaAltura;

                       break; // CASO TENHA SÓ PORTA PARA O LOOP AQUI
                   }
                     else if(jan == 1){

                       Console.Write("\n\tInforme a largura da janela: ");
                        janelaLargura = float.Parse(Console.ReadLine());

                       Console.Write("\n\tInforme a altura da janela: ");
                        janelaAltura = float.Parse(Console.ReadLine());  

                       calcJanelas = janelaLargura * janelaAltura;

                        break; // Caso tenha apenas janelas
                   }
                 
                
            }
        
            // AQUi EXECUTA TODO O CALCULO CASO O COMODO TENHA JANELAS E PORTAS    
             if(jan == 1 && porta == 1){
             

                 area1 = (largParede * altuParede) - (calcJanelas + calcPortas);
                 litrosDeTinta1 = (area1 * demao) / rendimento;

                 Console.Write($"\n\tSeu Cômodo tem {area1.ToString("0.0")}m²\n");
                 Console.Write($"\n\tVocê Precisará de {litrosDeTinta1.ToString("0.0")}l de tinta\n");
                
             }
             // AQUi EXECUTA TODO O CALCULO CASO O COMODO TENHA JANELAS;    
               else if(jan == 1){

                 area2 = (largParede * altuParede) - calcJanelas;
                 litrosDeTinta2 = (area2 * demao) / rendimento;

            

                 Console.Write($"\n\tSeu Cômodo tem {area2.ToString("0.0")}m²\n");
                 Console.Write($"\n\tVocê Precisará de {litrosDeTinta2.ToString("0.0")}l de tinta\n");
                
             } 

             // AQUi EXECUTA TODO O CALCULO CASO O CÔMODO TENHA PORTAS    
               
                else if(porta == 1){

                  area3 = (largParede * altuParede) - calcPortas;
                  litrosDeTinta3 = (area3 * demao) / rendimento;

                  Console.Write($"\n\tSeu Cômodo tem {area3.ToString("0.0")}m²\n");
                  Console.Write($"\n\tVocê Precisará de {litrosDeTinta3.ToString("0.0")}l de tinta\n");

                }
            
            // AQUi EXECUTA TODO O CALCULO CASO O CÔMODO NÂO TENHA NEM JANELA NEM PORTAS    
            else{

                 area4 = (largParede * altuParede);
                 litrosDeTinta4 = (area4 * demao) / rendimento;
                 
                 Console.Write($"\n\tSeu Cômodo tem {area4.ToString("0.0")}m²\n");
                 Console.Write($"\n\tVocê Precisará de {litrosDeTinta4.ToString("0.0")}l de tinta\n");
                 
            }

         }
           catch{

              Console.Write("\nAlgo Deu Errado, Refaça o procedimento....\n");
              Thread.Sleep(1000);// temporizador pra mostar a mensagem antes de limpar
              Console.Clear();//aqui limpa a tela
              Pintar_A_Parede();// chama todo o codigo desde o inico
           }
        }
             
    }
}
