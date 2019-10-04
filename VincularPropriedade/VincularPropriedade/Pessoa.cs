using System;
using System.Collections.Generic;
using System.Text;

namespace VincularPropriedade
{
    public class Pessoa
    {
        private int id;
        private string nome;
        private string pais;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
    }
}
