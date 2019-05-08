using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Clinica
{
    class Paciente:Pessoa
    {
        private string enfermidade;
        private string tipoSang;

        public string Enfermidade { get { return enfermidade; } set { enfermidade = value; } }
        public string TipoSang { get { return tipoSang; } set { tipoSang = value; } }

        public Paciente()
        {

        }

        public string MostraPaciente()
        {
            return MostraPessoa() + ", " + Enfermidade + "," + TipoSang;
        }
    }
}
