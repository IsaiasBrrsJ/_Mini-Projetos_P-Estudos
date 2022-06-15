using System;
using System.Collections.Generic;
using System.Text;

namespace LogSystem
{
    static class CadastrarUsuario
    {
        private static Usuario[] _cadastrarUsuario =
        {
            new Usuario{Nome ="Isaias", Senha = "123" }
        };

        private static Usuario _usuarioLogado = null;

        public static Usuario UsuarioLogado
        {
            get => _usuarioLogado ;
            private set
            {
                _usuarioLogado = value;
            }

        }

        public static bool LoginUsuario(string nome, string senha)
        {
            foreach(Usuario userLogado in _cadastrarUsuario)
            {
                if (userLogado.Nome.Equals(nome) && userLogado.Senha.Equals(senha))
                {   
                    _usuarioLogado = userLogado;
                    return true;
                }                
            }

            return false;
        }


     

    }
}
