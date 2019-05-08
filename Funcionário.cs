using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Clinica
{
    class Funcionário:Pessoa
    {
        private string cargo;
        private double salario;
        private TData dataAdm;

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public TData DataAdm
        {
            get { return dataAdm; }
            set { dataAdm = value; }
        }
        public Funcionário()
        { }

        public string MostraFuncionario()
        {
            string aux = "";
            aux = base.MostraPessoa() + " <> " + cargo + " <> " + salario + " <> " + dataAdm;
            return aux;
        }
    }
}
