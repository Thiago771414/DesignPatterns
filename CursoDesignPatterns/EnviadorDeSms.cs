using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("SMS");
        }
    }
}
