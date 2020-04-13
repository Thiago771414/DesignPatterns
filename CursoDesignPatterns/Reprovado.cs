using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            Console.WriteLine("Orçamentos reprovados não recebem desconto extra");
        }
        public void Aprova(Orcamento orcamento)
        {
            Console.WriteLine("Orcamento já está em estado de aprovação");
        }
        public void Reprova(Orcamento orcamento)
        {
            Console.WriteLine("Orçamento está em aprovado, não pode ser reprovado agora");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
