using System;
using Herenca_POO.classes;

namespace Herenca_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();
            
            
            
            string opcao = "";
            do
            {  
               Console.WriteLine("--Menu de opções--");
               Console.WriteLine("Digite a opção abaixo : ");
               Console.WriteLine("[1] - Pessoa Física");
               Console.WriteLine("[2] - Pessoa Jurídica");
               Console.WriteLine("[0] - Sair");
               opcao = Console.ReadLine();

                
               switch (opcao)
               {
                    case "1":
                        Console.Write("Digite o nome: ");
                        pf.nome = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(pf.DarBoasVindas(pf.nome));
                        Console.ResetColor();
                        Console.Write("Digite o RG: ");
                        pf.rg = Console.ReadLine();
                        Console.Write("Digite o CPF: ");
                        pf.cpf = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(pf.ValidarCPF(pf.cpf));
                        Console.ResetColor();
                        
                    break;
                    
                    case "2":
                        Console.Write("Digite a razão social: ");
                        pj.nome = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(pj.DarBoasVindas(pj.nome));
                        Console.ResetColor();
                        Console.Write("Digite a Inscrição Estadual: ");
                        pj.inscricaoEstadual = Console.ReadLine();
                        Console.Write("Digite o CNPJ:");
                        pj.cnpj = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(pj.ValidarCNPJ(pj.cnpj));
                        Console.ResetColor();
                    break;
                    
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("---Menu encerrado---");
                        Console.ResetColor();
                    break;
               }
               

            } while (opcao != "0");

            

        }
    }
}
