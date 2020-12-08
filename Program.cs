using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
           
            pf.cpf = "455.463.328.40";

            pf.nome = "Caic";

            PessoaJuridica pj = new PessoaJuridica();
            
            pj.cnpj= "00000000000000000000";
           
            
            Console.WriteLine( pf.DarBoasVindas(pf.nome));
            
            Console.WriteLine(pj.ValidarCNPJ (pj.cnpj));

            Console.WriteLine (pf.ValidarCPF (pf.cpf));
            Console.ResetColor();
        }
    }
        }
    