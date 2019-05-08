using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Clinica
{
    class Pessoa
    {
        private string nome;
        private TData dataNasc;
        private char sexo;

        public string Nome { get => nome; set => nome = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        internal TData DataNasc { get => dataNasc; set => dataNasc = value; }

        public Pessoa() { }

        public string MostraPessoa()
        {
            return Nome + ", " + Sexo + ", " + DataNasc.getData();
        }
    }
}
