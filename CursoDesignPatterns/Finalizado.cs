using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            Console.WriteLine("Orçamentos finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            Console.WriteLine("Orcamento já está finalizado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            Console.WriteLine("Orcamento já está finalizado.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            Console.WriteLine("Orcamento já está finalizado.");
        }
    }
}
