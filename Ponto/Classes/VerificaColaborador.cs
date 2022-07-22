using System;


namespace RegistrarPonto
{
    class VerificaColaborador
    {

        private Colaborador _logado = null;

        private Colaborador[] colaboradores =
        {
           new Colaborador() {nome = "Isaias", matricula = 111, senha = "teste123"},
           new Colaborador() {nome = "Barros Jesus", matricula = 333, senha = "333"}
        };

        public Colaborador LOGADO
        {
            get => _logado;
            private set
            {
                _logado = value;
            }
        }

        public string Log(int matricula, string senha)
        {
            foreach (Colaborador colaborador in colaboradores)
            {
              if((colaborador.matricula.Equals(matricula) && colaborador.senha.Equals(senha)) && colaborador.logado is null)
                {
                    colaborador.logado = true;
                    LOGADO = colaborador;
                    colaborador.entrada = DateTime.Now;
                    return "Entrou";
                }
                else if((colaborador.matricula.Equals(matricula) && colaborador.senha.Equals(senha)) && (colaborador.logado is true))
                {
                    colaborador.logado = null;
                    LOGADO = colaborador;
                    colaborador.saida = DateTime.Now;
                    return "Saiu";
                }
            }

            return "";
        }
      
    }
}
