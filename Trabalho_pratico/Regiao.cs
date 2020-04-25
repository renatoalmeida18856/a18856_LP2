using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_pratico
{
    class Regiao
    {
        #region Regioes
        public int Id;
        public string Nome;
        #endregion

        #region Construtores
        public Regiao(string nome)
        {
            this.nome = nome;
        }

        #endregion

        #region Propriedades Regiao

        public string nome
        {
            get { return nome; }
            set { nome= value; }
        }

        #endregion

        #region Adicionar Regiao

        #endregion

        #region Listar Regioes

        #endregion
    }
}
