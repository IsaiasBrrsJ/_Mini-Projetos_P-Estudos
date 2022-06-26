using System;
using System.Collections.Generic;
using System.Text;

namespace FilaDeEspera
{
     static class InserirPaciente 
    {

        private static string _nome { get; set; }
        private static  float  _febre { get; set; }
        private static GrauDeUrgencia _grauDeUrgencia { get; set; }

        private static int _contadorSenha = 0;

        private static List<Paciente> _paciente = _paciente = new List<Paciente>();

        public static void AdcionarPaciente(string nome, float febre)
        {
            
            _nome = nome;
            _febre = febre;

            if(febre > 38.0f)
            {   
                _grauDeUrgencia = GrauDeUrgencia.Vermelha;
            }
            else if(febre > 34.0f && febre < 38.0f)
            {
                _grauDeUrgencia = GrauDeUrgencia.Amarelo;
            }
            else
            {
                _grauDeUrgencia = GrauDeUrgencia.Verde;
            }

            _paciente.Add(new Paciente
            {
                nome = _nome,
                senha = "0" + ++_contadorSenha,
                febre = _febre,
                grauDeUrgencia = _grauDeUrgencia
            });
        }        

        public static List<Paciente> Paciente => _paciente;
        
    }
}
