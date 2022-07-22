using System;


namespace RegistrarPonto
{
    class Colaborador
    {
        public string nome { get; set; }
        public int matricula { get; set; }
        public string senha { get; set; }

        public DateTime? entrada { get; set; }
        public DateTime? saida { get; set; }

        public bool? logado { get; set; }
    }
}
