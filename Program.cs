using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos a sublcasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();

            // Atribuímos um cpf ao objeto
            pf.cpf = "000.000.000-00";

            pf.nome = "Marcos";

            // Chamamos nosso método de saudação dentro de um ConsoleWriteLine
            Console.WriteLine( pf.DarBoasVindas(pf.nome));
            // Chamamos nosso méto de validação da subclasse
            Console.WriteLine( pf.ValidarCPF(pf.nome));
        }
    }
}
