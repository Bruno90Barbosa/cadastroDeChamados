using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeF;
            string setorF;
            string problema;
            int chamado;
            int matricula;
            string tec1 = "Daniel";
            string tec2 = "Alice";
            string tec3 = "Pedro";
            string tec4 = "Maria";


            Console.WriteLine("Cadastro de Chamados TI");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nome do Funcionário: ");
            nomeF = Console.ReadLine();
            Console.WriteLine("Numero da Matrícula: ");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Setor: ");
            setorF = Console.ReadLine();
            Console.WriteLine("Resuma o problema: ");
            problema = Console.ReadLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine(nomeF+", Digite APENAS de 0 até 10 o nivel de urgência do chamado:");
            chamado = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("");

            if (chamado >= 0 && chamado <= 3)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Chamado Registrado");
                Console.WriteLine("------------------");
                Console.WriteLine("");
                Console.WriteLine("SOLICITANTE: "+nomeF);
                Console.WriteLine("MATRICÚLA: " + matricula);
                Console.WriteLine("SETOR: " + setorF);
                Console.WriteLine("PROBLEMA: "+ problema);
                Console.WriteLine("------------------------");
                Console.WriteLine("NÍVEL DE URGÊNCIA: Baixo");
                Console.WriteLine("------------------------");
                Console.WriteLine("Estaremos atendendo o seu chamado em até 3 horas apartir de agora..");
                Console.WriteLine("TÉCNICO RESPONSAVEL PELO ATENDIMENTO: "+tec1);
            }
            else if (chamado >= 3 && chamado <= 6)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Chamado Registrado");
                Console.WriteLine("------------------");
                Console.WriteLine("");
                Console.WriteLine("SOLICITANTE: " + nomeF);
                Console.WriteLine("MATRICÚLA: " + matricula);
                Console.WriteLine("SETOR: " + setorF);
                Console.WriteLine("PROBLEMA: " + problema);
                Console.WriteLine("------------------------");
                Console.WriteLine("NÍVEL DE URGÊNCIA: Médio");
                Console.WriteLine("------------------------");
                Console.WriteLine("Estaremos atendendo o seu chamado em até 2 horas apartir de agora.");
                Console.WriteLine("TÉCNICO RESPONSAVEL PELO ATENDIMENTO: " + tec2);
            }
            else if (chamado > 6 && chamado <= 9)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Chamado Registrado");
                Console.WriteLine("------------------");
                Console.WriteLine("");
                Console.WriteLine("SOLICITANTE: " + nomeF);
                Console.WriteLine("MATRICÚLA: " + matricula);
                Console.WriteLine("SETOR: " + setorF);
                Console.WriteLine("PROBLEMA: " + problema);
                Console.WriteLine("-----------------------");
                Console.WriteLine("NÍVEL DE URGÊNCIA: Alto");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Estaremos atendendo o seu chamado em até 1 hora apartir de agora.");
                Console.WriteLine("TÉCNICO RESPONSAVEL PELO ATENDIMENTO: " + tec3);
            }
            else if (chamado > 9 && chamado == 10)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Chamado Registrado");
                Console.WriteLine("------------------");
                Console.WriteLine("");
                Console.WriteLine("SOLICITANTE: " + nomeF);
                Console.WriteLine("MATRICÚLA: " + matricula);
                Console.WriteLine("SETOR: " + setorF);
                Console.WriteLine("PROBLEMA: " + problema);
                Console.WriteLine("-----------------------");
                Console.WriteLine("NÍVEL DE URGÊNCIA: Grave");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Estaremos atendendo o seu chamado em até 30 minutos apartir de agora.");
                Console.WriteLine("TÉCNICO RESPONSAVEL PELO ATENDIMENTO: " + tec4);
            }
            else
            {
                Console.WriteLine("Digite Apenas os número de 0 até 10");
                Console.WriteLine("Refaça o chamado novamente");
            }

            Console.ReadLine();
        }
    }
}
