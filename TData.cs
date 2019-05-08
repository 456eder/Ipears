using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Clinica
{
    class TData
    {
        private int dia, mes, ano;

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }

        public TData() { }

        public string getData()
        {
            return Dia.ToString("00") + Mes.ToString("/00") + Ano.ToString("/0000");
        }
    }
}
