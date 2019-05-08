using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_Clinica
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            List<Paciente> Pacientes = new List<Paciente>();
            List<Médico> Médicos = new List<Médico>();
            TData data_aux = null;
            Médico médico = null;
            Paciente paciente = null;

            do
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("[ 1 ] Cadastar médicos");
                Console.WriteLine("[ 2 ] Cadastrar pacientes");
                Console.WriteLine("[ 3 ] Associar paciente ao médico");
                Console.WriteLine("[ 4 ] Listar pacientes por médico");
                Console.WriteLine("[ 5 ] Sair");
                Console.WriteLine("=================================");
                Console.Write("Sua opção: ");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("=================================");
                Console.Clear();
                switch (op)
                {
                    case 1:
                        médico = new Médico();

                        Console.Write("Informe o nome do médico: ");
                        médico.Nome = Console.ReadLine();
                        Console.Write("Informe o sexo do médico: ");
                        médico.Sexo = char.Parse(Console.ReadLine());

                        data_aux = new TData();

                        Console.WriteLine("Informe a data de nascimento: ");
                        Console.Write("Informe o dia: ");
                        data_aux.Dia = int.Parse(Console.ReadLine());
                        Console.Write("Informe o mês: ");
                        data_aux.Mes = int.Parse(Console.ReadLine());
                        Console.Write("Informe o ano: ");
                        data_aux.Ano = int.Parse(Console.ReadLine());

                        médico.DataNasc = data_aux;

                        Console.WriteLine("Informe a especialidade: ");
                        médico.Especialidade = Console.ReadLine();
                        Console.WriteLine("Informe a escala: ");
                        médico.Escala = Console.ReadLine();

                        Médicos.Add(médico);

                        Console.WriteLine("Médico cadastrado!");
                        Console.ReadKey();

                        break;
                    case 2:
                        paciente = new Paciente();
                        Console.WriteLine("Informe o nome do paciente: ");
                        paciente.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o sexo do paciente: ");
                        paciente.Sexo = char.Parse(Console.ReadLine());

                        data_aux = new TData();

                        Console.WriteLine("Informe a data de nascimento: ");
                        Console.WriteLine("Informe o dia: ");
                        data_aux.Dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o mês: ");
                        data_aux.Mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o ano: ");
                        data_aux.Ano = int.Parse(Console.ReadLine());

                        paciente.DataNasc = data_aux;

                        Console.WriteLine("Enfermidade: ");
                        paciente.Enfermidade = Console.ReadLine();
                        Console.WriteLine("Tipo sanguíneo: ");
                        paciente.TipoSang = Console.ReadLine();

                        Pacientes.Add(paciente);

                        Console.WriteLine("Paciente cadastrado!");
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.Write("Informe o paciente: ");
                        string nome_aux = Console.ReadLine();

                        foreach (Paciente P in Pacientes)
                        {
                            if (P.Nome == nome_aux)
                            {

                                Console.Write("Informe o médico: ");
                                nome_aux = Console.ReadLine();

                                foreach (Médico m in Médicos)
                                {
                                    if (m.Nome == nome_aux)
                                    {
                                        m.AddPaciente(P);
                                        Console.WriteLine("Paciente inserido!");
                                        Console.ReadKey();
                                    }
                                }

                                break;
                            }
                        }
                        break;
                    case 4:
                        foreach (Médico m in Médicos)
                        {
                            Console.WriteLine("Nome do Médico: " + m.Nome + "\nPacientes:");
                            foreach (Paciente p in m.Pacientes)
                            {
                                Console.WriteLine(p.MostraPaciente());
                            }
                        }
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (op!=5);
        }
    }
}
