using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Clinica
{
    class Médico:Pessoa
    {
        private string especialidade;
        private string escala;
        private List<Paciente> pacientes;

        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
        public string Escala
        {
            get { return escala; }
            set { escala = value; }
        }
        public List<Paciente> Pacientes
        {
            get { return pacientes; }
            set { pacientes = value; }
        }

        public Médico()
        {
            Pacientes = new List<Paciente>();
        }
        public void AddPaciente(Paciente P)
        {
            Pacientes.Add(P);
        }
        public string MostraMedico()
        {
            string aux = "";
            aux = base.MostraPessoa() + " <> " + especialidade + " <> " + escala;
            return aux;
        }
    }
}
